using System;
using System.Configuration; 
using System.Net.Http;
using System.Text;
using System.Text.Json; 
using System.Text.RegularExpressions; 
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic; 

namespace Gerenciamento_De_Chamados
{
    public class AIService
    {
        private readonly string _apiKey;
        private readonly string _apiUrl = "https://generativelanguage.googleapis.com/v1beta/models/gemini-2.5-flash-preview-09-2025:generateContent";  
        private static readonly HttpClient _httpClient = new HttpClient(); 

        public AIService()
        {
            _apiKey = ConfigurationManager.AppSettings["GEMINI_API_KEY"];
            if (string.IsNullOrEmpty(_apiKey))
            {
                throw new InvalidOperationException("API Key do Gemini não encontrada no App.config.");
            }
        }


        public async Task<(string problema, string prioridade, string solucao)> AnalisarChamado(string titulo, 
            string pessoaAfetadas, string ocorreuAnteriormente, string impedeTrabalho, string descricao, string categoria,
            List<string> solucoesAnteriores)
        {
            
            string baseConhecimento = FormatarSolucoes(solucoesAnteriores);

            string prompt = $@"
                Analise o seguinte chamado de suporte técnico:
                Título: {titulo}
                Categoria: {categoria}
                Descrição: {descricao}
                Pessoas Afetadas: {pessoaAfetadas}
                Ocorreu Anteriormente: {ocorreuAnteriormente}
                Impede o Trabalho: {impedeTrabalho}
                
                Regras para definir a prioridade (Aplicar estritamente):
                * Alta: (O problema afeta 'A empresa inteira' OU 'Meu setor') E (Impede o Trabalho = 'Sim'). OU (Afeta 'Somente eu' E Impede o Trabalho = 'Sim' E Ocorrência Anterior = 'Sim').
                * Média: (O problema afeta 'Meu setor' AND (Impede o Trabalho = 'Não' OU Impede o Trabalho = 'Parcialmente')). OU (Afeta 'Somente eu' AND Impede o Trabalho = 'Sim' AND Ocorrência Anterior = 'Não').
                * Baixa: (O problema afeta 'Somente eu' AND (Impede o Trabalho = 'Não' OU Impede o Trabalho = 'Parcialmente')). OU (Descrição indica pedido de informação/melhoria e não um erro funcional).
                

                --- BASE DE CONHECIMENTO (TOP 5 Soluções Recentes para '{categoria}') ---
                {baseConhecimento}
                --- FIM DA BASE DE CONHECIMENTO ---

                Com base nessas informações, forneça:
                1. Identificação do Problema: (Descreva o problema principal em poucas palavras)
                2. Proposta de Solução: (Sugira uma solução inicial ou próximos passos. SE HOUVER SIMILARIDADE, baseie-se fortemente nas soluções da Base de Conhecimento.)
                3. Prioridade Definida: [Baixa, Média ou Alta]             

                Responda APENAS com o texto solicitado para cada item, um em cada linha, começando EXATAMENTE com '1. Identificação do Problema:',
                '2. Proposta de Solução:' e '3. Prioridade Definida:'.";

            try
            {
                
                var requestBody = new
                {
                    contents = new[]
                    {
                        new { parts = new[] { new { text = prompt } } }
                    },
                 
                    generationConfig = new
                    {
                        temperature = 0.2,
                        maxOutputTokens = 2048,
                        topP = 0.95,
                        topK = 40
                    }
                };

               
                string jsonBody = JsonSerializer.Serialize(requestBody);
                var content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

                // Monta a URL final com a chave
                string urlWithKey = $"{_apiUrl}?key={_apiKey}";

                // Faz a requisição POST
                // Usando SendAsync para poder definir o método explicitamente 
                using (var requestMessage = new HttpRequestMessage(HttpMethod.Post, urlWithKey))
                {
                    requestMessage.Content = content;
                    HttpResponseMessage response = await _httpClient.SendAsync(requestMessage);

                    // Lê o corpo da resposta
                    string responseBody = await response.Content.ReadAsStringAsync();

                    // Verifica se a requisição foi bem-sucedida (status code 2xx)
                    if (!response.IsSuccessStatusCode)
                    {
                        // Tenta extrair uma mensagem de erro do corpo da resposta
                        string errorDetails = responseBody;
                        try
                        {
                            using (JsonDocument errorDoc = JsonDocument.Parse(responseBody))
                            {
                                if (errorDoc.RootElement.TryGetProperty("error", out JsonElement errorElement) &&
                                    errorElement.TryGetProperty("message", out JsonElement messageElement))
                                {
                                    errorDetails = messageElement.GetString();
                                }
                            }
                        }
                        catch { /* Ignora erro ao parsear o erro */ }
                        Console.WriteLine($"Erro HTTP: {response.StatusCode} - {errorDetails}");
                        
                        return ("Erro na API", "Não identificado", $"Erro {response.StatusCode}: {errorDetails}"); 
                    }

                    // Analisa a resposta JSON para extrair o texto gerado
                    string textoGerado = "Não foi possível extrair a resposta.";
                    try
                    {
                        using (JsonDocument doc = JsonDocument.Parse(responseBody))
                        {
                            JsonElement root = doc.RootElement;

                            // 1. Verifica se a resposta foi BLOQUEADA
                            if (root.TryGetProperty("promptFeedback", out var feedbackElement) &&
                                feedbackElement.TryGetProperty("blockReason", out var reasonElement))
                            {
                                string blockReason = reasonElement.GetString();
                                return ("Conteúdo Bloqueado", "Não identificado", $"A API bloqueou o prompt. Motivo: {blockReason}");
                            }

                            // 2. Verifica se tem 'candidates'
                            if (root.TryGetProperty("candidates", out var candidatesElement) && candidatesElement.GetArrayLength() > 0)
                            {
                                var firstCandidate = candidatesElement[0];


                                if (firstCandidate.TryGetProperty("finishReason", out var finishReasonElement) && finishReasonElement.GetString() == "MAX_TOKENS")
                                {
                                    return ("Resposta Incompleta", "Não identificado", "A IA foi cortada. Aumente o 'maxOutputTokens' na AIService.");
                                }

                                // 4. Se tudo deu certo, tenta pegar o texto
                                if (firstCandidate.TryGetProperty("content", out var contentElement) &&
                                    contentElement.TryGetProperty("parts", out var partsElement) && partsElement.GetArrayLength() > 0 &&
                                    partsElement[0].TryGetProperty("text", out var textElement))
                                {
                                    textoGerado = textElement.GetString();
                                }
                            }
                        }
                    }
                    catch (Exception jsonEx)
                    {
                        Console.WriteLine($"Erro ao analisar JSON da resposta: {jsonEx.Message}");
                        return ("Erro no JSON", "Não identificado", $"Resposta recebida, mas não pôde ser lida: {responseBody}"); 
                    }

                    if (textoGerado == "Não foi possível extrair a resposta.")
                    {
                        return ("Resposta Inesperada", "Não identificado", $"A API retornou um JSON válido, mas sem 'candidates' ou 'promptFeedback'. Resposta: {responseBody}");
                    }


                    string problemaSugerido = ExtrairValor(textoGerado, @"Identificação do Problema:?\s*(.*?)(?=Proposta de Solução:|Prioridade Definida:|$)");
                    string solucaoSugerida = ExtrairValor(textoGerado, @"Proposta de Solução:?\s*(.*?)(?=Identificação do Problema:|Prioridade Definida:|$)");
                    string prioridadeSugerida = ExtrairValor(textoGerado, @"Prioridade Definida:?\s*(.*)");

                    return (problemaSugerido, prioridadeSugerida, solucaoSugerida);
                } 
            }
            catch (HttpRequestException httpEx)
            {
                Console.WriteLine($"Erro de Rede ao chamar a API Gemini: {httpEx.Message}");
                return ("Erro de Rede", "Não identificado", $"Não foi possível conectar à API: {httpEx.Message}"); 
            }
            catch (Exception ex) 
            {
                Console.WriteLine($"Erro inesperado na AIService: {ex.Message}");
                return ("Erro Inesperado", "Não identificado", ex.Message); 
            }
        }

 
        private string ExtrairValor(string texto, string padraoRegex)
        {
            Match match = Regex.Match(texto, padraoRegex, RegexOptions.IgnoreCase | RegexOptions.Multiline | RegexOptions.Singleline);

            if (match.Success && match.Groups.Count > 1)
            {
                // Pega o valor e remove lixo, como asteriscos de markdown
                string valor = match.Groups[1].Value.Trim();
                valor = valor.Trim('*'); // Remove asteriscos (ex: **Alta**)

                // Se o valor estiver vazio (ex: IA respondeu "Problema: \n Solução: ...")
                if (string.IsNullOrWhiteSpace(valor))
                {
                    return "Não identificado";
                }

                return valor;
            }
            return "Não identificado";
        }
        private string FormatarSolucoes(List<string> solucoes)
        {
            if (solucoes == null || solucoes.Count == 0)
            {
                return "Nenhuma solução anterior encontrada para esta categoria.";
            }

            // Formata a lista como "1. Solução A", "2. Solução B", etc.
            var sb = new StringBuilder();
            int i = 1;
            foreach (var solucao in solucoes)
            {
                sb.AppendLine($"{i}. {solucao.Trim()}");
                i++;
            }
            return sb.ToString();
        }
    }
}
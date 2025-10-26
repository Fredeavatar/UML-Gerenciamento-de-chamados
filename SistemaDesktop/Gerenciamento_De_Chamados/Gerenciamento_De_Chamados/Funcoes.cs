using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Gerenciamento_De_Chamados
{
    public class Funcoes
    {
        // 🔒 Criptografia SHA256
        public static string Criptografar(string texto)
        {
            using (SHA256 hash = SHA256.Create())
            {
                byte[] bytes = hash.ComputeHash(Encoding.UTF8.GetBytes(texto));
                StringBuilder retorno = new StringBuilder();

                foreach (byte b in bytes)
                    retorno.Append(b.ToString("x2"));

                return retorno.ToString();
            }
        }

        // 📂 Selecionar arquivo e converter em byte[]
        public byte[] SelecionarArquivoEConverter()
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Imagens|*.jpg;*.jpeg;*.png;*.bmp";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    using (Image imagem = Image.FromFile(ofd.FileName))
                    {
                        return ImageToByteArray(imagem);
                    }
                }
            }
            return null;
        }

        public byte[] ImageToByteArray(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, img.RawFormat);
                return ms.ToArray();
            }
        }

        public Image ByteArrayToImage(byte[] bytes)
        {
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                return Image.FromStream(ms);
            }
        }

        // 🧑‍💻 Sessão do usuário logado
        public static class SessaoUsuario
        {
            public static int IdUsuario { get; set; }
            public static string Login { get; set; }
            public static string Nome { get; set; }
            public static string Email { get; set; }
            public static string FuncaoUsuario { get; set; }

            public static bool UsuarioIdentificado()
            {
                return !string.IsNullOrEmpty(Nome) && IdUsuario > 0 && !string.IsNullOrEmpty(FuncaoUsuario);
            }
        }

        public static string ObterFuncaoDoUsuario(string login, SqlConnection conexao)
        {
            string sql = "SELECT FuncaoUsuario FROM Usuario WHERE Login = @login";

            using (SqlCommand cmd = new SqlCommand(sql, conexao))
            {
                cmd.Parameters.AddWithValue("@login", login);
                object result = cmd.ExecuteScalar();

                return (result != null && result != DBNull.Value) ? result.ToString() : string.Empty;
            }
        }
        // 🔎 Buscar nome do usuário
        public static string ObterNomeDoUsuario(string login, SqlConnection conexao)
        {
            string sql = "SELECT Nome FROM Usuario WHERE Login = @login";

            using (SqlCommand cmd = new SqlCommand(sql, conexao))
            {
                cmd.Parameters.AddWithValue("@login", login);
                object result = cmd.ExecuteScalar();

                return (result != null && result != DBNull.Value) ? result.ToString() : string.Empty;
            }
        }

        public static string ObterEmailDoUsuario(string login, SqlConnection conexao)
        {
            string sql = "SELECT Email FROM Usuario WHERE Login = @login";

            using (SqlCommand cmd = new SqlCommand(sql, conexao))
            {
                cmd.Parameters.AddWithValue("@login", login);
                // Executa a consulta SQL e retorna o primeiro valor da primeira linha do resultado (usado para buscar um único campo)
                object result = cmd.ExecuteScalar();

                return (result != null && result != DBNull.Value) ? result.ToString() : string.Empty;
            }
        }

        // 🔎 Buscar ID do usuário
        public static int ObterIdDoUsuario(string login, SqlConnection conexao)
        {
            string sql = "SELECT IdUsuario FROM Usuario WHERE Login = @login";

            using (SqlCommand cmd = new SqlCommand(sql, conexao))
            {
                cmd.Parameters.AddWithValue("@login", login);
                object result = cmd.ExecuteScalar();

                return (result != null && result != DBNull.Value) ? Convert.ToInt32(result) : 0;
            }
        }

        //  Exibir usuário logado em qualquer tela
        public static void ExibirUsuarioEmLabel(Label labelDestino)
        {
            labelDestino.Text = !string.IsNullOrEmpty(SessaoUsuario.Nome)
                ? SessaoUsuario.Nome
                : "Usuário não identificado";
        }

        //  Botão para voltar à Home admin
        public static void BotaoHomeAdmin(Form formAtual)
        {
            var homeAdmin = new HomeAdmin();
            homeAdmin.Show();
            formAtual.Hide();
        }

        // Botão para voltar à Home do Funcionario
        public static void BotaoHomeFuncionario(Form formAtual)
        {
            var homeFuncionario = new HomeFuncionario();
            homeFuncionario.Show();
            formAtual.Hide();
        }

        //  Botão para voltar à Home do Tecnico
        public static void BotaoHomeTecnico(Form formAtual)
        {
            var homeTecnico = new HomeTecnico();
            homeTecnico.Show();
            formAtual.Hide();
        }
        public static string bolinhadeprioridade(string prioridade)
        {
            string indicadorPrioridadeHtml = "";
            string estiloBase = "display: inline-block; width: 12px; height: 12px; border-radius: 50%; margin-right: 6px; vertical-align: middle;";
            string prioridadeNormalizada = (prioridade ?? "").Trim().ToLower();

            switch (prioridadeNormalizada)
            {
                case "alta":
                    indicadorPrioridadeHtml = $"<span style='{estiloBase} background-color: red;'></span>";
                    break;
                case "media":
                case "média":

                    indicadorPrioridadeHtml = $"<span style='{estiloBase} background-color: #FFA500;'></span>";
                    break;
                case "baixa":
                case "baixo":
                    indicadorPrioridadeHtml = $"<span style='{estiloBase} background-color: green;'></span>";
                    break;
                default:
                    indicadorPrioridadeHtml = $"<span style='{estiloBase} background-color: gray;'></span>";
                    break;
            }
            return indicadorPrioridadeHtml;

        }

        //  Enviar e-mail ao abrir chamado
        public static void EnviarEmailChamado(
            string titulo, string descricao, string categoria, int idChamado,
            string prioridadeIA, string status, string pessoasAfetadas,
            string impedeTrabalho, string ocorreuAnteriormente,string problemaIA, string solucaoIA,
            byte[] anexo, string nomeAnexo
        )
        {



            try
            {
                string usuario = SessaoUsuario.Nome ?? "Usuário não identificado";
                string emailUsuario = SessaoUsuario.Email ?? "sememail@dominio.com";
                string emailTecnico = "fatalsystem.unip@gmail.com";
                string indicadorPrioridadeHtml = bolinhadeprioridade(prioridadeIA);


                string corpoEmailTI = $@"
                    <h2>Novo Chamado #{idChamado} Recebido - Análise Necessária</h2>
                    <p>Um novo chamado foi registrado e precisa de análise.</p>
                    <p><b>Registrado por:</b> {usuario} ({emailUsuario})</p>
                    <p><b>Número:</b> {idChamado}</p>
                    <p><b>Data:</b> {DateTime.Now:dd/MM/yyyy HH:mm:ss}</p>
                    <hr>
                    <p><b>Título:</b> {titulo}</p>
                    <p><b>Descrição do Usuário:</b> {descricao}</p>
                    <p><b>Categoria:</b> {categoria}</p>
                    <p><b>Status Inicial:</b> {status}</p>
                    <hr>
                    <p><b>Pessoas Afetadas:</b> {pessoasAfetadas}</p>
                    <p><b>Impede o Trabalho:</b> {impedeTrabalho}</p>
                    <p><b>Ocorreu Anteriormente:</b> {ocorreuAnteriormente}</p>
                    <hr>
                    <h3>Sugestões da Análise Preliminar (IA):</h3>
                    <p><b>Identificação do Problema:</b> {problemaIA}</p>
                    <p><b>Proposta de Solução:</b> {solucaoIA}</p>
                    <p><b>Prioridade Sugerida:</b> {prioridadeIA} {indicadorPrioridadeHtml}</p>
                    <hr>";

                using (MailMessage mailTI = new MailMessage())
                {
                    mailTI.From = new MailAddress("fatalsystem.unip@gmail.com", "Sistema de Chamados Fatal System");
                    mailTI.To.Add(emailTecnico); // Envia para a equipe de TI
                    mailTI.Subject = $"[Chamado #{idChamado} - {prioridadeIA}] Novo Chamado: {titulo}";
                    mailTI.Body = corpoEmailTI;
                    mailTI.IsBodyHtml = true;

                    Attachment attachmentTI = null;
                    MemoryStream msTI = null;
                    if (anexo != null && anexo.Length > 0)
                    {
                        msTI = new MemoryStream(anexo);
                        attachmentTI = new Attachment(msTI, nomeAnexo);
                        mailTI.Attachments.Add(attachmentTI);
                    }

                    using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                    {
                        smtp.Credentials = new NetworkCredential("fatalsystem.unip@gmail.com", "wwtr xdst wpwm lavr"); // Cuidado com a senha aqui
                        smtp.EnableSsl = true;
                        smtp.Send(mailTI);
                    }

                    // Limpa os recursos do anexo, se existirem
                    attachmentTI?.Dispose();
                    msTI?.Dispose();
                }

                if (!string.IsNullOrEmpty(emailUsuario))
                {
                    string corpoEmailUsuario = $@"
                        <h2>Olá, {usuario}!</h2>
                        <p>Seu chamado foi registrado com sucesso em nosso sistema.</p>
                        <p><b>Número do Chamado:</b> {idChamado}</p>
                        <p><b>Data:</b> {DateTime.Now:dd/MM/yyyy HH:mm:ss}</p>
                        <hr>
                        <p><b>Título:</b> {titulo}</p>
                        <p><b>Descrição Fornecida:</b> {descricao}</p>
                        <p><b>Categoria:</b> {categoria}</p>
                        <p><b>Prioridade Definida: Em análise </b></p>
                        <p><b>Status Atual:</b> {status}</p>
                        <hr>
                        <p>Nossa equipe de TI já foi notificada e analisará sua solicitação em breve.</p>
                        <p>Atenciosamente,<br>Equipe Fatal System</p>";

                    using (MailMessage mailUsuario = new MailMessage())
                    {
                        mailUsuario.From = new MailAddress("fatalsystem.unip@gmail.com", "Sistema de Chamados Fatal System");
                        mailUsuario.To.Add(emailUsuario); // Envia para o usuário que abriu
                        mailUsuario.Subject = $"Confirmação: Chamado #{idChamado} Registrado - {titulo}";
                        mailUsuario.Body = corpoEmailUsuario;
                        mailUsuario.IsBodyHtml = true;


                        Attachment attachmentUser = null;
                        MemoryStream msUser = null;
                        if (anexo != null && anexo.Length > 0)
                        {
                            msUser = new MemoryStream(anexo); 
                            attachmentUser = new Attachment(msUser, nomeAnexo);
                            mailUsuario.Attachments.Add(attachmentUser);
                        }
                        

                        using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                        {
                            smtp.Credentials = new NetworkCredential("fatalsystem.unip@gmail.com", "wwtr xdst wpwm lavr");
                            smtp.EnableSsl = true;
                            smtp.Send(mailUsuario);
                        }


                    }
                }
            }
            catch (Exception ex)
            {

                string mensagemErro = "Erro ao enviar e-mail(s): " + ex.Message;
                if (ex.InnerException != null)
                {
                    mensagemErro += "\n\nDetalhes: " + ex.InnerException.Message;
                }
                MessageBox.Show(mensagemErro, "Falha no Envio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
     
        private static string connectionString = "Server=fatalsystemsrv1.database.windows.net;Database=DbaFatal-System;User Id=fatalsystem;Password=F1234567890m@;";

        public static async Task<List<string>> BuscarSolucoesAnteriores(string categoria)
        {
            var solucoes = new List<string>();

            // Esta query junta Chamado e Histórico
            string sql = @"
            SELECT TOP 5 H.Solucao
            FROM Historico H
            INNER JOIN Chamado C ON H.FK_IdChamado = C.IdChamado
            WHERE C.StatusChamado = 'Resolvido'
              AND H.Acao = 'Solução Aplicada'
              AND C.Categoria = @Categoria
            ORDER BY H.DataSolucao DESC"; // Pega as mais recentes

            using (SqlConnection conexao = new SqlConnection(connectionString))
            {
                try
                {
                    await conexao.OpenAsync();
                    using (SqlCommand cmd = new SqlCommand(sql, conexao))
                    {
                        cmd.Parameters.AddWithValue("@Categoria", categoria);
                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                solucoes.Add(reader["Solucao"].ToString());
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Se der erro, apenas retorna a lista vazia
                    Console.WriteLine($"Erro ao buscar histórico: {ex.Message}");
                }
            }
            return solucoes;
        }
    }
}

    
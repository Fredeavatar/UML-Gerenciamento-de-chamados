using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Gerenciamento_De_Chamados
{
    public partial class ContinuaçaoAbertura : Form
    {
        private AberturaChamados aberturaChamados;

        // Recebe a tela de abertura de chamados já preenchida
        public ContinuaçaoAbertura(AberturaChamados abertura)
        {
            InitializeComponent();
            aberturaChamados = abertura;
            this.Load += ContinuaçaoAbertura_Load;
        }


        private async void btnConcluirCH_Click(object sender, EventArgs e)
        {
            string TituloChamado = aberturaChamados.txtTituloChamado.Text.Trim();
            string DescricaoChamado = aberturaChamados.txtDescriçãoCh.Text.Trim();
            string PessoasAfetadas = cBoxPessoasAfeta.Text.Trim();
            string ImpedeTrabalho = cBoxImpedTrab.Text;
            string OcorreuAnteriormente = cBoxAcontAntes.Text;
            string CategoriaChamado = aberturaChamados.cboxCtgChamado.Text;
            byte[] AnexarArquivo = aberturaChamados.arquivoAnexado;

            string status = "Pendente";
                        
            string problemaIA = "Pendente";
            string solucaoIA = "Pendente";
            string prioridadeIA = "Analise";
            try
            {
                List<string> solucoesAnteriores = await Funcoes.BuscarSolucoesAnteriores(CategoriaChamado);
                AIService aiService = new AIService(); 
                var (problema,prioridade, solucao) = await aiService.AnalisarChamado(TituloChamado,PessoasAfetadas,
                    OcorreuAnteriormente, ImpedeTrabalho, DescricaoChamado, CategoriaChamado, solucoesAnteriores);
                problemaIA = problema;
                solucaoIA = solucao;
                prioridadeIA = prioridade;
            }



            catch (Exception aiEx)
            {
                MessageBox.Show($"Erro ao analisar chamado com IA: {aiEx.Message}. O chamado será criado sem sugestão.", "Aviso IA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }

            string connectionString = "Server=fatalsystemsrv1.database.windows.net;Database=DbaFatal-System;User Id=fatalsystem;Password=F1234567890m@;";

            int idUsuario = Funcoes.SessaoUsuario.IdUsuario;
            string sql = @"INSERT INTO Chamado
                                    (Titulo, PrioridadeChamado, Descricao, DataChamado, StatusChamado, Categoria,
                                    FK_IdUsuario, PessoasAfetadas, ImpedeTrabalho, OcorreuAnteriormente,
                                    PrioridadeSugeridaIA, ProblemaSugeridoIA, SolucaoSugeridaIA)
                   OUTPUT INSERTED.IdChamado
                   VALUES (@Titulo, @PrioridadeChamado, @Descricao, @DataChamado,
                            @StatusChamado, @Categoria, @FK_IdUsuario, @PessoasAfetadas,
                            @ImpedeTrabalho, @OcorreuAnteriormente, @PrioridadeSugeridaIA, @ProblemaSugeridoIA, @SolucaoSugeridaIA)";

            using (SqlConnection conexao = new SqlConnection(connectionString))
            {
                try
                {
                    conexao.Open();

                    int idChamado;
                    string prioridade = "Análise";
                    

                    using (SqlCommand cmd = new SqlCommand(sql, conexao))
                    {
                        TimeZoneInfo brasilTimeZone = TimeZoneInfo.FindSystemTimeZoneById("E. South America Standard Time");
                        DateTime horaDeBrasilia = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, brasilTimeZone);


                        cmd.Parameters.AddWithValue("@Titulo", TituloChamado);
                        cmd.Parameters.AddWithValue("@PrioridadeChamado", prioridade);
                        cmd.Parameters.AddWithValue("@Descricao", DescricaoChamado);
                        cmd.Parameters.AddWithValue("@DataChamado", horaDeBrasilia);
                        cmd.Parameters.AddWithValue("@StatusChamado", status);
                        cmd.Parameters.AddWithValue("@Categoria", CategoriaChamado);
                        cmd.Parameters.AddWithValue("@FK_IdUsuario", idUsuario);
                        cmd.Parameters.AddWithValue("@PessoasAfetadas", PessoasAfetadas);
                        cmd.Parameters.AddWithValue("@ImpedeTrabalho", ImpedeTrabalho);
                        cmd.Parameters.AddWithValue("@OcorreuAnteriormente", OcorreuAnteriormente);

                        cmd.Parameters.AddWithValue("@PrioridadeSugeridaIA", prioridadeIA);
                        cmd.Parameters.AddWithValue("@ProblemaSugeridoIA", problemaIA);
                        cmd.Parameters.AddWithValue("@SolucaoSugeridaIA", solucaoIA);
                        idChamado = (int)cmd.ExecuteScalar();
                    }

                    if (AnexarArquivo != null && AnexarArquivo.Length > 0)
                    {
                        string sqlArquivo = @"INSERT INTO Arquivo 
                                              (TipoArquivo, NomeArquivo, Arquivo, FK_IdChamado)
                                              VALUES (@TipoArquivo, @NomeArquivo, @Arquivo, @FK_IdChamado)";
                        using (SqlCommand cmdArq = new SqlCommand(sqlArquivo, conexao))
                        {
                            cmdArq.Parameters.AddWithValue("@TipoArquivo", "imagem/png");
                            cmdArq.Parameters.AddWithValue("@NomeArquivo", "anexo.png");
                            cmdArq.Parameters.AddWithValue("@Arquivo", AnexarArquivo);
                            cmdArq.Parameters.AddWithValue("@FK_IdChamado", idChamado);
                            cmdArq.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Chamado aberto com sucesso! Número do chamado: " + idChamado);
                    // Envia o e-mail com os dados do chamado
                    Funcoes.EnviarEmailChamado(
                                                 TituloChamado,
                                                 DescricaoChamado,
                                                 CategoriaChamado,
                                                 idChamado,
                                                 prioridadeIA, 
                                                 status,     
                                                 PessoasAfetadas,
                                                 ImpedeTrabalho,
                                                 OcorreuAnteriormente,
                                                 problemaIA,
                                                 solucaoIA,
                                                 AnexarArquivo, 
                                                 "anexo_chamado.png" 
);

                    var telaFim = new FimChamado(idChamado);
                    telaFim.ShowDialog();

                    aberturaChamados.Close();
                    this.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao abrir chamado: " + ex.Message);
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Color corInicioPanel = Color.White;
            Color corFimPanel = ColorTranslator.FromHtml("#232325");
            LinearGradientBrush gradientePanel = new LinearGradientBrush(
                     panel1.ClientRectangle,
                    corInicioPanel,
                    corFimPanel,
                    LinearGradientMode.Vertical); // Exemplo com gradiente horizontal
            g.FillRectangle(gradientePanel, panel1.ClientRectangle);
        }
        private void ContinuaçaoAbertura_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Funcoes.SessaoUsuario.Nome))
                lbl_NomeUser.Text = ($"Bem vindo {Funcoes.SessaoUsuario.Nome}");
        }
    }
}

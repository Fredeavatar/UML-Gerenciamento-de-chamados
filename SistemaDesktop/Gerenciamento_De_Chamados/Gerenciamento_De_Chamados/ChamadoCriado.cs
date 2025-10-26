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
    public partial class ChamadoCriado : Form
    {
        private int chamadoId;
        string connectionString = "Server=fatalsystemsrv1.database.windows.net;Database=DbaFatal-System;User Id=fatalsystem;Password=F1234567890m@;";
        public ChamadoCriado(int idDoChamado)
        {
            InitializeComponent();
            this.Load += ChamadoCriado_Load;
            this.chamadoId = idDoChamado;
        }

        private void gbxChamadoCriado_Paint(object sender, PaintEventArgs e)
        {
            // Pega a cor que você quer (hexadecimal)
            Color corFundo = ColorTranslator.FromHtml("#E3FFE5");

            // Preenche o fundo inteiro do GroupBox
            using (SolidBrush brush = new SolidBrush(corFundo))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }

            // Desenha o texto do título do GroupBox normalmente
            GroupBox box = sender as GroupBox;
            if (box != null)
            {
                TextRenderer.DrawText(
                    e.Graphics,
                    box.Text,
                    box.Font,
                    new Point(10, 1),  // posição do texto
                    box.ForeColor
                );
            }
        }
        private void ChamadoCriado_Load(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrEmpty(Funcoes.SessaoUsuario.Nome))
                lbl_NomeUser.Text = $"Bem vindo {Funcoes.SessaoUsuario.Nome}";
            else
                lbl_NomeUser.Text = "Usuário não identificado";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    
                    string sql = @"SELECT Titulo, Descricao, Categoria, DataChamado, 
                                  PessoasAfetadas, ImpedeTrabalho, OcorreuAnteriormente
                           FROM Chamado 
                           WHERE IdChamado = @IdChamado";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdChamado", this.chamadoId);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                
                                DateTime dataCriacao = Convert.ToDateTime(reader["DataChamado"]);
                                string titulo = reader["Titulo"].ToString();
                                string descricao = reader["Descricao"].ToString();
                                string categoria = reader["Categoria"].ToString();
                                string pessoasAfetadas = reader["PessoasAfetadas"].ToString();
                                string impedeTrabalho = reader["ImpedeTrabalho"].ToString();
                                string ocorreuAntes = reader["OcorreuAnteriormente"].ToString();

                               
                                StringBuilder resumo = new StringBuilder();

                                TimeZoneInfo brasilTimeZone = TimeZoneInfo.FindSystemTimeZoneById("E. South America Standard Time");
                                DateTime horaDeBrasiliaAtual = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, brasilTimeZone);


                                TimeSpan tempoPassado = horaDeBrasiliaAtual - dataCriacao;
                                string quandoFoiCriado;
                                if (tempoPassado.TotalMinutes < 2)
                                {
                                    quandoFoiCriado = "poucos segundos atrás";
                                }
                                else if (tempoPassado.TotalHours < 1)
                                {
                                    quandoFoiCriado = $"{Math.Round(tempoPassado.TotalMinutes)} minutos atrás";
                                }
                                else if (tempoPassado.TotalDays < 1)
                                {
                                    quandoFoiCriado = $"{Math.Round(tempoPassado.TotalHours)} horas atrás";
                                }
                                else
                                {
                                    quandoFoiCriado = $"{tempoPassado.Days} dias atrás";
                                }
                                resumo.AppendLine($"Criado em: {quandoFoiCriado}   por   {Funcoes.SessaoUsuario.Nome.ToUpper()}");
                                resumo.AppendLine(); 

                                // Categoria > Título
                                resumo.AppendLine($"{categoria} > {titulo}");
                                resumo.AppendLine("==================================================");
                                resumo.AppendLine();

                                // Corpo do Formulário
                                resumo.AppendLine("DADOS DO FORMULÁRIO");
                                resumo.AppendLine("Informações do chamado");
                                resumo.AppendLine("--------------------------------------------------");

                                
                                resumo.AppendLine($"1. Problema está impedindo o trabalho?  {impedeTrabalho}");
                                resumo.AppendLine($"2. Quais as pessoas afetadas?  {pessoasAfetadas}");
                                resumo.AppendLine($"3. Ocorreu anteriormente?  {ocorreuAntes}");

                                resumo.AppendLine();
                                resumo.AppendLine($"4. Descrição da sua solicitação:");
                                resumo.AppendLine(descricao);
                                resumo.AppendLine();

                                txtResumoChamado.Text = resumo.ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar detalhes do chamado: " + ex.Message);
            }
        }
        

        private void gbxTitulo_Paint(object sender, PaintEventArgs e)
        {
            // Pega a cor que você quer (hexadecimal)
            Color corFundo = ColorTranslator.FromHtml("#E3FFE5");

            // Preenche o fundo inteiro do GroupBox
            using (SolidBrush brush = new SolidBrush(corFundo))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }

            // Desenha o texto do título do GroupBox normalmente
            GroupBox box = sender as GroupBox;
            if (box != null)
            {
                TextRenderer.DrawText(
                    e.Graphics,
                    box.Text,
                    box.Font,
                    new Point(10, 1),  // posição do texto
                    box.ForeColor
                );
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
    }
}

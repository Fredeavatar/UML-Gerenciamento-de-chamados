using ScottPlot;
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
    public partial class Relatorio : Form
    {
        public Relatorio()
        {
            InitializeComponent();
            this.Load += Relatorio_Load;
        }

        private void Relatorio_Load(object sender, EventArgs e)
        {



            // --------------------------------- Grafico de Pizza Visão Geral de Chamados ---------------------------------
            List<double> valoresDB = new List<double>();
            List<string> labelsDB = new List<string>();
            string connectionString = "Server=fatalsystemsrv1.database.windows.net;Database=DbaFatal-System;User Id=fatalsystem;Password=F1234567890m@;";
            string query = @"
        SELECT StatusChamado, COUNT(IdChamado) 
        FROM Chamado 
        WHERE StatusChamado IN ('Pendente', 'Em Andamento', 'Resolvido') 
        GROUP BY StatusChamado";


            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                labelsDB.Add(reader.GetString(0));
                                valoresDB.Add(reader.GetInt32(1));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de dados: \n" + ex.Message);
                return;
            }

            int indiceResolvidos = labelsDB.FindIndex(s => s.Equals("Resolvido", StringComparison.OrdinalIgnoreCase));

            if (indiceResolvidos != -1)
            {
                // Se encontrou "Pendente", pega o valor (contagem) correspondente
                double totalAbertos = valoresDB[indiceResolvidos];
                lblTotalResolvidos.Text = totalAbertos.ToString();
            }
            else
            {
                // Se não encontrou (ex: 0 chamados pendentes), define o texto como "0"
                lblTotalResolvidos.Text = "0";
            }

            int indicePendente = labelsDB.FindIndex(s => s.Equals("Pendente", StringComparison.OrdinalIgnoreCase));

            if (indicePendente != -1)
            {
                // Se encontrou "Pendente", pega o valor (contagem) correspondente
                double totalAbertos = valoresDB[indicePendente];
                lblTotalPendentes.Text = totalAbertos.ToString();
            }
            else
            {
                // Se não encontrou (ex: 0 chamados pendentes), define o texto como "0"
                lblTotalPendentes.Text = "0";
            }


            if (valoresDB.Count == 0)
            {
                formPlotVisaoGeral.Plot.Title("Sem dados para exibir");
                formPlotVisaoGeral.Plot.Axes.Frameless();
                formPlotVisaoGeral.Plot.HideGrid();
                formPlotVisaoGeral.Refresh();

                lblPendente.Text = "Pendente (0.0%)";
                pnPendente.BackColor = System.Drawing.Color.FromArgb(239, 83, 80);
                lblEmAndamento.Text = "Em Andamento (0.0%)";
                pnEmAndamento.BackColor = System.Drawing.Color.FromArgb(126, 87, 194);
                lblResolvido.Text = "Resolvido (0.0%)";
                pnResolvido.BackColor = System.Drawing.Color.FromArgb(102, 187, 106);
                return;
            }

            var piePlot = formPlotVisaoGeral.Plot.Add.Pie(valoresDB.ToArray());
            piePlot.DonutFraction = 0.6;



            lblPendente.Text = "Pendente (0.0%)";
            pnPendente.BackColor = System.Drawing.Color.FromArgb(239, 83, 80);
            lblEmAndamento.Text = "Em Andamento (0.0%)";
            pnEmAndamento.BackColor = System.Drawing.Color.FromArgb(33, 150, 243);
            lblResolvido.Text = "Resolvido (0.0%)";
            pnResolvido.BackColor = System.Drawing.Color.FromArgb(102, 187, 106);


            piePlot.LineWidth = 0;
            double total = valoresDB.Sum(); // Soma total dos valores

            lblTotalChamados.Text = total.ToString();

            for (int i = 0; i < labelsDB.Count; i++)
            {
                string status = labelsDB[i];
                double porcentagem = (valoresDB[i] / total);


                piePlot.Slices[i].Label = "";


                if (status.Equals("Pendente", StringComparison.OrdinalIgnoreCase))
                {
                    var cor = new ScottPlot.Color(239, 83, 80);
                    piePlot.Slices[i].Fill.Color = cor;
                    pnPendente.BackColor = System.Drawing.Color.FromArgb(cor.R, cor.G, cor.B);
                    lblPendente.Text = $"Pendente ({porcentagem:P1})";
                }
                else if (status.Equals("Em Andamento", StringComparison.OrdinalIgnoreCase))
                {
                    var cor = new ScottPlot.Color(126, 87, 194);
                    piePlot.Slices[i].Fill.Color = cor;
                    pnEmAndamento.BackColor = System.Drawing.Color.FromArgb(cor.R, cor.G, cor.B);
                    lblEmAndamento.Text = $"Em Andamento ({porcentagem:P1})";
                }
                else if (status.Equals("Resolvido", StringComparison.OrdinalIgnoreCase))
                {
                    var cor = new ScottPlot.Color(102, 187, 106);
                    piePlot.Slices[i].Fill.Color = cor;
                    pnResolvido.BackColor = System.Drawing.Color.FromArgb(cor.R, cor.G, cor.B);
                    lblResolvido.Text = $"Resolvido ({porcentagem:P1})";
                }
            }


            
            formPlotVisaoGeral.Plot.Axes.Frameless();
            formPlotVisaoGeral.Plot.HideGrid();
            formPlotVisaoGeral.Refresh();


            // ------------------------------- Grafico de Pizza Prioridade de Chamados -------------------------------


            List<double> valoresPrioridade = new List<double>();
            List<string> labelsPrioridade = new List<string>();

            string queryPrioridade = @"
    SELECT PrioridadeChamado, COUNT(IdChamado) 
    FROM Chamado 
    WHERE PrioridadeChamado IN ('Alta', 'Média', 'Baixa') 
    GROUP BY PrioridadeChamado";

            try
            {

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(queryPrioridade, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                labelsPrioridade.Add(reader.GetString(0));
                                valoresPrioridade.Add(reader.GetInt32(1));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados de Prioridade: \n" + ex.Message);
                return;
            }

            var corAlta = new ScottPlot.Color(239, 83, 80);
            var corMedia = new ScottPlot.Color(33, 150, 243);
            var corBaixa = new ScottPlot.Color(102, 187, 106);

            lblAlta.Text = "Alta (0.0%)";
            pnAlta.BackColor = System.Drawing.Color.FromArgb(corAlta.R, corAlta.G, corAlta.B);
            lblMedia.Text = "Média (0.0%)";
            pnMedia.BackColor = System.Drawing.Color.FromArgb(corMedia.R, corMedia.G, corMedia.B);
            lblBaixa.Text = "Baixa (0.0%)";
            pnBaixa.BackColor = System.Drawing.Color.FromArgb(corBaixa.R, corBaixa.G, corBaixa.B);



            if (valoresPrioridade.Count == 0)
            {
                // Se não houver dados, o gráfico é zerado 
                fpPrioridades.Plot.Title("Sem dados de prioridade");
                fpPrioridades.Plot.Axes.Frameless();
                fpPrioridades.Plot.HideGrid();
                fpPrioridades.Refresh();
            }
            else
            {
                // Se houver dados, preenchemos o gráfico
                var piePlotPrioridade = fpPrioridades.Plot.Add.Pie(valoresPrioridade.ToArray());
                piePlotPrioridade.DonutFraction = 0.6; // Estilo Donut
                piePlotPrioridade.LineWidth = 0;       // Sem contorno

                double totalPrioridade = valoresPrioridade.Sum();

                for (int i = 0; i < labelsPrioridade.Count; i++)
                {
                    string prioridade = labelsPrioridade[i];
                    double porcentagem = (valoresPrioridade[i] / totalPrioridade);


                    piePlotPrioridade.Slices[i].Label = "";

                    // Atualiza a legenda manual correta
                    if (prioridade.Equals("Alta", StringComparison.OrdinalIgnoreCase))
                    {
                        piePlotPrioridade.Slices[i].Fill.Color = corAlta;
                        lblAlta.Text = $"Alta ({porcentagem:P1})";
                    }
                    else if (prioridade.Equals("Média", StringComparison.OrdinalIgnoreCase))
                    {
                        piePlotPrioridade.Slices[i].Fill.Color = corMedia;
                        lblMedia.Text = $"Média ({porcentagem:P1})";
                    }
                    else if (prioridade.Equals("Baixa", StringComparison.OrdinalIgnoreCase))
                    {
                        piePlotPrioridade.Slices[i].Fill.Color = corBaixa;
                        lblBaixa.Text = $"Baixa ({porcentagem:P1})";
                    }
                }


               
                fpPrioridades.Plot.Axes.Frameless();
                fpPrioridades.Plot.HideGrid();
                fpPrioridades.Plot.Benchmark.IsVisible = false;
                fpPrioridades.Refresh();
            }
        }

        private void panelPrincipal_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            System.Drawing.Color corInicio = System.Drawing.Color.White;
            System.Drawing.Color corFim = ColorTranslator.FromHtml("#232325");

            using (LinearGradientBrush gradiente = new LinearGradientBrush(
                this.ClientRectangle, corInicio, corFim, LinearGradientMode.Horizontal))
            {
                g.FillRectangle(gradiente, this.ClientRectangle);
            }
        }






        private void panelSidebar_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            System.Drawing.Color corInicioPanel = System.Drawing.Color.White;
            System.Drawing.Color corFimPanel = ColorTranslator.FromHtml("#232325");

           
            LinearGradientBrush gradientePanel = new LinearGradientBrush(
                     panelSidebar.ClientRectangle,
                     corInicioPanel,
                     corFimPanel,
                     System.Drawing.Drawing2D.LinearGradientMode.Vertical); 


            g.FillRectangle(gradientePanel, panelSidebar.ClientRectangle);
        }

        private void btnGerarRelatorio_Click(object sender, EventArgs e)
        {
            // Pega as datas selecionadas pelo usuário (use 'dtpDe' e 'dtpAte' - DateTimePickers)
            DateTime dataInicio = dtpDe.Value;
            DateTime dataFim = dtpAte.Value;

            // Validação simples
            if (dataFim < dataInicio)
            {
                MessageBox.Show("A data 'Até' não pode ser anterior à data 'De'.");
                return;
            }
            FormRelatorioDetalhado frmDetalhe = new FormRelatorioDetalhado(dataInicio, dataFim);
            frmDetalhe.Show();
        }
    }
}

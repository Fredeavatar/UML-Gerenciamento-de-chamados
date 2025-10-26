using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using System.Text;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Gerenciamento_De_Chamados
{
    public partial class FormRelatorioDetalhado : Form
    {
        
        private DateTime _dataInicio;
        private DateTime _dataFim;
        private DataTable relatorioDataTable;

        public FormRelatorioDetalhado(DateTime dataInicio, DateTime dataFim)
        {
            InitializeComponent();

            // Guarda as datas recebidas
            _dataInicio = dataInicio;
            _dataFim = dataFim;
            this.Load += FormRelatorioDetalhado_Load;
        }

        private void FormRelatorioDetalhado_Load(object sender, EventArgs e)
        {
            CarregarRelatorio();
        }


        private void CarregarRelatorio()
        {
            string connectionString = "Server=fatalsystemsrv1.database.windows.net;Database=DbaFatal-System;User Id=fatalsystem;Password=F1234567890m@;";

            // ESTA É A SUA NOVA QUERY!
            // Ela junta Chamado, Usuario e Historico
            // Usamos LEFT JOIN no Historico, caso um chamado ainda não tenha solução
            string query = @"
                SELECT 
                    c.IdChamado,
                    c.DataChamado,
                    c.Titulo,
                    c.Categoria,
                    c.Descricao,
                    c.StatusChamado,
                    u.Nome AS Usuario,
                    h.Solucao
                FROM 
                    Chamado c
                JOIN 
                    Usuario u ON c.FK_IdUsuario = u.IdUsuario
                LEFT JOIN 
                    Historico h ON c.IdChamado = h.FK_IdChamado
                WHERE 
                    c.DataChamado BETWEEN @dataInicio AND @dataFim
                ORDER BY
                    c.DataChamado DESC;
            ";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Passa as datas para a query de forma segura
                        command.Parameters.AddWithValue("@dataInicio", _dataInicio.Date);
                        command.Parameters.AddWithValue("@dataFim", _dataFim.Date.AddDays(1).AddTicks(-1)); // Pega até o fim do dia

                        
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        relatorioDataTable = new DataTable();

                        connection.Open();
                        adapter.Fill(relatorioDataTable); // Preenche a tabela na memória

                        // Joga a tabela na tela
                        dgvRelatorio.DataSource = relatorioDataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gerar relatório detalhado: \n" + ex.Message);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            var relatorio = new Relatorio();
            relatorio.Show();
            this.Close();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (relatorioDataTable == null || relatorioDataTable.Rows.Count == 0)
            {
                MessageBox.Show("Não há dados para exportar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 2. Abre a janela "Salvar Como..."
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Arquivo CSV (*.csv)|*.csv";
            saveDialog.Title = "Salvar Relatório como CSV";
            saveDialog.FileName = $"Relatorio_Chamados_{DateTime.Now:yyyyMMdd}.csv"; // Sugere um nome de arquivo

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    using (StreamWriter sw = new StreamWriter(saveDialog.FileName, false, Encoding.UTF8))
                    {
                        // --- 4. Escreve os Cabeçalhos (Nomes das Colunas) ---
                        List<string> headers = new List<string>();
                        foreach (DataColumn column in relatorioDataTable.Columns)
                        {
                            headers.Add($"\"{column.ColumnName}\""); // Adiciona aspas para segurança
                        }
                        sw.WriteLine(string.Join(";", headers)); // Separa por PONTO E VÍRGULA (padrão Brasil)

                        // --- 5. Escreve as Linhas de Dados ---
                        foreach (DataRow row in relatorioDataTable.Rows)
                        {
                            List<string> fields = new List<string>();
                            foreach (object field in row.ItemArray)
                            {
                                // Coloca aspas em volta de cada campo e trata valores nulos
                                fields.Add($"\"{field?.ToString() ?? ""}\"");
                            }
                            sw.WriteLine(string.Join(";", fields));
                        }
                    }

                    MessageBox.Show("Relatório exportado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao salvar o arquivo: \n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnExportarPDF_Click(object sender, EventArgs e)
        {
            if (relatorioDataTable == null || relatorioDataTable.Rows.Count == 0)
            {
                MessageBox.Show("Não há dados para exportar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Arquivo PDF (*.pdf)|*.pdf";
            saveDialog.Title = "Salvar Relatório como PDF";
            saveDialog.FileName = $"Relatorio_Chamados_{DateTime.Now:yyyyMMdd}.pdf";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // PageSize.A4.Rotate() cria a página em modo "Paisagem" (horizontal),

                    Document doc = new Document(PageSize.A4.Rotate());

                    // Salva o documento no local escolhido
                    PdfWriter.GetInstance(doc, new FileStream(saveDialog.FileName, FileMode.Create));

                    // Abre o documento para edição
                    doc.Open();


                    // Define uma fonte para o título
                    Font titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18, BaseColor.BLACK);
                    Paragraph title = new Paragraph("Relatório Detalhado de Chamados", titleFont);
                    title.Alignment = Element.ALIGN_CENTER;
                    title.SpacingAfter = 20f; // Espaço depois do título
                    doc.Add(title);


                    PdfPTable pdfTable = new PdfPTable(relatorioDataTable.Columns.Count);
                    pdfTable.WidthPercentage = 100; 


                    Font headerFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10, BaseColor.WHITE);
                    Font cellFont = FontFactory.GetFont(FontFactory.HELVETICA, 9, BaseColor.BLACK);


                    foreach (DataColumn column in relatorioDataTable.Columns)
                    {
                        PdfPCell headerCell = new PdfPCell(new Phrase(column.ColumnName, headerFont));
                        headerCell.BackgroundColor = new BaseColor(68, 84, 136); // Um azul-escuro
                        headerCell.HorizontalAlignment = Element.ALIGN_CENTER;
                        headerCell.Padding = 5;
                        pdfTable.AddCell(headerCell);
                    }


                    foreach (DataRow row in relatorioDataTable.Rows)
                    {
                        foreach (object field in row.ItemArray)
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(field?.ToString() ?? "", cellFont));
                            cell.Padding = 5;
                            pdfTable.AddCell(cell);
                        }
                    }


                    doc.Add(pdfTable);


                    doc.Close();

                    MessageBox.Show("Relatório PDF exportado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    // Erro comum: o arquivo já está aberto em outro programa.
                    MessageBox.Show("Erro ao salvar o arquivo PDF. \nVerifique se o arquivo não está aberto.\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
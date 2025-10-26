using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerenciamento_De_Chamados
{
    public partial class Responder_Chamado : Form
    {
        string connectionString = "Server=fatalsystemsrv1.database.windows.net;Database=DbaFatal-System;User Id=fatalsystem;Password=F1234567890m@;";
        private DataTable chamadosTable = new DataTable();
        public Responder_Chamado()

        {
            InitializeComponent();
            ConfigurarGrade(); // PASSO 1: Configura as colunas


            // evento para carregar os dados ao abrir o form
            this.Load += Responder_Chamado_Load;
            
        }

        private void Responder_Chamado_Load(object sender, EventArgs e)

        {
            CarregarChamados();

        }
        private void ConfigurarGrade()
        {
            dgvResponder.RowTemplate.Height = 35;

            dgvResponder.ColumnHeadersHeight = 35;

            dgvResponder.AutoGenerateColumns = false;
            dgvResponder.Columns.Clear();

            dgvResponder.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "IdChamado",
                DataPropertyName = "IdChamado",
                HeaderText = "ID",
                Width = 60
            });
            dgvResponder.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Titulo",
                DataPropertyName = "Titulo",
                HeaderText = "Titulo",
                Width = 250
            });
            dgvResponder.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Descricao",
                DataPropertyName = "Descricao",
                HeaderText = "Descricao",
                Width = 450
            });
            dgvResponder.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Prioridade",
                DataPropertyName = "Prioridade",
                HeaderText = "Prioridade",
                Width = 100
            });
            dgvResponder.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "data",
                DataPropertyName = "data",
                HeaderText = "data",
                Width = 100
            });
            dgvResponder.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Status",
                DataPropertyName = "Status",
                HeaderText = "Status",
                Width = 120
            });

            dgvResponder.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "IdUsuario",
                DataPropertyName = "IdUsuario",
                HeaderText = "Usuario",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
        }

        private void CarregarChamados(string filtro = "")
        {
            string sql = @"
                            SELECT 
                                    u.IdUsuario,
                                    c.IdChamado, 
                                    u.Nome AS Usuario, 
                                    c.Titulo, 
                                    c.PrioridadeChamado AS Prioridade, 
                                    c.Descricao, 
                                    c.DataChamado AS Data, 
                                    c.StatusChamado AS Status, 
                                    c.Categoria 
                                    FROM Chamado c
                                    JOIN Usuario u ON c.FK_IdUsuario = u.IdUsuario
                                    WHERE (@filtro = '' OR c.Titulo LIKE '%' + @filtro + '%'
                                    OR c.PrioridadeChamado LIKE '%' + @filtro + '%'
                                    OR c.Descricao LIKE '%' + @filtro + '%'
                                    OR c.StatusChamado LIKE '%' + @filtro + '%'
                                    OR c.Categoria LIKE '%' + @filtro + '%'
                                    OR u.Nome LIKE '%' + @filtro + '%')
                                    ORDER BY c.DataChamado DESC";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
                {
                    da.SelectCommand.Parameters.AddWithValue("@filtro", filtro ?? string.Empty);

                    chamadosTable.Clear();
                    da.Fill(chamadosTable);

                    // Atualiza a fonte de dados
                    dgvResponder.DataSource = chamadosTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar chamados: " + ex.Message);
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

        private void Responder_Chamado_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Color corInicio = Color.White;
            Color corFim = ColorTranslator.FromHtml("#232325");

            using (LinearGradientBrush gradiente = new LinearGradientBrush(
                this.ClientRectangle, corInicio, corFim, LinearGradientMode.Horizontal))
            {
                g.FillRectangle(gradiente, this.ClientRectangle);
            }
        }

        private async void dgvResponder_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se o clique foi em uma linha válida (não no cabeçalho)
            if (e.RowIndex < 0)
            {
                return;
            }

            // 2. Adiciona um cursor de "carregando"
            this.Cursor = Cursors.WaitCursor;

            try
            {
                DataGridViewRow row = dgvResponder.Rows[e.RowIndex];
                object idValue = row.Cells["IdChamado"].Value;
                int idChamadoSelecionado;

                if (idValue != null && int.TryParse(idValue.ToString(), out idChamadoSelecionado))
                {

                    string connectionString = "Server=fatalsystemsrv1.database.windows.net;Database=DbaFatal-System;User Id=fatalsystem;Password=F1234567890m@;";


                    string titulo, descricao, categoria, pessoasAfetadas, impedeTrabalho, ocorreuAnteriormente;
                    string prioridadeIA, problemaIA, solucaoIA;

                    using (SqlConnection conexao = new SqlConnection(connectionString))
                    {
                        await conexao.OpenAsync(); 

                       
                        string sqlSelect = @"
                    SELECT Titulo, Descricao, Categoria, PessoasAfetadas, 
                           ImpedeTrabalho, OcorreuAnteriormente, 
                           PrioridadeSugeridaIA, ProblemaSugeridoIA, SolucaoSugeridaIA 
                    FROM Chamado 
                    WHERE IdChamado = @IdChamado";

                        using (SqlCommand cmdSelect = new SqlCommand(sqlSelect, conexao))
                        {
                            cmdSelect.Parameters.AddWithValue("@IdChamado", idChamadoSelecionado);

                            using (SqlDataReader reader = await cmdSelect.ExecuteReaderAsync())
                            {
                                if (!await reader.ReadAsync())
                                {
                                    MessageBox.Show("Chamado não encontrado no banco de dados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return; // Sai se não encontrar o chamado
                                }


                                titulo = reader["Titulo"].ToString();
                                descricao = reader["Descricao"].ToString();
                                categoria = reader["Categoria"].ToString();
                                pessoasAfetadas = reader["PessoasAfetadas"].ToString();
                                impedeTrabalho = reader["ImpedeTrabalho"].ToString();
                                ocorreuAnteriormente = reader["OcorreuAnteriormente"].ToString();

                                
                                prioridadeIA = reader["PrioridadeSugeridaIA"]?.ToString();
                                problemaIA = reader["ProblemaSugeridoIA"]?.ToString();
                                solucaoIA = reader["SolucaoSugeridaIA"]?.ToString();
                            } 
                        }


                        if (string.IsNullOrEmpty(prioridadeIA) || prioridadeIA == "Análise Pendente")
                        {
                            MessageBox.Show("Este chamado ainda não foi triado. Iniciando análise da IA... Isso pode levar alguns segundos.", "Análise da IA", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            try
                            {
                                List<string> solucoesAnteriores = await Funcoes.BuscarSolucoesAnteriores(categoria);

                                AIService aiService = new AIService();
                                var (novoProblema, novaPrioridade, novaSolucao) = await aiService.AnalisarChamado(
                                    titulo,
                                    pessoasAfetadas,
                                    ocorreuAnteriormente,
                                    impedeTrabalho,
                                    descricao,
                                    categoria,
                                    solucoesAnteriores
                                );


                                if (novaPrioridade == "Não identificado" || novaPrioridade.Contains("Erro"))
                                {
                                    MessageBox.Show($"A IA não conseguiu analisar o chamado. Detalhes: {novaSolucao}", "Erro na IA", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                }
                                else
                                {

                                    string sqlUpdate = @"
                                UPDATE Chamado 
                                SET ProblemaSugeridoIA = @Problema, 
                                    SolucaoSugeridaIA = @Solucao, 
                                    PrioridadeSugeridaIA = @Prioridade 
                                WHERE IdChamado = @IdChamado";

                                    using (SqlCommand cmdUpdate = new SqlCommand(sqlUpdate, conexao))
                                    {
                                        cmdUpdate.Parameters.AddWithValue("@Problema", novoProblema);
                                        cmdUpdate.Parameters.AddWithValue("@Solucao", novaSolucao);
                                        cmdUpdate.Parameters.AddWithValue("@Prioridade", novaPrioridade);
                                        cmdUpdate.Parameters.AddWithValue("@IdChamado", idChamadoSelecionado);
                                        await cmdUpdate.ExecuteNonQueryAsync(); // Salva a triagem
                                    }

                                    //Atualiza a linha do DataGridView na tela
                                    if (dgvResponder.Columns.Contains("PrioridadeSugeridaIA"))
                                    {
                                        row.Cells["PrioridadeSugeridaIA"].Value = novaPrioridade;
                                    }

                                    if (dgvResponder.Columns.Contains("ProblemaSugeridoIA"))
                                    {
                                        row.Cells["ProblemaSugeridoIA"].Value = novoProblema;
                                    }

                                    if (dgvResponder.Columns.Contains("SolucaoSugeridaIA"))
                                    {
                                        row.Cells["SolucaoSugeridaIA"].Value = novaSolucao;
                                    }
                                }
                            }
                            catch (Exception aiEx)
                            {
                                MessageBox.Show($"Erro ao executar a análise da IA: {aiEx.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                
                            }
                        }
                    } // Conexão é fechada aqui
                    var analisechamado = new AnaliseChamado(idChamadoSelecionado);
                    analisechamado.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Não foi possível obter o ID do chamado selecionado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao processar o chamado: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

                this.Cursor = Cursors.Default;
            }   
            }
        }
    }

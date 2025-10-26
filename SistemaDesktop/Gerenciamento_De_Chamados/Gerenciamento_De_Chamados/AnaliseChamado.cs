using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading.Tasks; // Adicionado para operações Async
using System.Windows.Forms;

namespace Gerenciamento_De_Chamados
{
    public partial class AnaliseChamado : Form
    {
        private int _chamadoId;
        string connectionString = "Server=fatalsystemsrv1.database.windows.net;Database=DbaFatal-System;User Id=fatalsystem;Password=F1234567890m@;";


        public AnaliseChamado(int chamadoId)
        {
            InitializeComponent();
            _chamadoId = chamadoId;

            // 1. Ligar eventos
            this.Load += AnaliseChamado_Load;

            // Eventos do Panel de Análise
            this.btnSalvarAnalise.Click += new System.EventHandler(this.btnSalvarAnalise_Click);
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);

            // Eventos do Panel de Resposta
            this.btnResponderCH.Click += new System.EventHandler(this.btnResponderCH_Click);
            this.btnCancelar2.Click += new System.EventHandler(this.btnCancelar_Click); // Reutiliza o mesmo método de fechar
        }

        private void AnaliseChamado_Load(object sender, EventArgs e)
        {
            CarregarDadosChamado();
            // Esta função controla o layout inteiro
            ConfigurarLayoutPorStatus();
        }

        private void CarregarDadosChamado()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string sql = @"SELECT Titulo, Descricao, Categoria, StatusChamado,
                                          PrioridadeSugeridaIA, ProblemaSugeridoIA, SolucaoSugeridaIA,
                                          PrioridadeChamado
                                   FROM Chamado
                                   WHERE IdChamado = @IdChamado";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdChamado", _chamadoId);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                
                                txtIdentificacaoProb.Text = reader["ProblemaSugeridoIA"] != DBNull.Value ? reader["ProblemaSugeridoIA"].ToString() : "N/A";
                                txtSolProp.Text = reader["SolucaoSugeridaIA"] != DBNull.Value ? reader["SolucaoSugeridaIA"].ToString() : "N/A";

                                string prioridade = reader["PrioridadeChamado"] != DBNull.Value ? reader["PrioridadeChamado"].ToString() :
                                                    (reader["PrioridadeSugeridaIA"] != DBNull.Value ? reader["PrioridadeSugeridaIA"].ToString() : "Baixa");

                                int index = cboxPrioridProp.FindStringExact(prioridade);
                                if (index != -1) cboxPrioridProp.SelectedIndex = index;
                                else cboxPrioridProp.Text = prioridade;

                                // Guarda o status atual na Tag do formulário
                                string statusAtual = reader["StatusChamado"].ToString();
                                this.Tag = statusAtual;

                                // ---- Popula campos de RESPOSTA (se já resolvido) ----
                                if (statusAtual == "Resolvido")
                                {
                                    reader.Close(); 

                                    // Busca a última solução aplicada no histórico
                                    string sqlSolucao = @"SELECT TOP 1 Solucao FROM Historico 
                                                        WHERE FK_IdChamado = @IdChamado AND Acao = 'Solução Aplicada' 
                                                        ORDER BY DataSolucao DESC";

                                    using (SqlCommand cmdSolucao = new SqlCommand(sqlSolucao, conn))
                                    {
                                        cmdSolucao.Parameters.AddWithValue("@IdChamado", _chamadoId);
                                        object result = cmdSolucao.ExecuteScalar();
                                        if (result != null && result != DBNull.Value)
                                        {
                                            txtSolucaoFinal.Text = result.ToString();
                                        }
                                        else
                                        {
                                            txtSolucaoFinal.Text = "Solução não registrada no histórico.";
                                        }
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Chamado não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                this.Close();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar dados do chamado: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
        }


        private void ConfigurarLayoutPorStatus()
        {
            string statusAtual = this.Tag as string ?? "Pendente";

            switch (statusAtual)
            {
                case "Pendente":
                    
                    panelAnalise.Visible = true;    // Mostra painel de análise
                    panelResposta.Visible = false;  // Esconde painel de resposta
                    break;

                case "Em Andamento":
                    panelAnalise.Visible = false;   // Esconde painel de análise
                    panelResposta.Visible = true;   // Mostra painel de resposta
                    break;

                default: 

                    panelAnalise.Visible = true;
                    panelAnalise.Enabled = false;

                    panelResposta.Visible = true;
                    panelResposta.Enabled = false;
                    break;
            }
        }

        // --- MÉTODOS DOS BOTÕES ---

        private async void btnSalvarAnalise_Click(object sender, EventArgs e)
        {
            // Pega os dados do panelAnalise
            string prioridadeDefinida = cboxPrioridProp.Text;
            string problemaTecnico = txtIdentificacaoProb.Text;
            string solucaoTecnica = txtSolProp.Text;
            string novoStatus = "Em Andamento";
            DateTime dataAgora = ObterHoraBrasilia();

            if (MessageBox.Show("Deseja salvar esta análise e mover o chamado para 'Em Andamento'?", "Confirmar Análise", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            this.Cursor = Cursors.WaitCursor;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                await conn.OpenAsync();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        // 1. Atualiza o Chamado
                        string sqlUpdateChamado = @"
                            UPDATE Chamado 
                            SET StatusChamado = @Status, PrioridadeChamado = @Prioridade,
                                ProblemaSugeridoIA = @Problema, SolucaoSugeridaIA = @Solucao 
                            WHERE IdChamado = @IdChamado";

                        using (SqlCommand cmdUpdate = new SqlCommand(sqlUpdateChamado, conn, trans))
                        {
                            cmdUpdate.Parameters.AddWithValue("@Status", novoStatus);
                            cmdUpdate.Parameters.AddWithValue("@Prioridade", prioridadeDefinida);
                            cmdUpdate.Parameters.AddWithValue("@Problema", problemaTecnico);
                            cmdUpdate.Parameters.AddWithValue("@Solucao", solucaoTecnica);
                            cmdUpdate.Parameters.AddWithValue("@IdChamado", _chamadoId);
                            await cmdUpdate.ExecuteNonQueryAsync();
                        }

                        // 2. Insere Histórico (Troca de Status)
                        string sqlInsertStatus = "INSERT INTO Historico (DataSolucao, Solucao, FK_IdChamado, Acao) VALUES (@Data, @Solucao, @IdChamado, @Acao)";
                        using (SqlCommand cmdStatus = new SqlCommand(sqlInsertStatus, conn, trans))
                        {
                            cmdStatus.Parameters.AddWithValue("@Data", dataAgora);
                            cmdStatus.Parameters.AddWithValue("@Solucao", "O status foi alterado para Em Andamento");
                            cmdStatus.Parameters.AddWithValue("@IdChamado", _chamadoId);
                            cmdStatus.Parameters.AddWithValue("@Acao", "Troca de Status");
                            await cmdStatus.ExecuteNonQueryAsync();
                        }

                        // 3. Insere Histórico (Nota Interna)
                        string notaInterna = $"Identificação: {problemaTecnico} | Proposta: {solucaoTecnica}";
                        string sqlInsertNota = "INSERT INTO Historico (DataSolucao, Solucao, FK_IdChamado, Acao) VALUES (@Data, @Solucao, @IdChamado, @Acao)";
                        using (SqlCommand cmdNota = new SqlCommand(sqlInsertNota, conn, trans))
                        {
                            cmdNota.Parameters.AddWithValue("@Data", dataAgora);
                            cmdNota.Parameters.AddWithValue("@Solucao", notaInterna);
                            cmdNota.Parameters.AddWithValue("@IdChamado", _chamadoId);
                            cmdNota.Parameters.AddWithValue("@Acao", "Nota Interna");
                            await cmdNota.ExecuteNonQueryAsync();
                        }

                         trans.Commit();

                        this.Cursor = Cursors.Default;
                        MessageBox.Show("Análise salva com sucesso. Chamado movido para 'Em Andamento'.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // ---- ATUALIZA A TELA ----
                        this.Tag = novoStatus;       // Atualiza o status
                        ConfigurarLayoutPorStatus(); // Reconfigura a UI (vai esconder panelAnalise e mostrar panelResposta)
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        this.Cursor = Cursors.Default;
                        MessageBox.Show("Erro ao salvar a análise: " + ex.Message, "Erro de Transação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private async void btnResponderCH_Click(object sender, EventArgs e)
        {
            // Pega os dados do panelResposta
            string solucaoFinal = txtSolucaoFinal.Text;
            string novoStatus = "Resolvido";
            DateTime dataAgora = ObterHoraBrasilia();

            if (string.IsNullOrWhiteSpace(solucaoFinal))
            {
                MessageBox.Show("Por favor, descreva a solução aplicada antes de resolver o chamado.", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Deseja aplicar esta solução e marcar o chamado como 'Resolvido'?", "Confirmar Resolução", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            this.Cursor = Cursors.WaitCursor;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                await conn.OpenAsync();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        // 1. Atualiza o Chamado
                        string sqlUpdateChamado = "UPDATE Chamado SET StatusChamado = @Status WHERE IdChamado = @IdChamado";
                        using (SqlCommand cmdUpdate = new SqlCommand(sqlUpdateChamado, conn, trans))
                        {
                            cmdUpdate.Parameters.AddWithValue("@Status", novoStatus);
                            cmdUpdate.Parameters.AddWithValue("@IdChamado", _chamadoId);
                            await cmdUpdate.ExecuteNonQueryAsync();
                        }

                        // 2. Insere Histórico (Troca de Status)
                        string sqlInsertStatus = "INSERT INTO Historico (DataSolucao, Solucao, FK_IdChamado, Acao) VALUES (@Data, @Solucao, @IdChamado, @Acao)";
                        using (SqlCommand cmdStatus = new SqlCommand(sqlInsertStatus, conn, trans))
                        {
                            cmdStatus.Parameters.AddWithValue("@Data", dataAgora);
                            cmdStatus.Parameters.AddWithValue("@Solucao", "O status foi alterado para Resolvido");
                            cmdStatus.Parameters.AddWithValue("@IdChamado", _chamadoId);
                            cmdStatus.Parameters.AddWithValue("@Acao", "Troca de Status");
                            await cmdStatus.ExecuteNonQueryAsync();
                        }

                        // 3. Insere Histórico (Solução Aplicada)
                        string sqlInsertSolucao = "INSERT INTO Historico (DataSolucao, Solucao, FK_IdChamado, Acao) VALUES (@Data, @Solucao, @IdChamado, @Acao)";
                        using (SqlCommand cmdSolucao = new SqlCommand(sqlInsertSolucao, conn, trans))
                        {
                            cmdSolucao.Parameters.AddWithValue("@Data", dataAgora);
                            cmdSolucao.Parameters.AddWithValue("@Solucao", solucaoFinal);
                            cmdSolucao.Parameters.AddWithValue("@IdChamado", _chamadoId);
                            cmdSolucao.Parameters.AddWithValue("@Acao", "Solução Aplicada");
                            await cmdSolucao.ExecuteNonQueryAsync();
                        }

                        trans.Commit();

                        this.Cursor = Cursors.Default;
                        MessageBox.Show("Chamado resolvido e registrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close(); // Fecha o formulário
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        this.Cursor = Cursors.Default;
                        MessageBox.Show("Erro ao salvar a resolução: " + ex.Message, "Erro de Transação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Este método é usado por ambos os botões 'btnCancelar' e 'btnCancelar2'
            this.Close();
        }

       

        private DateTime ObterHoraBrasilia()
        {
            try
            {
                TimeZoneInfo brasilTimeZone = TimeZoneInfo.FindSystemTimeZoneById("E. South America Standard Time");
                return TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, brasilTimeZone);
            }
            catch { return DateTime.Now; }
        }

        // Este é o seu código de gradiente, assumindo que é para um painel de fundo chamado 'panel1'
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            if (panel == null) return;

            Graphics g = e.Graphics;
            Color corInicioPanel = Color.White;
            Color corFimPanel = ColorTranslator.FromHtml("#232325");
            LinearGradientBrush gradientePanel = new LinearGradientBrush(
                   panel.ClientRectangle,
                   corInicioPanel,
                   corFimPanel,
                   LinearGradientMode.Vertical);
            g.FillRectangle(gradientePanel, panel.ClientRectangle);
        }

        private void btnCancelar2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
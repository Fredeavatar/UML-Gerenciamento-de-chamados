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
    public partial class VisualizarChamado : Form
    {
        string connectionString = "Server=fatalsystemsrv1.database.windows.net;Database=DbaFatal-System;User Id=fatalsystem;Password=F1234567890m@;";
        private DataTable chamadosTable = new DataTable();
        public VisualizarChamado()

        {
            InitializeComponent();

            // evento para carregar os dados ao abrir o form
            this.Load += VisualizarChamado_Load;

            ConfigurarGrade();

            // evento para pesquisar
            txtPesquisarChamados.TextChanged += TxtPesquisar_TextChanged;
        }

        private void VisualizarChamado_Load(object sender, EventArgs e)
        {
            CarregarChamados();

            if (!string.IsNullOrEmpty(Funcoes.SessaoUsuario.Nome))
                lbl_NomeUser.Text = ($"Bem vindo {Funcoes.SessaoUsuario.Nome}");
            else
                lbl_NomeUser.Text = "Usuário não identificado";


        }
        private void ConfigurarGrade()
        {

            dgvChamados.RowTemplate.Height = 30;

            dgvChamados.ColumnHeadersHeight = 30;

            dgvChamados.AutoGenerateColumns = false;

            dgvChamados.Columns.Clear();


            dgvChamados.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "IdChamado",
                DataPropertyName = "IdChamado",
                HeaderText = "ID",
                Width = 60
            });
            dgvChamados.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Titulo",
                DataPropertyName = "Titulo",
                HeaderText = "Titulo",
                Width = 200
            });
            dgvChamados.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Prioridade",
                DataPropertyName = "Prioridade",
                HeaderText = "Prioridade",
                Width = 200
            });
            dgvChamados.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Descricao",
                DataPropertyName = "Descricao",
                HeaderText = "Descricao",
                Width = 300
            });
            dgvChamados.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "data",
                DataPropertyName = "data",
                HeaderText = "data",
                Width = 100
            });
            dgvChamados.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Status",
                DataPropertyName = "Status",
                HeaderText = "Status",
                Width = 120
            });
            dgvChamados.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Categoria",
                DataPropertyName = "Categoria",
                HeaderText = "Categoria",
                Width = 120
            });
            dgvChamados.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "IdUsuario",
                DataPropertyName = "IdUsuario",
                HeaderText = "IdUsuario",
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
                using (SqlDataAdapter da = new SqlDataAdapter(sql,conn))
                {
                    da.SelectCommand.Parameters.AddWithValue("@filtro", filtro ?? string.Empty);

                    chamadosTable.Clear();
                    da.Fill(chamadosTable);

                    // Atualiza a fonte de dados
                    dgvChamados.DataSource = chamadosTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar chamados: " + ex.Message);
            }
        }

        private void TxtPesquisar_TextChanged(object sender, EventArgs e)
        {
            CarregarChamados(txtPesquisarChamados.Text);
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

        private void dgvChamados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se o clique foi em uma linha de dados válida (e não no cabeçalho da coluna)
            // e.RowIndex >= 0 significa que não foi no cabeçalho
            if (e.RowIndex >= 0)
            {
                // Pega a linha inteira que recebeu o duplo-clique
                DataGridViewRow row = dgvChamados.Rows[e.RowIndex];

                // Pega o valor da célula que contém o ID. 
                object idValue = row.Cells["IdChamado"].Value;
                int idChamadoSelecionado;

                // Tenta converter o ID para um número inteiro de forma segura
                if (idValue != null && int.TryParse(idValue.ToString(), out idChamadoSelecionado))
                {
                    // Se a conversão funcionou, cria e abre a tela de detalhes, passando o ID
                    var telaDetalhes = new ChamadoCriado(idChamadoSelecionado);
                    telaDetalhes.ShowDialog();

                    CarregarChamados();
                }
            }
        }
    }
}

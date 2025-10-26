using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Reflection;
using System.Windows.Forms;

namespace Gerenciamento_De_Chamados
{
    public partial class GerenciarUsuarios : Form
    {
        string connectionString = "Server=fatalsystemsrv1.database.windows.net;Database=DbaFatal-System;User Id=fatalsystem;Password=F1234567890m@;";
        private DataTable usuariosTable = new DataTable();

        public GerenciarUsuarios()
        {
            InitializeComponent();
            ConfigurarGrade(); // PASSO 1: Configura as colunas
            EstilizarGrade();  // PASSO 2: Aplica o estilo visual

            // Associa os eventos
            this.Load += GerenciarUsuarios_Load;
            txtPesquisarUser.TextChanged += TxtPesquisar_TextChanged;
        }

        private void ConfigurarGrade()
        {
            dgvUsuarios.AutoGenerateColumns = false;
            dgvUsuarios.Columns.Clear();

            dgvUsuarios.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "IdUsuario",
                DataPropertyName = "IdUsuario",
                HeaderText = "ID",
                Width = 60
            });

            dgvUsuarios.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Nome",
                DataPropertyName = "Nome",
                HeaderText = "Nome",
                Width = 180
            });

            dgvUsuarios.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Login",
                DataPropertyName = "Login",
                HeaderText = "Login",
                Width = 80
            });

            dgvUsuarios.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Cargo",
                DataPropertyName = "Cargo",
                HeaderText = "Função",
                Width = 100
            });

            dgvUsuarios.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Email",
                DataPropertyName = "Email",
                HeaderText = "Email",
                Width = 250
            });

            dgvUsuarios.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Setor",
                DataPropertyName = "Setor",
                HeaderText = "Setor",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
        }

        private void EstilizarGrade()
        {
            // Ativa o double buffering para uma rolagem mais suave
            typeof(DataGridView).InvokeMember("DoubleBuffered", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty, null, dgvUsuarios, new object[] { true });

            
           
            dgvUsuarios.ColumnHeadersHeight = 35; 

            dgvUsuarios.RowTemplate.Height = 35;
        }

        private void GerenciarUsuarios_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Funcoes.SessaoUsuario.Nome))
                lbl_NomeUser.Text = $"Olá: {Funcoes.SessaoUsuario.Nome}";
            else
                lbl_NomeUser.Text = "Usuário não identificado";

            CarregarUsuarios();
        }

        private void CarregarUsuarios(string filtro = "")
        {
            string sql = @"
                SELECT IdUsuario, Nome, Login, FuncaoUsuario AS Cargo, Email, Setor
                FROM Usuario
                WHERE (@filtro = '' OR Nome LIKE '%' + @filtro + '%'
                                    OR Email LIKE '%' + @filtro + '%' 
                                    OR FuncaoUsuario LIKE '%' + @filtro + '%'
                                    OR Login LIKE '%' + @filtro + '%'
                                    OR Setor LIKE '%' + @filtro + '%')
                ORDER BY Nome";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    cmd.Parameters.AddWithValue("@filtro", filtro ?? string.Empty);
                    usuariosTable.Clear();
                    da.Fill(usuariosTable);
                    dgvUsuarios.DataSource = usuariosTable; // Apenas atualiza a fonte de dados
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar usuários: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtPesquisar_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtPesquisarUser.Text.Trim();
            CarregarUsuarios(filtro);
        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow == null || dgvUsuarios.CurrentRow.DataBoundItem == null)
            {
                MessageBox.Show("Por favor, selecione um usuário para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            object idValue = dgvUsuarios.CurrentRow.Cells["IdUsuario"].Value;
            if (idValue != null && int.TryParse(idValue.ToString(), out int idUsuarioSelecionado))
            {
                var telaDeEdicao = new Editar_Usuario(idUsuarioSelecionado);
                telaDeEdicao.ShowDialog();
                CarregarUsuarios(txtPesquisarUser.Text.Trim());
            }
            else
            {
                MessageBox.Show("Não foi possível identificar o ID do usuário selecionado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCadastroUser_Click(object sender, EventArgs e)
        {
            var cadastro = new Cadastro_de_Usuarios();
            cadastro.ShowDialog();
            CarregarUsuarios();
        }

        private void btnExcluirUsuario_Click(object sender, EventArgs e)
        {
            // Implementação futura
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
                         LinearGradientMode.Vertical);
            g.FillRectangle(gradientePanel, panel1.ClientRectangle);
        }

        private void lbl_Inicio_Click(object sender, EventArgs e)
        {
            Funcoes.BotaoHomeAdmin(this);
        }
    }
}

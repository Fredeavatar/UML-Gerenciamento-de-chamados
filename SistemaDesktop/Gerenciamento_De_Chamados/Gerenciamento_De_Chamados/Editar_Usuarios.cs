using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Gerenciamento_De_Chamados
{
    public partial class Editar_Usuario : Form
    {

        private int usuarioId;
        string connectionString = "Server=fatalsystemsrv1.database.windows.net;Database=DbaFatal-System;User Id=fatalsystem;Password=F1234567890m@;";

        // Construtor que recebe o ID do usuário a ser editado
        public Editar_Usuario(int idUsuario)
        {
            InitializeComponent();
            this.usuarioId = idUsuario;

            // Associa os eventos aos métodos
            this.Load += Editar_Usuario_Load;
            this.btnSalvar.Click += btnSalvar_Click;
            this.btnCancelar.Click += btnCancelar_Click;
        }

        private void Editar_Usuario_Load(object sender, EventArgs e)
        {
            // Este método é chamado quando o formulário é carregado
            CarregarDadosDoUsuario();
        }

        private void CarregarDadosDoUsuario()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    // Comando SQL para buscar todos os dados do usuário específico
                    string sql = "SELECT Nome, CPF, RG, FuncaoUsuario, Sexo, Setor, DataDeNascimento, Email, Login FROM Usuario WHERE IdUsuario = @IdUsuario";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdUsuario", this.usuarioId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Preenche os campos do formulário com os dados do banco
                                txtNome.Text = reader["Nome"].ToString();
                                txtCPF.Text = reader["CPF"].ToString();
                                txtRG.Text = reader["RG"].ToString();
                                cmbFuncao.SelectedItem = reader["FuncaoUsuario"].ToString();
                                cmbSexo.SelectedItem = reader["Sexo"].ToString();
                                txtSetor.Text = reader["Setor"].ToString();
                                txtEmail.Text = reader["Email"].ToString();
                                txtLogin.Text = reader["Login"].ToString();

                                object dataNascimentoObj = reader["DataDeNascimento"];
                                if (dataNascimentoObj != DBNull.Value)
                                {
                                    DateTime dataNascimento;
                                    if(DateTime.TryParse(dataNascimentoObj.ToString(), out dataNascimento))
                                    {
                                        dtpDataNascimento.Value = dataNascimento;

                                    }
                                        
                                }
                                else
                                {
                                    dtpDataNascimento.Value = DateTime.Today; // Ou qualquer valor padrão
                                }
                            }
                            else
                            {
                                MessageBox.Show("Usuário não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                this.Close();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados do usuário: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text) || string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Os campos Nome e Email são obrigatórios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = @"UPDATE Usuario SET
                              Nome = @Nome, CPF = @CPF, RG = @RG,
                              FuncaoUsuario = @FuncaoUsuario, Sexo = @Sexo, Setor = @Setor,
                              DataDeNascimento = @DataDeNascimento, Email = @Email, Login = @Login
                          WHERE IdUsuario = @IdUsuario";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        
                        cmd.Parameters.AddWithValue("@Nome", txtNome.Text);
                        cmd.Parameters.AddWithValue("@CPF", txtCPF.Text);
                        cmd.Parameters.AddWithValue("@RG", txtRG.Text);
                        cmd.Parameters.AddWithValue("@Setor", txtSetor.Text);
                        cmd.Parameters.AddWithValue("@DataDeNascimento", dtpDataNascimento.Value);
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@Login", txtLogin.Text);
                        cmd.Parameters.AddWithValue("@IdUsuario", this.usuarioId);

                        if (cmbFuncao.SelectedItem != null)
                        {
                            cmd.Parameters.AddWithValue("@FuncaoUsuario", cmbFuncao.SelectedItem.ToString());
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@FuncaoUsuario", DBNull.Value); 
                        }

                        
                        if (cmbSexo.SelectedItem != null)
                        {
                            cmd.Parameters.AddWithValue("@Sexo", cmbSexo.SelectedItem.ToString());
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@Sexo", DBNull.Value); 
                        }

                        
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Usuário atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Nenhuma alteração foi realizada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar alterações: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
           
            this.Close();
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
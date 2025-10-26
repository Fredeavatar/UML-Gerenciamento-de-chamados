using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Gerenciamento_De_Chamados
{
    public partial class Login : Form
    {
        private readonly string connectionString =
            "Server=fatalsystemsrv1.database.windows.net;Database=DbaFatal-System;User Id=fatalsystem;Password=F1234567890m@;";

        public Login()
        {
            InitializeComponent();
            this.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string senhaDigitada = txtSenha.Text.Trim();

            // ✅ Login administrativo padrão
            if (usuario == "admin" && senhaDigitada == "admin1234")
            {
                MessageBox.Show("✅ Login de administrador realizado com sucesso!");

                Funcoes.SessaoUsuario.IdUsuario = 0;
                Funcoes.SessaoUsuario.Login = "admin";
                Funcoes.SessaoUsuario.Nome = "Administrador";

                var home = new HomeAdmin();
                home.Show();
                this.Hide();
                return;
            }

            try
            {
                using (SqlConnection conexao = new SqlConnection(connectionString))
                {
                    conexao.Open();

                    // Busca hash da senha
                    string sql = "SELECT Senha FROM Usuario WHERE Login = @usuario";
                    using (SqlCommand cmd = new SqlCommand(sql, conexao))
                    {
                        cmd.Parameters.AddWithValue("@usuario", usuario);
                        object resultado = cmd.ExecuteScalar();

                        if (resultado == null)
                        {
                            MessageBox.Show($"❌ Usuário '{usuario}' não encontrado.");
                            return;
                        }

                        string hashSalvo = resultado.ToString();

                        // Validação da senha
                        if (SenhaHelper.ValidarSenha(senhaDigitada, hashSalvo))
                        {
                            // ✅ Preenche sessão global do usuário logado
                            try
                            {
                                Funcoes.SessaoUsuario.Login = usuario;
                                Funcoes.SessaoUsuario.Nome = Funcoes.ObterNomeDoUsuario(usuario, conexao);
                                Funcoes.SessaoUsuario.IdUsuario = Funcoes.ObterIdDoUsuario(usuario, conexao);
                                Funcoes.SessaoUsuario.Email = Funcoes.ObterEmailDoUsuario(usuario, conexao);
                                Funcoes.SessaoUsuario.FuncaoUsuario = Funcoes.ObterFuncaoDoUsuario(usuario, conexao);

                                if (!Funcoes.SessaoUsuario.UsuarioIdentificado())
                                {
                                    MessageBox.Show("⚠️ Usuário identificado parcialmente. Verifique os dados no banco.");
                                    return;
                                }

                                MessageBox.Show($"✅ Login realizado com sucesso!\nBem-vindo, {Funcoes.SessaoUsuario.Nome}");

                                string funcao = Funcoes.SessaoUsuario.FuncaoUsuario.ToLower();

                                if (funcao == "admin")
                                {
                                    var homeAdmin = new HomeAdmin();
                                    homeAdmin.Show();
                                    this.Hide();
                                }
                                else if (funcao == "tecnico")
                                {
                                    var homeTecnico = new HomeTecnico();
                                    homeTecnico.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    var homeUser = new HomeFuncionario();
                                    homeUser.Show();
                                    this.Hide();
                                }
                            }
                            catch (Exception exSessao)
                            {
                                MessageBox.Show("Erro ao carregar informações do usuário: " + exSessao.Message);
                            }
                        }
                        else
                        {
                            MessageBox.Show("❌ Senha incorreta!");
                            txtSenha.Focus();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro de conexão ou execução: " + ex.Message);
            }
        }

        #region Estética e comportamento dos campos

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            txtUsuario.BackColor = Color.LightYellow;
            if (txtUsuario.Text == "Digite seu usuário, apenas letras ou números.")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            txtUsuario.BackColor = Color.White;
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Digite seu usuário, apenas letras ou números.";
                txtUsuario.ForeColor = SystemColors.InactiveCaption;
            }
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            txtSenha.BackColor = Color.LightYellow;
            if (txtSenha.Text == "Senha")
            {
                txtSenha.Text = "";
                txtSenha.ForeColor = Color.Black;
                txtSenha.UseSystemPasswordChar = true;
            }
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            txtSenha.BackColor = Color.White;
            if (txtSenha.Text == "")
            {
                txtSenha.Text = "Senha";
                txtSenha.ForeColor = SystemColors.InactiveCaption;
                txtSenha.UseSystemPasswordChar = false;
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
                MessageBox.Show("Digite apenas letras ou números.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Login_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Color corInicio = Color.White;
            Color corFim = ColorTranslator.FromHtml("#232325");

            using (LinearGradientBrush gradiente = new LinearGradientBrush(
                this.ClientRectangle, corInicio, corFim, LinearGradientMode.Horizontal))
            {
                g.FillRectangle(gradiente, this.ClientRectangle);
            }

            #endregion
        }
    }
}

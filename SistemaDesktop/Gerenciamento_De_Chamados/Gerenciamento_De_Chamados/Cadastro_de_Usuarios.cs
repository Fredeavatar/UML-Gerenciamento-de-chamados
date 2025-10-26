using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerenciamento_De_Chamados
{
    public partial class Cadastro_de_Usuarios : Form
    {
        public Cadastro_de_Usuarios()
        {
            InitializeComponent();
            this.Load += Cadastro_de_Usuarios_Load;
        }

        private void btnCadastroAdd_Click(object sender, EventArgs e)
        {
            string CadastroRg = txtCadastroRG.Text.Trim();
            string CadastroCPF = txtCadastroCpf.Text.Trim();
            string CadastroNome = txtCadastroNome.Text.Trim();
            string CadastroUsuario = txtCadastroLogin.Text.Trim();
            string CadastroEmail = txtCadastroEmail.Text.Trim();
            string CadastroSenhaDigitada = txtCadastroSenha.Text.Trim();
            string CadastroFuncaoUsuario = cbxCadastroFuncao.Text;
            string CadastroSexo = comboBoxCadastroSexo.Text;
            string CadastroSetor = cBoxCadSetor.Text;
            DateTime CadastroDataDeNascimento = dtpCadDN.Value;

            // 🔎 Validação básica
            if (string.IsNullOrWhiteSpace(CadastroUsuario) ||
                CadastroUsuario == "Digite seu usuário, apenas letras ou números.")
            {
                MessageBox.Show("⚠️ Login inválido. Digite um login válido.");
                return;
            }

            if (string.IsNullOrWhiteSpace(CadastroSenhaDigitada))
            {
                MessageBox.Show("⚠️ Senha é obrigatória.");
                return;
            }

            string hashSenha = SenhaHelper.GerarHashSenha(CadastroSenhaDigitada);

            string connectionString = "Server=fatalsystemsrv1.database.windows.net;Database=DbaFatal-System;User Id=fatalsystem;Password=F1234567890m@;";

            using (SqlConnection conexao = new SqlConnection(connectionString))
            {
                try
                {
                    conexao.Open();

                    // 🔎 Verifica se já existe login igual
                    string checkSql = "SELECT COUNT(*) FROM Usuario WHERE Login = @login";
                    using (SqlCommand checkCmd = new SqlCommand(checkSql, conexao))
                    {
                        checkCmd.Parameters.AddWithValue("@login", CadastroUsuario);
                        int count = (int)checkCmd.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("⚠️ Já existe um usuário com esse login. Escolha outro.");
                            return;
                        }
                    }

                    // ✅ Insere novo usuário
                    string sql = @"INSERT INTO Usuario 
                                   (Login, Nome, CPF, RG, FuncaoUsuario, Sexo, Setor, DataDeNascimento, Senha, Email)
                                   VALUES (@login, @Nome, @CPF, @RG, @FuncaoUsuario, @Sexo, @Setor, @DataDeNascimento, @senha, @Email)";

                    using (SqlCommand cmd = new SqlCommand(sql, conexao))
                    {
                        cmd.Parameters.AddWithValue("@Nome", CadastroNome);
                        cmd.Parameters.AddWithValue("@CPF", CadastroCPF);
                        cmd.Parameters.AddWithValue("@RG", CadastroRg);
                        cmd.Parameters.AddWithValue("@FuncaoUsuario", CadastroFuncaoUsuario);
                        cmd.Parameters.AddWithValue("@Sexo", CadastroSexo);
                        cmd.Parameters.AddWithValue("@Setor", CadastroSetor);
                        cmd.Parameters.AddWithValue("@DataDeNascimento", CadastroDataDeNascimento);
                        cmd.Parameters.AddWithValue("@login", CadastroUsuario);
                        cmd.Parameters.AddWithValue("@senha", hashSenha);
                        cmd.Parameters.AddWithValue("@Email", CadastroEmail);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("✅ Usuário cadastrado com sucesso!");

                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("❌ Erro ao cadastrar: " + ex.Message);
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
        private void Cadastro_de_Usuarios_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Funcoes.SessaoUsuario.Nome))
                lbl_NomeUser.Text = ($"Bem vindo {Funcoes.SessaoUsuario.Nome}");
            else
                lbl_NomeUser.Text = "Usuário não identificado";
        }
    }
}
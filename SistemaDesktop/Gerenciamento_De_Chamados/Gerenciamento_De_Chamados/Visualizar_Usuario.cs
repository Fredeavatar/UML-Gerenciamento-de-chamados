using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerenciamento_De_Chamados
{ 

    public partial class Visualizar_Usuario : Form
{
    private int usuarioId;
    string connectionString = "Server=fatalsystemsrv1.database.windows.net;Database=DbaFatal-System;User Id=fatalsystem;Password=F1234567890m@;";

    public Visualizar_Usuario()
    {
        InitializeComponent();
    }

    private void Visualizar_Usuario_Load(object sender, EventArgs e)
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
                            cmbFuncao.SelectedItem = reader["FuncaoUsuario"].ToString();
                            cmbSexo.SelectedItem = reader["Sexo"].ToString();
                            txtSetor.Text = reader["Setor"].ToString();
                            txtEmail.Text = reader["Email"].ToString();
                            txtLogin.Text = reader["Login"].ToString();

                            object dataNascimentoObj = reader["DataDeNascimento"];
                            if (dataNascimentoObj != DBNull.Value)
                            {
                                DateTime dataNascimento;
                                if (DateTime.TryParse(dataNascimentoObj.ToString(), out dataNascimento))
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
}
}

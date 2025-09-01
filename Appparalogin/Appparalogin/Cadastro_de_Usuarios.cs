using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Appparalogin
{
    public partial class Cadastro_de_Usuarios : Form
    {
        public Cadastro_de_Usuarios()
        {
            InitializeComponent();
        }

        private void btnCadastroAdd_Click(object sender, EventArgs e)
        {
            //Definimos a string de conexão com o banco de dados
            SqlConnection conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=GERENCIAMENTO_CHAMADOS;Integrated Security=True");

            //Cria string de inserção SQL
            string sql = "INSERT INTO CADASTRO(Nome, Email, Telefone, SenhaHash) VALUES(@Nome, @Email, @Telefone, @SenhaHash)";

            try
            {
                //cria um objeto do tipo comando passando como parametro a string sql e conn
                SqlCommand c = new SqlCommand(sql, conn);

                //Insere os dados da textBox no comando sql
                c.Parameters.Add(new SqlParameter("@Nome", this.txtCadastroNome.Text));
                c.Parameters.Add(new SqlParameter("@Email", this.txtCadastroEmail.Text));
                c.Parameters.Add(new SqlParameter("@Telefone", this.txtCadastroTel.Text));
                c.Parameters.Add(new SqlParameter("@SenhaHash", this.txtCadastroSenha.Text));

                //Abrimos conexao com banco de dados
                conn.Open();


                //Executa o comando sql no banco de dados
                c.ExecuteNonQuery();


                //Fechamos a conexão
                conn.Close();


                MessageBox.Show("Dados inseridos com sucesso!");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro de banco de dados: " + ex.Message);
            }
        }
    }
}

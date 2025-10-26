using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Gerenciamento_De_Chamados
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            string connectionString = "Server=fatalsystemsrv1.database.windows.net;Database=DbaFatal-System;User Id=frederico;Password=Fred11376@;";

            // Testar conexão ANTES de abrir o login
            if (TestarConexao(connectionString))
            {
                Application.Run(new Login()); // Abre o form de login
            }
            else
            {
                MessageBox.Show("❌ Não foi possível conectar ao banco de dados.\nVerifique as configurações.",
                                "Erro de Conexão",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        static bool TestarConexao(string connectionString)
        {
            using (SqlConnection conexao = new SqlConnection(connectionString))
            {
                try
                {
                    conexao.Open();
                    return true; // Conectou com sucesso
                }
                catch
                {
                    return false; // Falhou
                }
            }
        }
    }
}

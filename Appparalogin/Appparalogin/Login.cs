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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsuario.Text == "admin" && txtSenha.Text == "123")
                {
                    var menu = new MenuRestrito();

                    menu.Show();


                    this.Visible = false;
                    //this.Dispose();
                    

                }
                else
                {
                    MessageBox.Show("Usuário ou senha inválidos",
                                    "Atenção!!",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);

                    txtUsuario.Focus();
                    txtSenha.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message,
                                "Atenção!!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

            }
        }
    }
}

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
    public partial class MenuRestrito : Form
    {
        public MenuRestrito()
        {
            InitializeComponent();
        }

        private void btnCadastroUser_Click(object sender, EventArgs e)
        {
            var Cadastro = new Cadastro_de_Usuarios();
            Cadastro.Show();
            this.Visible = false;
        }
    }
}

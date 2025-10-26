using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerenciamento_De_Chamados
{
    public partial class HomeAdmin: Form
    {


        private Funcoes funcoes;
        public HomeAdmin()
        {
            InitializeComponent();

            funcoes = new Funcoes();

        }
 

        private void btnGerChamado_Click(object sender, EventArgs e)
        {
            var gerchamado = new GerenciarChamado();
            gerchamado. Show();
            this.Hide(); // Oculta o form atual
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var gerusuario = new GerenciarUsuarios();
            gerusuario.Show(); 
            this.Hide(); 
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

        private void Home_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Funcoes.SessaoUsuario.Nome))
                lbl_NomeUser.Text = ($"Bem-Vindo, {Funcoes.SessaoUsuario.Nome}  {Funcoes.SessaoUsuario.FuncaoUsuario}!");
           
            else
                lbl_NomeUser.Text = "Usuário não identificado";
        }

        private void HomeAdmin_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Color corInicio = Color.White;
            Color corFim = ColorTranslator.FromHtml("#232325");

            using (LinearGradientBrush gradiente = new LinearGradientBrush(
                this.ClientRectangle, corInicio, corFim, LinearGradientMode.Horizontal))
            {
                g.FillRectangle(gradiente, this.ClientRectangle);
            }
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            var relatorio = new Relatorio();
            relatorio.Show();
            this.Hide();

        }
    }
}

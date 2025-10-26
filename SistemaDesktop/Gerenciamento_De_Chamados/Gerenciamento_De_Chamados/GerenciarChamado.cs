using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerenciamento_De_Chamados
{
    public partial class GerenciarChamado : Form
    {
        public GerenciarChamado()
        {
            InitializeComponent();
            this.Load += GerenciarChamado_Load;
        }

        private void btnCriarChamado_Click(object sender, EventArgs e)
        {
            var aberturaChamadosForm = new AberturaChamados();
            aberturaChamadosForm.Show();
            this.Hide();
        }

        private void btnVisualizarCh_Click(object sender, EventArgs e)
        {
            try
            {
                var visualizarChamados = new Responder_Chamado();
                visualizarChamados.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir janela: " + ex.Message);
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

        private void GerenciarChamado_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Funcoes.SessaoUsuario.Nome))
                lbl_NomeUser.Text = ($"Bem vindo {Funcoes.SessaoUsuario.Nome}");
            else
                lbl_NomeUser.Text = "Usuário não identificado";
        }
    }
}

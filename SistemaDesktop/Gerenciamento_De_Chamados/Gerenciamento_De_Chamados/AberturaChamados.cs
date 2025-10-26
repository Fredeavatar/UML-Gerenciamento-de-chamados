using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerenciamento_De_Chamados
{
    public partial class AberturaChamados : Form
    {
        public AberturaChamados()
        {
            InitializeComponent();
            this.Load += AberturaChamados_Load;

        }
        Funcoes funcoes = new Funcoes();
        public void btnContinuar_Click(object sender, EventArgs e)
        {
            var continuaçaoabertura = new ContinuaçaoAbertura(this);
            continuaçaoabertura.Show();
            this.Hide(); // Oculta o form atual
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

        public byte[] arquivoAnexado;
        private void btnAnexArq_Click(object sender, EventArgs e)
        {
            arquivoAnexado = funcoes.SelecionarArquivoEConverter();

            if (arquivoAnexado != null)
            {
                btnAnexArq.Image = funcoes.ByteArrayToImage(arquivoAnexado);
            }
            else
            {
                MessageBox.Show("Nenhum arquivo foi selecionado.");
            }

        }

        private void AberturaChamados_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Funcoes.SessaoUsuario.Nome))
                lbl_NomeUser.Text = ($"Bem vindo {Funcoes.SessaoUsuario.Nome}");
            else
                lbl_NomeUser.Text = "Usuário não identificado";
        }

        private void lbl_Inicio_Click(object sender, EventArgs e)
        {
            Funcoes.BotaoHomeAdmin(this);
        }

        private void PctBox_Logo_Click(object sender, EventArgs e)
        {
            Funcoes.BotaoHomeAdmin(this);
        }

        private void lblMconta_Click(object sender, EventArgs e)
        {
            var visualizarUsuario = new Visualizar_Usuario();
            visualizarUsuario.Show();
            this.Hide();
        }

        private void lbSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você realmente deseja sair ?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var Telalogin = new Login();
                Telalogin.Show();
                this.Hide();
            }
        }
    }
}

    
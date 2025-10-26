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
    public partial class FimChamado : Form
    {
        //variavel para receber o ID do chamado
        private int chamadoId;
        public FimChamado(int idDoChamado)
        {
            InitializeComponent();
            this.Load += FimChamado_Load;
            this.chamadoId = idDoChamado; // Atribui o ID recebido à variável da classe
        }

        private void btnVerChamado_Click(object sender, EventArgs e)
        {

            var telaDetalhes = new ChamadoCriado(this.chamadoId);
            telaDetalhes.ShowDialog();
            this.Close();
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

        private void btn_PaginaInicial_Click(object sender, EventArgs e)
        {
            var telaHome = new HomeAdmin();
            telaHome.Show();
            this.Visible = false;
        }
        private void FimChamado_Load(object sender, EventArgs e)
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
    }
}




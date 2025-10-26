namespace Gerenciamento_De_Chamados
{
    partial class Responder_Chamado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PctBox_Logo = new System.Windows.Forms.PictureBox();
            this.lbl_NomeUser = new System.Windows.Forms.Label();
            this.roundedPanel1 = new RoundedPanel();
            this.btnVisualizarCh = new System.Windows.Forms.Button();
            this.dgvResponder = new System.Windows.Forms.DataGridView();
            this.teste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnResponderCH = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panelBtn = new RoundedPanel();
            this.btnEditarCH = new System.Windows.Forms.Button();
            this.roundedPanel2 = new RoundedPanel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctBox_Logo)).BeginInit();
            this.roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResponder)).BeginInit();
            this.panelBtn.SuspendLayout();
            this.roundedPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(231, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1001, 84);
            this.panel2.TabIndex = 22;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.Image = global::Gerenciamento_De_Chamados.Properties.Resources.account_circle_51dp_000000_FILL0_wght400_GRAD0_opsz48__1_;
            this.pictureBox4.Location = new System.Drawing.Point(939, 13);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(51, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Image = global::Gerenciamento_De_Chamados.Properties.Resources.HOME__2_;
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label9.Location = new System.Drawing.Point(22, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 26);
            this.label9.TabIndex = 5;
            this.label9.Text = "       Início";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.PctBox_Logo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 794);
            this.panel1.TabIndex = 21;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = global::Gerenciamento_De_Chamados.Properties.Resources.Suporte;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(20, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "      FAQ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::Gerenciamento_De_Chamados.Properties.Resources.menu;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(20, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "      Meus Chamados";
            // 
            // PctBox_Logo
            // 
            this.PctBox_Logo.Image = global::Gerenciamento_De_Chamados.Properties.Resources.Imagem_do_WhatsApp_de_2025_09_09_à_s__21_56_18_5730b37d___Editado;
            this.PctBox_Logo.Location = new System.Drawing.Point(-35, -51);
            this.PctBox_Logo.Name = "PctBox_Logo";
            this.PctBox_Logo.Size = new System.Drawing.Size(295, 242);
            this.PctBox_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PctBox_Logo.TabIndex = 3;
            this.PctBox_Logo.TabStop = false;
            // 
            // lbl_NomeUser
            // 
            this.lbl_NomeUser.AutoSize = true;
            this.lbl_NomeUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NomeUser.Location = new System.Drawing.Point(289, 119);
            this.lbl_NomeUser.Name = "lbl_NomeUser";
            this.lbl_NomeUser.Size = new System.Drawing.Size(0, 31);
            this.lbl_NomeUser.TabIndex = 20;
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.White;
            this.roundedPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.roundedPanel1.BorderWidth = 1F;
            this.roundedPanel1.Controls.Add(this.roundedPanel2);
            this.roundedPanel1.Controls.Add(this.panelBtn);
            this.roundedPanel1.Controls.Add(this.dgvResponder);
            this.roundedPanel1.CornerRadius = 15;
            this.roundedPanel1.Location = new System.Drawing.Point(250, 106);
            this.roundedPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(950, 666);
            this.roundedPanel1.TabIndex = 28;
            // 
            // btnVisualizarCh
            // 
            this.btnVisualizarCh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizarCh.Location = new System.Drawing.Point(28, 18);
            this.btnVisualizarCh.Margin = new System.Windows.Forms.Padding(2);
            this.btnVisualizarCh.Name = "btnVisualizarCh";
            this.btnVisualizarCh.Size = new System.Drawing.Size(153, 45);
            this.btnVisualizarCh.TabIndex = 21;
            this.btnVisualizarCh.Text = "Visualizar";
            this.btnVisualizarCh.UseVisualStyleBackColor = true;
            // 
            // dgvResponder
            // 
            this.dgvResponder.AllowUserToAddRows = false;
            this.dgvResponder.AllowUserToDeleteRows = false;
            this.dgvResponder.AllowUserToResizeColumns = false;
            this.dgvResponder.AllowUserToResizeRows = false;
            this.dgvResponder.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResponder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvResponder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResponder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.teste,
            this.Column1});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvResponder.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvResponder.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.dgvResponder.Location = new System.Drawing.Point(30, 93);
            this.dgvResponder.Margin = new System.Windows.Forms.Padding(2);
            this.dgvResponder.Name = "dgvResponder";
            this.dgvResponder.ReadOnly = true;
            this.dgvResponder.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvResponder.RowHeadersVisible = false;
            this.dgvResponder.RowHeadersWidth = 51;
            this.dgvResponder.RowTemplate.Height = 24;
            this.dgvResponder.Size = new System.Drawing.Size(887, 433);
            this.dgvResponder.StandardTab = true;
            this.dgvResponder.TabIndex = 20;
            this.dgvResponder.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResponder_CellDoubleClick);
            // 
            // teste
            // 
            this.teste.HeaderText = "Column1";
            this.teste.MinimumWidth = 6;
            this.teste.Name = "teste";
            this.teste.ReadOnly = true;
            this.teste.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // btnResponderCH
            // 
            this.btnResponderCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResponderCH.Location = new System.Drawing.Point(214, 18);
            this.btnResponderCH.Margin = new System.Windows.Forms.Padding(2);
            this.btnResponderCH.Name = "btnResponderCH";
            this.btnResponderCH.Size = new System.Drawing.Size(153, 45);
            this.btnResponderCH.TabIndex = 19;
            this.btnResponderCH.Text = "Responder";
            this.btnResponderCH.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(293, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "Chamados Criados";
            // 
            // panelBtn
            // 
            this.panelBtn.BorderColor = System.Drawing.Color.Gray;
            this.panelBtn.BorderWidth = 1F;
            this.panelBtn.Controls.Add(this.btnEditarCH);
            this.panelBtn.Controls.Add(this.btnVisualizarCh);
            this.panelBtn.Controls.Add(this.btnResponderCH);
            this.panelBtn.CornerRadius = 15;
            this.panelBtn.Location = new System.Drawing.Point(30, 556);
            this.panelBtn.Name = "panelBtn";
            this.panelBtn.Size = new System.Drawing.Size(579, 78);
            this.panelBtn.TabIndex = 22;
            // 
            // btnEditarCH
            // 
            this.btnEditarCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarCH.Location = new System.Drawing.Point(398, 18);
            this.btnEditarCH.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditarCH.Name = "btnEditarCH";
            this.btnEditarCH.Size = new System.Drawing.Size(153, 45);
            this.btnEditarCH.TabIndex = 22;
            this.btnEditarCH.Text = "Editar";
            this.btnEditarCH.UseVisualStyleBackColor = true;
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.BorderColor = System.Drawing.Color.Gray;
            this.roundedPanel2.BorderWidth = 1F;
            this.roundedPanel2.Controls.Add(this.label2);
            this.roundedPanel2.CornerRadius = 15;
            this.roundedPanel2.Location = new System.Drawing.Point(22, 0);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.Size = new System.Drawing.Size(902, 88);
            this.roundedPanel2.TabIndex = 23;
            // 
            // Responder_Chamado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 794);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_NomeUser);
            this.Controls.Add(this.roundedPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Responder_Chamado";
            this.Text = "Responder_Chamado";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Responder_Chamado_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Responder_Chamado_Paint);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctBox_Logo)).EndInit();
            this.roundedPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResponder)).EndInit();
            this.panelBtn.ResumeLayout(false);
            this.roundedPanel2.ResumeLayout(false);
            this.roundedPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PctBox_Logo;
        private System.Windows.Forms.Label lbl_NomeUser;
        private RoundedPanel roundedPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnResponderCH;
        private System.Windows.Forms.DataGridView dgvResponder;
        private System.Windows.Forms.DataGridViewTextBoxColumn teste;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button btnVisualizarCh;
        private RoundedPanel panelBtn;
        private System.Windows.Forms.Button btnEditarCH;
        private RoundedPanel roundedPanel2;
    }
}
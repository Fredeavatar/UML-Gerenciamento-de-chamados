namespace Gerenciamento_De_Chamados
{
    partial class GerenciarUsuarios
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PctBox_Logo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_NomeUser = new System.Windows.Forms.Label();
            this.lbl_Inicio = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPesquisarUser = new System.Windows.Forms.TextBox();
            this.btnEditarUsuario = new System.Windows.Forms.Button();
            this.btnCadastroUser = new System.Windows.Forms.Button();
            this._DbaFatal_SystemDataSet = new Gerenciamento_De_Chamados._DbaFatal_SystemDataSet();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.funcaoUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctBox_Logo)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._DbaFatal_SystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(229, 754);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = global::Gerenciamento_De_Chamados.Properties.Resources.contact_support_24dp_000000_FILL0_wght400_GRAD0_opsz24;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(12, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "      FAQ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::Gerenciamento_De_Chamados.Properties.Resources.menu_24dp_000000_FILL0_wght400_GRAD0_opsz24__1_;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(12, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 25);
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lbl_NomeUser);
            this.panel2.Controls.Add(this.lbl_Inicio);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(229, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1048, 84);
            this.panel2.TabIndex = 2;
            // 
            // lbl_NomeUser
            // 
            this.lbl_NomeUser.AutoSize = true;
            this.lbl_NomeUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NomeUser.Location = new System.Drawing.Point(174, 38);
            this.lbl_NomeUser.Name = "lbl_NomeUser";
            this.lbl_NomeUser.Size = new System.Drawing.Size(0, 25);
            this.lbl_NomeUser.TabIndex = 8;
            // 
            // lbl_Inicio
            // 
            this.lbl_Inicio.AutoSize = true;
            this.lbl_Inicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Inicio.Image = global::Gerenciamento_De_Chamados.Properties.Resources.HOME__2_;
            this.lbl_Inicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Inicio.Location = new System.Drawing.Point(58, 34);
            this.lbl_Inicio.Name = "lbl_Inicio";
            this.lbl_Inicio.Size = new System.Drawing.Size(120, 31);
            this.lbl_Inicio.TabIndex = 5;
            this.lbl_Inicio.Text = "      Início";
            this.lbl_Inicio.Click += new System.EventHandler(this.lbl_Inicio_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.Image = global::Gerenciamento_De_Chamados.Properties.Resources.account_circle_51dp_000000_FILL0_wght400_GRAD0_opsz48__1_;
            this.pictureBox4.Location = new System.Drawing.Point(985, 13);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(51, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(265, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(344, 46);
            this.label2.TabIndex = 5;
            this.label2.Text = "Gerenciar Usuário";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(268, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Pesquisar:";
            // 
            // txtPesquisarUser
            // 
            this.txtPesquisarUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesquisarUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisarUser.Location = new System.Drawing.Point(379, 211);
            this.txtPesquisarUser.Multiline = true;
            this.txtPesquisarUser.Name = "txtPesquisarUser";
            this.txtPesquisarUser.Size = new System.Drawing.Size(776, 35);
            this.txtPesquisarUser.TabIndex = 7;
            // 
            // btnEditarUsuario
            // 
            this.btnEditarUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEditarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarUsuario.Image = global::Gerenciamento_De_Chamados.Properties.Resources.edit_44dp_000000_FILL0_wght400_GRAD0_opsz48;
            this.btnEditarUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarUsuario.Location = new System.Drawing.Point(514, 664);
            this.btnEditarUsuario.Name = "btnEditarUsuario";
            this.btnEditarUsuario.Size = new System.Drawing.Size(159, 55);
            this.btnEditarUsuario.TabIndex = 4;
            this.btnEditarUsuario.Text = "         Editar ";
            this.btnEditarUsuario.UseVisualStyleBackColor = true;
            this.btnEditarUsuario.Click += new System.EventHandler(this.btnEditarUsuario_Click);
            // 
            // btnCadastroUser
            // 
            this.btnCadastroUser.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCadastroUser.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnCadastroUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCadastroUser.Image = global::Gerenciamento_De_Chamados.Properties.Resources.add_44dp_F3F3F3_FILL0_wght400_GRAD0_opsz48;
            this.btnCadastroUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastroUser.Location = new System.Drawing.Point(273, 664);
            this.btnCadastroUser.Name = "btnCadastroUser";
            this.btnCadastroUser.Size = new System.Drawing.Size(204, 55);
            this.btnCadastroUser.TabIndex = 0;
            this.btnCadastroUser.Text = "      Cadastrar";
            this.btnCadastroUser.UseVisualStyleBackColor = false;
            this.btnCadastroUser.Click += new System.EventHandler(this.btnCadastroUser_Click);
            // 
            // _DbaFatal_SystemDataSet
            // 
            this._DbaFatal_SystemDataSet.DataSetName = "_DbaFatal_SystemDataSet";
            this._DbaFatal_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.AllowUserToResizeColumns = false;
            this.dgvUsuarios.AllowUserToResizeRows = false;
            this.dgvUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUsuarios.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.funcaoUsuarioDataGridViewTextBoxColumn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsuarios.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsuarios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvUsuarios.Location = new System.Drawing.Point(272, 309);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.RowHeadersVisible = false;
            this.dgvUsuarios.RowHeadersWidth = 51;
            this.dgvUsuarios.Size = new System.Drawing.Size(885, 309);
            this.dgvUsuarios.TabIndex = 8;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "Usuario";
            this.usuarioBindingSource.DataSource = this._DbaFatal_SystemDataSet;
            // 
            // funcaoUsuarioDataGridViewTextBoxColumn
            // 
            this.funcaoUsuarioDataGridViewTextBoxColumn.DataPropertyName = "FuncaoUsuario";
            this.funcaoUsuarioDataGridViewTextBoxColumn.HeaderText = "Cargo";
            this.funcaoUsuarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.funcaoUsuarioDataGridViewTextBoxColumn.Name = "funcaoUsuarioDataGridViewTextBoxColumn";
            this.funcaoUsuarioDataGridViewTextBoxColumn.Width = 295;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 294;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.Width = 295;
            // 
            // GerenciarUsuarios
            // 
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1277, 754);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.txtPesquisarUser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEditarUsuario);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCadastroUser);
            this.Name = "GerenciarUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GerenciarUsuarios_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctBox_Logo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._DbaFatal_SystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrarUsers;
        private System.Windows.Forms.Button btnCadastroUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox PctBox_Logo;
        private System.Windows.Forms.Button btnEditarUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Inicio;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPesquisarUser;
        private Gerenciamento_De_Chamados._DbaFatal_SystemDataSet _DbaFatal_SystemDataSet;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Label lbl_NomeUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcaoUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
    }
}
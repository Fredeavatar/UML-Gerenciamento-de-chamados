namespace Gerenciamento_De_Chamados
{
    partial class Editar_Usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editar_Usuario));
            this.cmbFuncao = new System.Windows.Forms.ComboBox();
            this.txtSetor = new System.Windows.Forms.ComboBox();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.CPF = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_NomeUser = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCadastroCancel = new System.Windows.Forms.Button();
            this.txtCadastroSenha = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCadastroAdd = new System.Windows.Forms.Button();
            this.lblCadastroSenha = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAlterarSenha = new System.Windows.Forms.Button();
            this.lbl_Inicio = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PctBox_Logo = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctBox_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbFuncao
            // 
            this.cmbFuncao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cmbFuncao.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFuncao.FormattingEnabled = true;
            this.cmbFuncao.Items.AddRange(new object[] {
            "Admin",
            "Supervisor",
            "Tecnico",
            "Operador",
            "Terceirizado",
            "Outros.."});
            this.cmbFuncao.Location = new System.Drawing.Point(887, 422);
            this.cmbFuncao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbFuncao.Name = "cmbFuncao";
            this.cmbFuncao.Size = new System.Drawing.Size(457, 44);
            this.cmbFuncao.TabIndex = 54;
            this.cmbFuncao.Text = "Selecione";
            // 
            // txtSetor
            // 
            this.txtSetor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtSetor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSetor.FormattingEnabled = true;
            this.txtSetor.Items.AddRange(new object[] {
            "RH",
            "Financeiro",
            "Administrativo",
            "Operador"});
            this.txtSetor.Location = new System.Drawing.Point(887, 325);
            this.txtSetor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSetor.Name = "txtSetor";
            this.txtSetor.Size = new System.Drawing.Size(457, 44);
            this.txtSetor.TabIndex = 53;
            this.txtSetor.Text = "Selecione";
            // 
            // txtRG
            // 
            this.txtRG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtRG.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRG.Location = new System.Drawing.Point(347, 526);
            this.txtRG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(465, 41);
            this.txtRG.TabIndex = 52;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(341, 490);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 31);
            this.label11.TabIndex = 51;
            this.label11.Text = "RG:";
            // 
            // txtLogin
            // 
            this.txtLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.Location = new System.Drawing.Point(887, 626);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(4);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(457, 41);
            this.txtLogin.TabIndex = 50;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(881, 587);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 36);
            this.label10.TabIndex = 49;
            this.label10.Text = "Login: ";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(363, -100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(379, 46);
            this.label8.TabIndex = 48;
            this.label8.Text = "Cadastro de usuário";
            // 
            // cmbSexo
            // 
            this.cmbSexo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cmbSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "Feminino",
            "Masculino",
            "Outros"});
            this.cmbSexo.Location = new System.Drawing.Point(347, 731);
            this.cmbSexo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(465, 44);
            this.cmbSexo.TabIndex = 47;
            this.cmbSexo.Text = "Selecione";
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dtpDataNascimento.CustomFormat = "dd/MM/yyyy";
            this.dtpDataNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataNascimento.Location = new System.Drawing.Point(347, 626);
            this.dtpDataNascimento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(465, 41);
            this.dtpDataNascimento.TabIndex = 46;
            this.dtpDataNascimento.Tag = "";
            this.dtpDataNascimento.Value = new System.DateTime(1900, 1, 1, 11, 45, 0, 0);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(881, 386);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 31);
            this.label7.TabIndex = 45;
            this.label7.Text = "Função:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(881, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 31);
            this.label6.TabIndex = 44;
            this.label6.Text = "Setor:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(341, 681);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 31);
            this.label5.TabIndex = 43;
            this.label5.Text = "Sexo:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(341, 590);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(263, 31);
            this.label4.TabIndex = 42;
            this.label4.Text = "Data de nascimento:";
            // 
            // txtCPF
            // 
            this.txtCPF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPF.Location = new System.Drawing.Point(347, 425);
            this.txtCPF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(465, 41);
            this.txtCPF.TabIndex = 41;
            // 
            // CPF
            // 
            this.CPF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.CPF.AutoSize = true;
            this.CPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPF.Location = new System.Drawing.Point(341, 386);
            this.CPF.Name = "CPF";
            this.CPF.Size = new System.Drawing.Size(77, 31);
            this.CPF.TabIndex = 40;
            this.CPF.Text = "CPF:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lbl_NomeUser);
            this.panel2.Controls.Add(this.lbl_Inicio);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(325, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1097, 103);
            this.panel2.TabIndex = 39;
            // 
            // lbl_NomeUser
            // 
            this.lbl_NomeUser.AutoSize = true;
            this.lbl_NomeUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NomeUser.Location = new System.Drawing.Point(169, 34);
            this.lbl_NomeUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_NomeUser.Name = "lbl_NomeUser";
            this.lbl_NomeUser.Size = new System.Drawing.Size(0, 25);
            this.lbl_NomeUser.TabIndex = 7;
            // 
            // txtNome
            // 
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(347, 325);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(457, 41);
            this.txtNome.TabIndex = 33;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(887, 526);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(457, 41);
            this.txtEmail.TabIndex = 35;
            // 
            // lblNome
            // 
            this.lblNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(341, 277);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(101, 31);
            this.lblNome.TabIndex = 30;
            this.lblNome.Text = "Nome: ";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(881, 486);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 36);
            this.label2.TabIndex = 31;
            this.label2.Text = "Email:";
            // 
            // btnCadastroCancel
            // 
            this.btnCadastroCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCadastroCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroCancel.Location = new System.Drawing.Point(1176, 1113);
            this.btnCadastroCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCadastroCancel.Name = "btnCadastroCancel";
            this.btnCadastroCancel.Size = new System.Drawing.Size(173, 69);
            this.btnCadastroCancel.TabIndex = 38;
            this.btnCadastroCancel.Text = "Cancelar";
            this.btnCadastroCancel.UseVisualStyleBackColor = true;
            // 
            // txtCadastroSenha
            // 
            this.txtCadastroSenha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtCadastroSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCadastroSenha.Location = new System.Drawing.Point(887, 731);
            this.txtCadastroSenha.Margin = new System.Windows.Forms.Padding(4);
            this.txtCadastroSenha.Name = "txtCadastroSenha";
            this.txtCadastroSenha.Size = new System.Drawing.Size(457, 41);
            this.txtCadastroSenha.TabIndex = 36;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.PctBox_Logo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 977);
            this.panel1.TabIndex = 34;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnCadastroAdd
            // 
            this.btnCadastroAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCadastroAdd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCadastroAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroAdd.Location = new System.Drawing.Point(1394, 1113);
            this.btnCadastroAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnCadastroAdd.Name = "btnCadastroAdd";
            this.btnCadastroAdd.Size = new System.Drawing.Size(173, 69);
            this.btnCadastroAdd.TabIndex = 37;
            this.btnCadastroAdd.Text = "Adicionar novo usuario";
            this.btnCadastroAdd.UseVisualStyleBackColor = false;
            // 
            // lblCadastroSenha
            // 
            this.lblCadastroSenha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblCadastroSenha.AutoSize = true;
            this.lblCadastroSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroSenha.Location = new System.Drawing.Point(881, 681);
            this.lblCadastroSenha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCadastroSenha.Name = "lblCadastroSenha";
            this.lblCadastroSenha.Size = new System.Drawing.Size(117, 36);
            this.lblCadastroSenha.TabIndex = 32;
            this.lblCadastroSenha.Text = "Senha: ";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(349, 136);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(341, 46);
            this.label12.TabIndex = 55;
            this.label12.Text = "Edição de usuario";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.btnSalvar.Location = new System.Drawing.Point(1171, 897);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(173, 69);
            this.btnSalvar.TabIndex = 63;
            this.btnSalvar.Text = "Salvar Alterações";
            this.btnSalvar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(949, 897);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(173, 69);
            this.btnCancelar.TabIndex = 64;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnAlterarSenha
            // 
            this.btnAlterarSenha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAlterarSenha.BackColor = System.Drawing.Color.DarkGray;
            this.btnAlterarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarSenha.Location = new System.Drawing.Point(1181, 794);
            this.btnAlterarSenha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAlterarSenha.Name = "btnAlterarSenha";
            this.btnAlterarSenha.Size = new System.Drawing.Size(163, 46);
            this.btnAlterarSenha.TabIndex = 65;
            this.btnAlterarSenha.Text = "Alterar senha";
            this.btnAlterarSenha.UseVisualStyleBackColor = false;
            // 
            // lbl_Inicio
            // 
            this.lbl_Inicio.AutoSize = true;
            this.lbl_Inicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Inicio.Image = global::Gerenciamento_De_Chamados.Properties.Resources.HOME__2_;
            this.lbl_Inicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Inicio.Location = new System.Drawing.Point(49, 34);
            this.lbl_Inicio.Name = "lbl_Inicio";
            this.lbl_Inicio.Size = new System.Drawing.Size(120, 31);
            this.lbl_Inicio.TabIndex = 2;
            this.lbl_Inicio.Text = "      Início";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.Image = global::Gerenciamento_De_Chamados.Properties.Resources.account_circle_51dp_000000_FILL0_wght400_GRAD0_opsz48__1_;
            this.pictureBox4.Location = new System.Drawing.Point(1036, 12);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(51, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = global::Gerenciamento_De_Chamados.Properties.Resources.contact_support_24dp_000000_FILL0_wght400_GRAD0_opsz24;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(12, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "      FAQ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::Gerenciamento_De_Chamados.Properties.Resources.menu_24dp_000000_FILL0_wght400_GRAD0_opsz24__1_;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(12, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "      Meus Chamados";
            // 
            // PctBox_Logo
            // 
            this.PctBox_Logo.Image = ((System.Drawing.Image)(resources.GetObject("PctBox_Logo.Image")));
            this.PctBox_Logo.Location = new System.Drawing.Point(-35, -57);
            this.PctBox_Logo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PctBox_Logo.Name = "PctBox_Logo";
            this.PctBox_Logo.Size = new System.Drawing.Size(393, 298);
            this.PctBox_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PctBox_Logo.TabIndex = 10;
            this.PctBox_Logo.TabStop = false;
            // 
            // Editar_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 977);
            this.Controls.Add(this.btnAlterarSenha);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cmbFuncao);
            this.Controls.Add(this.txtSetor);
            this.Controls.Add(this.txtRG);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbSexo);
            this.Controls.Add(this.dtpDataNascimento);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.CPF);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCadastroCancel);
            this.Controls.Add(this.txtCadastroSenha);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCadastroAdd);
            this.Controls.Add(this.lblCadastroSenha);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Editar_Usuario";
            this.Text = "Editar_Usuarios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctBox_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbFuncao;
        private System.Windows.Forms.ComboBox txtSetor;
        private System.Windows.Forms.TextBox txtRG;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.DateTimePicker dtpDataNascimento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Label CPF;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_NomeUser;
        private System.Windows.Forms.Label lbl_Inicio;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCadastroCancel;
        private System.Windows.Forms.TextBox txtCadastroSenha;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PctBox_Logo;
        private System.Windows.Forms.Button btnCadastroAdd;
        private System.Windows.Forms.Label lblCadastroSenha;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAlterarSenha;
    }
}
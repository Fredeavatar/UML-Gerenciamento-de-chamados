namespace Appparalogin
{
    partial class MenuRestrito
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
            this.btnCadastroUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadastroUser
            // 
            this.btnCadastroUser.Location = new System.Drawing.Point(248, 122);
            this.btnCadastroUser.Name = "btnCadastroUser";
            this.btnCadastroUser.Size = new System.Drawing.Size(230, 100);
            this.btnCadastroUser.TabIndex = 0;
            this.btnCadastroUser.Text = "Cadastrar novo usuario";
            this.btnCadastroUser.UseVisualStyleBackColor = true;
            this.btnCadastroUser.Click += new System.EventHandler(this.btnCadastroUser_Click);
            // 
            // MenuRestrito
            // 
            this.ClientSize = new System.Drawing.Size(739, 423);
            this.Controls.Add(this.btnCadastroUser);
            this.Name = "MenuRestrito";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrarUsers;
        private System.Windows.Forms.Button btnCadastroUser;
    }
}
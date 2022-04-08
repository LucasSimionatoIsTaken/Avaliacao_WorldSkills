namespace WSTowers.WindowsForms
{
    partial class Login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.UsuarioLbl = new System.Windows.Forms.Label();
            this.SenhaLbl = new System.Windows.Forms.Label();
            this.Usuario = new System.Windows.Forms.TextBox();
            this.Senha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UsuarioLbl
            // 
            this.UsuarioLbl.AutoSize = true;
            this.UsuarioLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.UsuarioLbl.Location = new System.Drawing.Point(273, 153);
            this.UsuarioLbl.Name = "UsuarioLbl";
            this.UsuarioLbl.Size = new System.Drawing.Size(57, 17);
            this.UsuarioLbl.TabIndex = 0;
            this.UsuarioLbl.Text = "Usuario";
            // 
            // SenhaLbl
            // 
            this.SenhaLbl.AutoSize = true;
            this.SenhaLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SenhaLbl.Location = new System.Drawing.Point(273, 193);
            this.SenhaLbl.Name = "SenhaLbl";
            this.SenhaLbl.Size = new System.Drawing.Size(49, 17);
            this.SenhaLbl.TabIndex = 0;
            this.SenhaLbl.Text = "Senha";
            // 
            // Usuario
            // 
            this.Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Usuario.Location = new System.Drawing.Point(351, 150);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(100, 23);
            this.Usuario.TabIndex = 1;
            // 
            // Senha
            // 
            this.Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Senha.Location = new System.Drawing.Point(351, 190);
            this.Senha.Name = "Senha";
            this.Senha.Size = new System.Drawing.Size(100, 23);
            this.Senha.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(347, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Login";
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(341, 236);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(75, 23);
            this.LoginBtn.TabIndex = 3;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Senha);
            this.Controls.Add(this.Usuario);
            this.Controls.Add(this.SenhaLbl);
            this.Controls.Add(this.UsuarioLbl);
            this.Name = "Login";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UsuarioLbl;
        private System.Windows.Forms.Label SenhaLbl;
        private System.Windows.Forms.TextBox Usuario;
        private System.Windows.Forms.TextBox Senha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LoginBtn;
    }
}


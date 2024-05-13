namespace GestorDeEstudantesT7
{
    partial class Login_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.MaskedTextBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.pictureBoxUsuario = new System.Windows.Forms.PictureBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Location = new System.Drawing.Point(199, 181);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.PasswordChar = '*';
            this.textBoxSenha.Size = new System.Drawing.Size(137, 20);
            this.textBoxSenha.TabIndex = 0;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(199, 129);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(137, 20);
            this.textBoxNome.TabIndex = 1;
            this.textBoxNome.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.textBoxNome_MaskInputRejected);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(236, 311);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(100, 90);
            this.buttonCancelar.TabIndex = 2;
            this.buttonCancelar.Text = "CANCELAR";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(49, 311);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(100, 90);
            this.buttonLogin.TabIndex = 3;
            this.buttonLogin.Text = "LOGIN";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // pictureBoxUsuario
            // 
            this.pictureBoxUsuario.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUsuario.Image")));
            this.pictureBoxUsuario.Location = new System.Drawing.Point(29, 105);
            this.pictureBoxUsuario.Name = "pictureBoxUsuario";
            this.pictureBoxUsuario.Size = new System.Drawing.Size(136, 123);
            this.pictureBoxUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUsuario.TabIndex = 4;
            this.pictureBoxUsuario.TabStop = false;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(145, 69);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(74, 20);
            this.Label1.TabIndex = 5;
            this.Label1.Text = "Acessar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Usuário";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Senha";
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.pictureBoxUsuario);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.textBoxSenha);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.MaskedTextBox textBoxNome;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.PictureBox pictureBoxUsuario;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}


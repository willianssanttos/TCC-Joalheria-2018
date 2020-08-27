namespace GUI
{
    partial class frmCadastroUsuario
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtGrupo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.iconeencerar = new System.Windows.Forms.PictureBox();
            this.pnDados.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconeencerar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnDados
            // 
            this.pnDados.Controls.Add(this.txtGrupo);
            this.pnDados.Controls.Add(this.label8);
            this.pnDados.Controls.Add(this.txtSenha);
            this.pnDados.Controls.Add(this.txtLogin);
            this.pnDados.Controls.Add(this.txtNome);
            this.pnDados.Controls.Add(this.txtCodigo);
            this.pnDados.Controls.Add(this.label4);
            this.pnDados.Controls.Add(this.label3);
            this.pnDados.Controls.Add(this.label2);
            this.pnDados.Controls.Add(this.label1);
            this.pnDados.Location = new System.Drawing.Point(3, 52);
            this.pnDados.Size = new System.Drawing.Size(852, 290);
            // 
            // pnBotoes
            // 
            this.pnBotoes.Location = new System.Drawing.Point(3, 348);
            this.pnBotoes.Size = new System.Drawing.Size(852, 104);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(725, 16);
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(587, 16);
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(449, 16);
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Location = new System.Drawing.Point(311, 16);
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btLocalizar
            // 
            this.btLocalizar.Location = new System.Drawing.Point(173, 16);
            this.btLocalizar.Click += new System.EventHandler(this.btLocalizar_Click);
            // 
            // btInserir
            // 
            this.btInserir.Click += new System.EventHandler(this.btInserir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Login";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Senha";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(35, 29);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(121, 20);
            this.txtCodigo.TabIndex = 6;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(35, 78);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(800, 20);
            this.txtNome.TabIndex = 7;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(35, 138);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(800, 20);
            this.txtLogin.TabIndex = 8;
            this.txtLogin.Leave += new System.EventHandler(this.txtLogin_Leave);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(35, 247);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(800, 20);
            this.txtSenha.TabIndex = 9;
            // 
            // txtGrupo
            // 
            this.txtGrupo.Location = new System.Drawing.Point(35, 195);
            this.txtGrupo.Name = "txtGrupo";
            this.txtGrupo.Size = new System.Drawing.Size(800, 20);
            this.txtGrupo.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Grupo de Usúario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(11)))), ((int)(((byte)(83)))));
            this.label5.Location = new System.Drawing.Point(295, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(228, 25);
            this.label5.TabIndex = 50;
            this.label5.Text = "Cadastro de Usúario";
            // 
            // iconeencerar
            // 
            this.iconeencerar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconeencerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconeencerar.Image = global::GUI.Properties.Resources.icon_cerrar2;
            this.iconeencerar.Location = new System.Drawing.Point(833, 12);
            this.iconeencerar.Name = "iconeencerar";
            this.iconeencerar.Size = new System.Drawing.Size(15, 15);
            this.iconeencerar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconeencerar.TabIndex = 49;
            this.iconeencerar.TabStop = false;
            this.iconeencerar.Click += new System.EventHandler(this.iconeencerar_Click);
            // 
            // frmCadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(860, 464);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.iconeencerar);
            this.Name = "frmCadastroUsuario";
            this.Text = "Cadastro de Usuario";
            this.Load += new System.EventHandler(this.frmCadastroUsuario_Load);
            this.Controls.SetChildIndex(this.pnDados, 0);
            this.Controls.SetChildIndex(this.pnBotoes, 0);
            this.Controls.SetChildIndex(this.iconeencerar, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            this.pnBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconeencerar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGrupo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox iconeencerar;
    }
}

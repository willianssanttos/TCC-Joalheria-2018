namespace GUI
{
    partial class frmEnviarEmail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEnviarEmail));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtPara = new System.Windows.Forms.TextBox();
            this.txtAssunto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAnexar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMensagem = new System.Windows.Forms.RichTextBox();
            this.btnEnviar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnAnexar = new Bunifu.Framework.UI.BunifuImageButton();
            this.label5 = new System.Windows.Forms.Label();
            this.iconeencerar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnAnexar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconeencerar)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Para:";
            // 
            // txtPara
            // 
            this.txtPara.Location = new System.Drawing.Point(109, 74);
            this.txtPara.Name = "txtPara";
            this.txtPara.Size = new System.Drawing.Size(411, 20);
            this.txtPara.TabIndex = 3;
            // 
            // txtAssunto
            // 
            this.txtAssunto.Location = new System.Drawing.Point(109, 120);
            this.txtAssunto.Name = "txtAssunto";
            this.txtAssunto.Size = new System.Drawing.Size(411, 20);
            this.txtAssunto.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Assunto:";
            // 
            // txtAnexar
            // 
            this.txtAnexar.Enabled = false;
            this.txtAnexar.Location = new System.Drawing.Point(109, 164);
            this.txtAnexar.Name = "txtAnexar";
            this.txtAnexar.Size = new System.Drawing.Size(340, 20);
            this.txtAnexar.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Anexar:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mensagem:";
            // 
            // txtMensagem
            // 
            this.txtMensagem.Location = new System.Drawing.Point(28, 232);
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(493, 136);
            this.txtMensagem.TabIndex = 9;
            this.txtMensagem.Text = "";
            // 
            // btnEnviar
            // 
            this.btnEnviar.ActiveBorderThickness = 1;
            this.btnEnviar.ActiveCornerRadius = 20;
            this.btnEnviar.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnEnviar.ActiveForecolor = System.Drawing.Color.White;
            this.btnEnviar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnEnviar.BackColor = System.Drawing.Color.White;
            this.btnEnviar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEnviar.BackgroundImage")));
            this.btnEnviar.ButtonText = "Enviar";
            this.btnEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(11)))), ((int)(((byte)(83)))));
            this.btnEnviar.IdleBorderThickness = 1;
            this.btnEnviar.IdleCornerRadius = 20;
            this.btnEnviar.IdleFillColor = System.Drawing.Color.White;
            this.btnEnviar.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(11)))), ((int)(((byte)(83)))));
            this.btnEnviar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(11)))), ((int)(((byte)(83)))));
            this.btnEnviar.Location = new System.Drawing.Point(397, 376);
            this.btnEnviar.Margin = new System.Windows.Forms.Padding(5);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(123, 42);
            this.btnEnviar.TabIndex = 1;
            this.btnEnviar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnAnexar
            // 
            this.btnAnexar.BackColor = System.Drawing.Color.White;
            this.btnAnexar.Image = global::GUI.Properties.Resources.kisspng_computer_icons_drawing_pin_clip_art_paper_clips_5afd0e0124f224_8988735615265336331513;
            this.btnAnexar.ImageActive = null;
            this.btnAnexar.Location = new System.Drawing.Point(455, 152);
            this.btnAnexar.Name = "btnAnexar";
            this.btnAnexar.Size = new System.Drawing.Size(65, 32);
            this.btnAnexar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAnexar.TabIndex = 0;
            this.btnAnexar.TabStop = false;
            this.btnAnexar.Zoom = 10;
            this.btnAnexar.Click += new System.EventHandler(this.btnAnexar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(11)))), ((int)(((byte)(83)))));
            this.label5.Location = new System.Drawing.Point(140, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(277, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Enviar email para Cliente";
            // 
            // iconeencerar
            // 
            this.iconeencerar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconeencerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconeencerar.Image = global::GUI.Properties.Resources.icon_cerrar2;
            this.iconeencerar.Location = new System.Drawing.Point(507, 12);
            this.iconeencerar.Name = "iconeencerar";
            this.iconeencerar.Size = new System.Drawing.Size(15, 15);
            this.iconeencerar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconeencerar.TabIndex = 47;
            this.iconeencerar.TabStop = false;
            this.iconeencerar.Click += new System.EventHandler(this.iconeencerar_Click);
            // 
            // frmEnviarEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(534, 432);
            this.Controls.Add(this.iconeencerar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMensagem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAnexar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAssunto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPara);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.btnAnexar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEnviarEmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEnviarEmail";
            ((System.ComponentModel.ISupportInitialize)(this.btnAnexar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconeencerar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuImageButton btnAnexar;
        private System.Windows.Forms.RichTextBox txtMensagem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAnexar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAssunto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPara;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnEnviar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox iconeencerar;
    }
}
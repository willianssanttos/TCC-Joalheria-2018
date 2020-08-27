namespace GUI
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelLeft = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.Cancelar = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEntrar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label7 = new System.Windows.Forms.Label();
            this.chkMostrar = new Bunifu.Framework.UI.BunifuCheckbox();
            this.txtUsuario = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtSenha = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panelRight = new System.Windows.Forms.Panel();
            this.panelLeft.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 35;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(11)))), ((int)(((byte)(83)))));
            this.panelLeft.Controls.Add(this.bunifuCustomLabel1);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(321, 543);
            this.panelLeft.TabIndex = 1;
            this.panelLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelLeft_MouseDown);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Monotype Corsiva", 150F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(12, 146);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(292, 242);
            this.bunifuCustomLabel1.TabIndex = 3;
            this.bunifuCustomLabel1.Text = "PJ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(11)))), ((int)(((byte)(83)))));
            this.label2.Location = new System.Drawing.Point(94, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Faça o login!";
            // 
            // Cancelar
            // 
            this.Cancelar.AutoSize = true;
            this.Cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(11)))), ((int)(((byte)(83)))));
            this.Cancelar.Location = new System.Drawing.Point(309, 2);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(24, 29);
            this.Cancelar.TabIndex = 0;
            this.Cancelar.Text = "x";
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(11)))), ((int)(((byte)(83)))));
            this.label3.Location = new System.Drawing.Point(17, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Usuário:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(11)))), ((int)(((byte)(83)))));
            this.label4.Location = new System.Drawing.Point(17, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Senha:";
            // 
            // btnEntrar
            // 
            this.btnEntrar.ActiveBorderThickness = 1;
            this.btnEntrar.ActiveCornerRadius = 20;
            this.btnEntrar.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(11)))), ((int)(((byte)(83)))));
            this.btnEntrar.ActiveForecolor = System.Drawing.Color.White;
            this.btnEntrar.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(11)))), ((int)(((byte)(83)))));
            this.btnEntrar.BackColor = System.Drawing.Color.White;
            this.btnEntrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEntrar.BackgroundImage")));
            this.btnEntrar.ButtonText = "Entrar";
            this.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.ForeColor = System.Drawing.Color.White;
            this.btnEntrar.IdleBorderThickness = 1;
            this.btnEntrar.IdleCornerRadius = 20;
            this.btnEntrar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(11)))), ((int)(((byte)(83)))));
            this.btnEntrar.IdleForecolor = System.Drawing.Color.White;
            this.btnEntrar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(11)))), ((int)(((byte)(83)))));
            this.btnEntrar.Location = new System.Drawing.Point(21, 431);
            this.btnEntrar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(297, 42);
            this.btnEntrar.TabIndex = 15;
            this.btnEntrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(11)))), ((int)(((byte)(83)))));
            this.label7.Location = new System.Drawing.Point(119, 382);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Mostrar Senha";
            // 
            // chkMostrar
            // 
            this.chkMostrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(11)))), ((int)(((byte)(83)))));
            this.chkMostrar.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(11)))), ((int)(((byte)(83)))));
            this.chkMostrar.Checked = false;
            this.chkMostrar.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(11)))), ((int)(((byte)(83)))));
            this.chkMostrar.ForeColor = System.Drawing.Color.White;
            this.chkMostrar.Location = new System.Drawing.Point(93, 382);
            this.chkMostrar.Name = "chkMostrar";
            this.chkMostrar.Size = new System.Drawing.Size(20, 20);
            this.chkMostrar.TabIndex = 17;
            this.chkMostrar.OnChange += new System.EventHandler(this.chkMostrar_OnChange);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUsuario.HintForeColor = System.Drawing.Color.Empty;
            this.txtUsuario.HintText = "Nome";
            this.txtUsuario.isPassword = false;
            this.txtUsuario.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(11)))), ((int)(((byte)(83)))));
            this.txtUsuario.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(11)))), ((int)(((byte)(83)))));
            this.txtUsuario.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(11)))), ((int)(((byte)(83)))));
            this.txtUsuario.LineThickness = 3;
            this.txtUsuario.Location = new System.Drawing.Point(21, 251);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(297, 37);
            this.txtUsuario.TabIndex = 19;
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // txtSenha
            // 
            this.txtSenha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSenha.HintForeColor = System.Drawing.Color.Empty;
            this.txtSenha.HintText = "";
            this.txtSenha.isPassword = true;
            this.txtSenha.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(11)))), ((int)(((byte)(83)))));
            this.txtSenha.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(11)))), ((int)(((byte)(83)))));
            this.txtSenha.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(11)))), ((int)(((byte)(83)))));
            this.txtSenha.LineThickness = 3;
            this.txtSenha.Location = new System.Drawing.Point(21, 328);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(4);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(297, 31);
            this.txtSenha.TabIndex = 18;
            this.txtSenha.Text = "Password";
            this.txtSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.White;
            this.panelRight.Controls.Add(this.txtSenha);
            this.panelRight.Controls.Add(this.txtUsuario);
            this.panelRight.Controls.Add(this.chkMostrar);
            this.panelRight.Controls.Add(this.label7);
            this.panelRight.Controls.Add(this.btnEntrar);
            this.panelRight.Controls.Add(this.label4);
            this.panelRight.Controls.Add(this.label3);
            this.panelRight.Controls.Add(this.Cancelar);
            this.panelRight.Controls.Add(this.label2);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(321, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(344, 543);
            this.panelRight.TabIndex = 2;
            // 
            // frmLogar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 543);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogar";
            this.Load += new System.EventHandler(this.frmLogar_Load);
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panelLeft;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Panel panelRight;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSenha;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtUsuario;
        private Bunifu.Framework.UI.BunifuCheckbox chkMostrar;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuThinButton2 btnEntrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Cancelar;
        private System.Windows.Forms.Label label2;
    }
}
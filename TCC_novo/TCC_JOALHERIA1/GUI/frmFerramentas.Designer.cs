namespace GUI
{
    partial class frmFerramentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFerramentas));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.conf = new System.Windows.Forms.Button();
            this.backup = new System.Windows.Forms.Button();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.iconeencerar = new System.Windows.Forms.PictureBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.pnCadastros = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconeencerar)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 45;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(11)))), ((int)(((byte)(83)))));
            this.panel1.Controls.Add(this.conf);
            this.panel1.Controls.Add(this.backup);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(169, 520);
            this.panel1.TabIndex = 3;
            // 
            // conf
            // 
            this.conf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.conf.FlatAppearance.BorderSize = 0;
            this.conf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.conf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conf.ForeColor = System.Drawing.Color.White;
            this.conf.Location = new System.Drawing.Point(0, 211);
            this.conf.Name = "conf";
            this.conf.Size = new System.Drawing.Size(169, 50);
            this.conf.TabIndex = 3;
            this.conf.Text = "    Configuraçao do banco";
            this.conf.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.conf.UseVisualStyleBackColor = true;
            this.conf.Click += new System.EventHandler(this.conf_Click);
            // 
            // backup
            // 
            this.backup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backup.FlatAppearance.BorderSize = 0;
            this.backup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backup.ForeColor = System.Drawing.Color.White;
            this.backup.Location = new System.Drawing.Point(0, 155);
            this.backup.Name = "backup";
            this.backup.Size = new System.Drawing.Size(169, 50);
            this.backup.TabIndex = 4;
            this.backup.Text = "    Backup e Restauração";
            this.backup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.backup.UseVisualStyleBackColor = true;
            this.backup.Click += new System.EventHandler(this.backup_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Monotype Corsiva", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(12, 9);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(142, 117);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "PJ";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(11)))), ((int)(((byte)(83)))));
            this.panelHeader.Controls.Add(this.iconeencerar);
            this.panelHeader.Controls.Add(this.labelTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(169, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(658, 50);
            this.panelHeader.TabIndex = 5;
            // 
            // iconeencerar
            // 
            this.iconeencerar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconeencerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconeencerar.Image = ((System.Drawing.Image)(resources.GetObject("iconeencerar.Image")));
            this.iconeencerar.Location = new System.Drawing.Point(631, 19);
            this.iconeencerar.Name = "iconeencerar";
            this.iconeencerar.Size = new System.Drawing.Size(15, 15);
            this.iconeencerar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconeencerar.TabIndex = 9;
            this.iconeencerar.TabStop = false;
            this.iconeencerar.Click += new System.EventHandler(this.iconeencerar_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelTitle.Location = new System.Drawing.Point(6, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(179, 31);
            this.labelTitle.TabIndex = 5;
            this.labelTitle.Text = "Ferramentas";
            // 
            // pnCadastros
            // 
            this.pnCadastros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnCadastros.Location = new System.Drawing.Point(169, 50);
            this.pnCadastros.Name = "pnCadastros";
            this.pnCadastros.Size = new System.Drawing.Size(658, 470);
            this.pnCadastros.TabIndex = 5;
            // 
            // frmFerramentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(827, 520);
            this.Controls.Add(this.pnCadastros);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFerramentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFerramentas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconeencerar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button conf;
        private System.Windows.Forms.Button backup;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Panel pnCadastros;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox iconeencerar;
        private System.Windows.Forms.Label labelTitle;
    }
}
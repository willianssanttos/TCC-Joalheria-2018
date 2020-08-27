namespace GUI
{
    partial class frmRelatorios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelatorios));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHora = new System.Windows.Forms.Label();
            this.pagaRecebe = new System.Windows.Forms.Button();
            this.pagaCompra = new System.Windows.Forms.Button();
            this.reEstoque = new System.Windows.Forms.Button();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.iconerestaurar = new System.Windows.Forms.PictureBox();
            this.iconeencerar = new System.Windows.Forms.PictureBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.iconeminizar = new System.Windows.Forms.PictureBox();
            this.iconemaxizar = new System.Windows.Forms.PictureBox();
            this.pnCadastros = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconerestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconeencerar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconeminizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconemaxizar)).BeginInit();
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
            this.panel1.Controls.Add(this.lblHora);
            this.panel1.Controls.Add(this.pagaRecebe);
            this.panel1.Controls.Add(this.pagaCompra);
            this.panel1.Controls.Add(this.reEstoque);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(169, 613);
            this.panel1.TabIndex = 3;
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.SystemColors.Control;
            this.lblHora.Location = new System.Drawing.Point(3, 555);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(96, 39);
            this.lblHora.TabIndex = 11;
            this.lblHora.Text = "Hora";
            // 
            // pagaRecebe
            // 
            this.pagaRecebe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pagaRecebe.FlatAppearance.BorderSize = 0;
            this.pagaRecebe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pagaRecebe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pagaRecebe.ForeColor = System.Drawing.Color.White;
            this.pagaRecebe.Location = new System.Drawing.Point(0, 282);
            this.pagaRecebe.Name = "pagaRecebe";
            this.pagaRecebe.Size = new System.Drawing.Size(169, 50);
            this.pagaRecebe.TabIndex = 8;
            this.pagaRecebe.Text = "    Relatório de Vendas";
            this.pagaRecebe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.pagaRecebe.UseVisualStyleBackColor = true;
            this.pagaRecebe.Click += new System.EventHandler(this.pagaRecebe_Click);
            // 
            // pagaCompra
            // 
            this.pagaCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pagaCompra.FlatAppearance.BorderSize = 0;
            this.pagaCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pagaCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pagaCompra.ForeColor = System.Drawing.Color.White;
            this.pagaCompra.Location = new System.Drawing.Point(0, 211);
            this.pagaCompra.Name = "pagaCompra";
            this.pagaCompra.Size = new System.Drawing.Size(169, 50);
            this.pagaCompra.TabIndex = 3;
            this.pagaCompra.Text = "    Relatório de Produto";
            this.pagaCompra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.pagaCompra.UseVisualStyleBackColor = true;
            this.pagaCompra.Click += new System.EventHandler(this.pagaCompra_Click);
            // 
            // reEstoque
            // 
            this.reEstoque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reEstoque.FlatAppearance.BorderSize = 0;
            this.reEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reEstoque.ForeColor = System.Drawing.Color.White;
            this.reEstoque.Location = new System.Drawing.Point(0, 155);
            this.reEstoque.Name = "reEstoque";
            this.reEstoque.Size = new System.Drawing.Size(169, 50);
            this.reEstoque.TabIndex = 4;
            this.reEstoque.Text = "    Relatório Estoque";
            this.reEstoque.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.reEstoque.UseVisualStyleBackColor = true;
            this.reEstoque.Click += new System.EventHandler(this.reEstoque_Click);
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
            this.panelHeader.Controls.Add(this.iconerestaurar);
            this.panelHeader.Controls.Add(this.iconeencerar);
            this.panelHeader.Controls.Add(this.labelTitle);
            this.panelHeader.Controls.Add(this.iconeminizar);
            this.panelHeader.Controls.Add(this.iconemaxizar);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(169, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(874, 50);
            this.panelHeader.TabIndex = 5;
            // 
            // iconerestaurar
            // 
            this.iconerestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconerestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            
            this.iconerestaurar.Location = new System.Drawing.Point(817, 19);
            this.iconerestaurar.Name = "iconerestaurar";
            this.iconerestaurar.Size = new System.Drawing.Size(15, 15);
            this.iconerestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconerestaurar.TabIndex = 7;
            this.iconerestaurar.TabStop = false;
            this.iconerestaurar.Visible = false;
            this.iconerestaurar.Click += new System.EventHandler(this.iconerestaurar_Click);
            // 
            // iconeencerar
            // 
            this.iconeencerar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconeencerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconeencerar.Image = ((System.Drawing.Image)(resources.GetObject("iconeencerar.Image")));
            this.iconeencerar.Location = new System.Drawing.Point(847, 19);
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
            this.labelTitle.Size = new System.Drawing.Size(217, 31);
            this.labelTitle.TabIndex = 5;
            this.labelTitle.Text = "Movimentações";
            // 
            // iconeminizar
            // 
            this.iconeminizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconeminizar.Cursor = System.Windows.Forms.Cursors.Hand;
          
            this.iconeminizar.Location = new System.Drawing.Point(787, 19);
            this.iconeminizar.Name = "iconeminizar";
            this.iconeminizar.Size = new System.Drawing.Size(15, 15);
            this.iconeminizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconeminizar.TabIndex = 8;
            this.iconeminizar.TabStop = false;
            this.iconeminizar.Click += new System.EventHandler(this.iconeminizar_Click);
            // 
            // iconemaxizar
            // 
            this.iconemaxizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconemaxizar.Cursor = System.Windows.Forms.Cursors.Hand;
            
            this.iconemaxizar.Location = new System.Drawing.Point(817, 19);
            this.iconemaxizar.Name = "iconemaxizar";
            this.iconemaxizar.Size = new System.Drawing.Size(15, 15);
            this.iconemaxizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconemaxizar.TabIndex = 6;
            this.iconemaxizar.TabStop = false;
            this.iconemaxizar.Click += new System.EventHandler(this.iconemaxizar_Click);
            // 
            // pnCadastros
            // 
            this.pnCadastros.BackColor = System.Drawing.Color.White;
            this.pnCadastros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnCadastros.Location = new System.Drawing.Point(169, 50);
            this.pnCadastros.Name = "pnCadastros";
            this.pnCadastros.Size = new System.Drawing.Size(874, 563);
            this.pnCadastros.TabIndex = 7;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1043, 613);
            this.Controls.Add(this.pnCadastros);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRelatorios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRelatorios";
            this.Load += new System.EventHandler(this.frmRelatorios_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconerestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconeencerar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconeminizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconemaxizar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Button pagaRecebe;
        private System.Windows.Forms.Button pagaCompra;
        private System.Windows.Forms.Button reEstoque;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox iconerestaurar;
        private System.Windows.Forms.PictureBox iconeencerar;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox iconeminizar;
        private System.Windows.Forms.PictureBox iconemaxizar;
        private System.Windows.Forms.Panel pnCadastros;
        private System.Windows.Forms.Timer timer1;
    }
}
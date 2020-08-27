namespace GUI
{
    partial class frmMovimentacaoEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMovimentacaoEstoque));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.cadUnidade = new System.Windows.Forms.Button();
            this.cadSub = new System.Windows.Forms.Button();
            this.cadCategoria = new System.Windows.Forms.Button();
            this.cadProduto = new System.Windows.Forms.Button();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.iconerestaurar = new System.Windows.Forms.PictureBox();
            this.iconeencerar = new System.Windows.Forms.PictureBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.iconeminizar = new System.Windows.Forms.PictureBox();
            this.iconemaxizar = new System.Windows.Forms.PictureBox();
            this.pnCadastros = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblHora = new System.Windows.Forms.Label();
            this.cadFornecedor = new System.Windows.Forms.Button();
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
            this.panel1.Controls.Add(this.cadFornecedor);
            this.panel1.Controls.Add(this.lblHora);
            this.panel1.Controls.Add(this.cadUnidade);
            this.panel1.Controls.Add(this.cadSub);
            this.panel1.Controls.Add(this.cadCategoria);
            this.panel1.Controls.Add(this.cadProduto);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(169, 613);
            this.panel1.TabIndex = 1;
            // 
            // cadUnidade
            // 
            this.cadUnidade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cadUnidade.FlatAppearance.BorderSize = 0;
            this.cadUnidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cadUnidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadUnidade.ForeColor = System.Drawing.Color.White;
            this.cadUnidade.Image = ((System.Drawing.Image)(resources.GetObject("cadUnidade.Image")));
            this.cadUnidade.Location = new System.Drawing.Point(0, 379);
            this.cadUnidade.Name = "cadUnidade";
            this.cadUnidade.Size = new System.Drawing.Size(169, 56);
            this.cadUnidade.TabIndex = 9;
            this.cadUnidade.Text = "    Cadastro de Unidade de Medida";
            this.cadUnidade.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cadUnidade.UseVisualStyleBackColor = true;
            this.cadUnidade.Click += new System.EventHandler(this.cadUnidade_Click);
            // 
            // cadSub
            // 
            this.cadSub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cadSub.FlatAppearance.BorderSize = 0;
            this.cadSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cadSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadSub.ForeColor = System.Drawing.Color.White;
            this.cadSub.Image = ((System.Drawing.Image)(resources.GetObject("cadSub.Image")));
            this.cadSub.Location = new System.Drawing.Point(0, 323);
            this.cadSub.Name = "cadSub";
            this.cadSub.Size = new System.Drawing.Size(169, 50);
            this.cadSub.TabIndex = 3;
            this.cadSub.Text = "    Cadastro de SubCategoria";
            this.cadSub.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cadSub.UseVisualStyleBackColor = true;
            this.cadSub.Click += new System.EventHandler(this.cadSub_Click);
            // 
            // cadCategoria
            // 
            this.cadCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cadCategoria.FlatAppearance.BorderSize = 0;
            this.cadCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cadCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadCategoria.ForeColor = System.Drawing.Color.White;
            this.cadCategoria.Image = ((System.Drawing.Image)(resources.GetObject("cadCategoria.Image")));
            this.cadCategoria.Location = new System.Drawing.Point(0, 267);
            this.cadCategoria.Name = "cadCategoria";
            this.cadCategoria.Size = new System.Drawing.Size(169, 50);
            this.cadCategoria.TabIndex = 8;
            this.cadCategoria.Text = "    Cadastro de Categoria ";
            this.cadCategoria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cadCategoria.UseVisualStyleBackColor = true;
            this.cadCategoria.Click += new System.EventHandler(this.cadCategoria_Click);
            // 
            // cadProduto
            // 
            this.cadProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cadProduto.FlatAppearance.BorderSize = 0;
            this.cadProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cadProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadProduto.ForeColor = System.Drawing.Color.White;
            this.cadProduto.Image = ((System.Drawing.Image)(resources.GetObject("cadProduto.Image")));
            this.cadProduto.Location = new System.Drawing.Point(0, 155);
            this.cadProduto.Name = "cadProduto";
            this.cadProduto.Size = new System.Drawing.Size(169, 50);
            this.cadProduto.TabIndex = 3;
            this.cadProduto.Text = "    Cadastro de Produto";
            this.cadProduto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cadProduto.UseVisualStyleBackColor = true;
            this.cadProduto.Click += new System.EventHandler(this.cadProduto_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Monotype Corsiva", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(12, 24);
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
            this.panelHeader.Size = new System.Drawing.Size(860, 50);
            this.panelHeader.TabIndex = 3;
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseDown);
            // 
            // iconerestaurar
            // 
            this.iconerestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconerestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconerestaurar.Location = new System.Drawing.Point(803, 14);
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
            this.iconeencerar.Location = new System.Drawing.Point(833, 14);
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
            this.labelTitle.Size = new System.Drawing.Size(121, 31);
            this.labelTitle.TabIndex = 5;
            this.labelTitle.Text = "Estoque";
            // 
            // iconeminizar
            // 
            this.iconeminizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconeminizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconeminizar.Location = new System.Drawing.Point(773, 14);
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
            this.iconemaxizar.Location = new System.Drawing.Point(803, 14);
            this.iconemaxizar.Name = "iconemaxizar";
            this.iconemaxizar.Size = new System.Drawing.Size(15, 15);
            this.iconemaxizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconemaxizar.TabIndex = 6;
            this.iconemaxizar.TabStop = false;
            this.iconemaxizar.Click += new System.EventHandler(this.iconemaxizar_Click);
            // 
            // pnCadastros
            // 
            this.pnCadastros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnCadastros.Location = new System.Drawing.Point(169, 50);
            this.pnCadastros.Name = "pnCadastros";
            this.pnCadastros.Size = new System.Drawing.Size(860, 563);
            this.pnCadastros.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.SystemColors.Control;
            this.lblHora.Location = new System.Drawing.Point(3, 556);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(96, 39);
            this.lblHora.TabIndex = 10;
            this.lblHora.Text = "Hora";
            // 
            // cadFornecedor
            // 
            this.cadFornecedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cadFornecedor.FlatAppearance.BorderSize = 0;
            this.cadFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cadFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadFornecedor.ForeColor = System.Drawing.Color.White;
            this.cadFornecedor.Image = ((System.Drawing.Image)(resources.GetObject("cadFornecedor.Image")));
            this.cadFornecedor.Location = new System.Drawing.Point(0, 211);
            this.cadFornecedor.Name = "cadFornecedor";
            this.cadFornecedor.Size = new System.Drawing.Size(169, 50);
            this.cadFornecedor.TabIndex = 4;
            this.cadFornecedor.Text = "  Cadastro de Fornecedor";
            this.cadFornecedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cadFornecedor.UseVisualStyleBackColor = true;
            this.cadFornecedor.Click += new System.EventHandler(this.cadFornecedor_Click);
            // 
            // frmMovimentacaoEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 613);
            this.Controls.Add(this.pnCadastros);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMovimentacaoEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMovimentacaoEstoque";
            this.Load += new System.EventHandler(this.frmMovimentacaoEstoque_Load);
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
        private System.Windows.Forms.Button cadUnidade;
        private System.Windows.Forms.Button cadSub;
        private System.Windows.Forms.Button cadCategoria;
        private System.Windows.Forms.Button cadProduto;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox iconerestaurar;
        private System.Windows.Forms.PictureBox iconeencerar;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox iconeminizar;
        private System.Windows.Forms.PictureBox iconemaxizar;
        private System.Windows.Forms.Panel pnCadastros;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button cadFornecedor;
        private System.Windows.Forms.Label lblHora;
    }
}
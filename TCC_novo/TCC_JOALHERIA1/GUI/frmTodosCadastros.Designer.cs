namespace GUI
{
    partial class frmTodosCadastros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTodosCadastros));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnCadas = new System.Windows.Forms.Panel();
            this.lblHora = new System.Windows.Forms.Label();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.pnCadastros = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.iconerestaurar = new System.Windows.Forms.PictureBox();
            this.iconeencerar = new System.Windows.Forms.PictureBox();
            this.iconeminizar = new System.Windows.Forms.PictureBox();
            this.iconemaxizar = new System.Windows.Forms.PictureBox();
            this.cadUnidade = new System.Windows.Forms.Button();
            this.cadSub = new System.Windows.Forms.Button();
            this.cadCategoria = new System.Windows.Forms.Button();
            this.cadProduto = new System.Windows.Forms.Button();
            this.pnCadas.SuspendLayout();
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
            // pnCadas
            // 
            this.pnCadas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(11)))), ((int)(((byte)(83)))));
            this.pnCadas.Controls.Add(this.cadUnidade);
            this.pnCadas.Controls.Add(this.cadSub);
            this.pnCadas.Controls.Add(this.cadCategoria);
            this.pnCadas.Controls.Add(this.cadProduto);
            this.pnCadas.Controls.Add(this.lblHora);
            this.pnCadas.Controls.Add(this.bunifuCustomLabel1);
            this.pnCadas.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnCadas.Location = new System.Drawing.Point(0, 0);
            this.pnCadas.Name = "pnCadas";
            this.pnCadas.Size = new System.Drawing.Size(175, 690);
            this.pnCadas.TabIndex = 0;
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.SystemColors.Control;
            this.lblHora.Location = new System.Drawing.Point(3, 642);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(96, 39);
            this.lblHora.TabIndex = 0;
            this.lblHora.Text = "Hora";
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
            this.panelHeader.Location = new System.Drawing.Point(175, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(916, 46);
            this.panelHeader.TabIndex = 2;
            this.panelHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHeader_Paint);
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseDown);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelTitle.Location = new System.Drawing.Point(18, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(145, 31);
            this.labelTitle.TabIndex = 5;
            this.labelTitle.Text = "Consultas";
            // 
            // pnCadastros
            // 
            this.pnCadastros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnCadastros.Location = new System.Drawing.Point(175, 46);
            this.pnCadastros.Name = "pnCadastros";
            this.pnCadastros.Size = new System.Drawing.Size(916, 632);
            this.pnCadastros.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // iconerestaurar
            // 
            this.iconerestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconerestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconerestaurar.Image = global::GUI.Properties.Resources.res;
            this.iconerestaurar.Location = new System.Drawing.Point(859, 16);
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
            this.iconeencerar.Image = global::GUI.Properties.Resources.cerrar;
            this.iconeencerar.Location = new System.Drawing.Point(889, 16);
            this.iconeencerar.Name = "iconeencerar";
            this.iconeencerar.Size = new System.Drawing.Size(15, 15);
            this.iconeencerar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconeencerar.TabIndex = 9;
            this.iconeencerar.TabStop = false;
            this.iconeencerar.Click += new System.EventHandler(this.iconeencerar_Click);
            // 
            // iconeminizar
            // 
            this.iconeminizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconeminizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconeminizar.Image = global::GUI.Properties.Resources.minimazar;
            this.iconeminizar.Location = new System.Drawing.Point(829, 16);
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
            this.iconemaxizar.Image = global::GUI.Properties.Resources.icon_maximizar;
            this.iconemaxizar.Location = new System.Drawing.Point(859, 16);
            this.iconemaxizar.Name = "iconemaxizar";
            this.iconemaxizar.Size = new System.Drawing.Size(15, 15);
            this.iconemaxizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconemaxizar.TabIndex = 6;
            this.iconemaxizar.TabStop = false;
            this.iconemaxizar.Click += new System.EventHandler(this.iconemaxizar_Click);
            // 
            // cadUnidade
            // 
            this.cadUnidade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cadUnidade.FlatAppearance.BorderSize = 0;
            this.cadUnidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cadUnidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadUnidade.ForeColor = System.Drawing.Color.White;
            this.cadUnidade.Image = ((System.Drawing.Image)(resources.GetObject("cadUnidade.Image")));
            this.cadUnidade.Location = new System.Drawing.Point(0, 344);
            this.cadUnidade.Name = "cadUnidade";
            this.cadUnidade.Size = new System.Drawing.Size(178, 56);
            this.cadUnidade.TabIndex = 13;
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
            this.cadSub.Location = new System.Drawing.Point(0, 288);
            this.cadSub.Name = "cadSub";
            this.cadSub.Size = new System.Drawing.Size(175, 50);
            this.cadSub.TabIndex = 10;
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
            this.cadCategoria.Location = new System.Drawing.Point(0, 232);
            this.cadCategoria.Name = "cadCategoria";
            this.cadCategoria.Size = new System.Drawing.Size(178, 50);
            this.cadCategoria.TabIndex = 12;
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
            this.cadProduto.Location = new System.Drawing.Point(0, 176);
            this.cadProduto.Name = "cadProduto";
            this.cadProduto.Size = new System.Drawing.Size(172, 50);
            this.cadProduto.TabIndex = 11;
            this.cadProduto.Text = "    Cadastro de Produto";
            this.cadProduto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cadProduto.UseVisualStyleBackColor = true;
            this.cadProduto.Click += new System.EventHandler(this.cadProduto_Click);
            // 
            // frmTodosCadastros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 690);
            this.Controls.Add(this.pnCadastros);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.pnCadas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "frmTodosCadastros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTodosCadastros";
            this.Load += new System.EventHandler(this.frmTodosCadastros_Load);
            this.pnCadas.ResumeLayout(false);
            this.pnCadas.PerformLayout();
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
        private System.Windows.Forms.Panel pnCadas;
        private System.Windows.Forms.Panel panelHeader;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel pnCadastros;
        private System.Windows.Forms.PictureBox iconemaxizar;
        private System.Windows.Forms.PictureBox iconeminizar;
        private System.Windows.Forms.PictureBox iconerestaurar;
        private System.Windows.Forms.PictureBox iconeencerar;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button cadUnidade;
        private System.Windows.Forms.Button cadSub;
        private System.Windows.Forms.Button cadCategoria;
        private System.Windows.Forms.Button cadProduto;
    }
}
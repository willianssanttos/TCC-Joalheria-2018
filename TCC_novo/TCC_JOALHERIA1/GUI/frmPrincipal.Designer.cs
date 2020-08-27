namespace GUI
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unidadeDeMedidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formaPagamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nivelDeAcessoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ferramentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçaoDoBancoDeDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupDoBancoDeDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recebimentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compraToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vendaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.relatorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.compraToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.vendaToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.btnFerramentas = new System.Windows.Forms.Button();
            this.btnConsultas = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnViewSales = new System.Windows.Forms.Button();
            this.btnExpense = new System.Windows.Forms.Button();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.ferramentasToolStripMenuItem,
            this.movimentaçãoToolStripMenuItem,
            this.consultaToolStripMenuItem,
            this.relatorioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoriaToolStripMenuItem,
            this.produtoToolStripMenuItem,
            this.subCategoriaToolStripMenuItem,
            this.clienteToolStripMenuItem,
            this.unidadeDeMedidaToolStripMenuItem,
            this.formaPagamentoToolStripMenuItem,
            this.funcionarioToolStripMenuItem,
            this.nivelDeAcessoToolStripMenuItem,
            this.usuarioToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.categoriaToolStripMenuItem.Text = "Categoria";
            this.categoriaToolStripMenuItem.Click += new System.EventHandler(this.categoriaToolStripMenuItem_Click);
            // 
            // produtoToolStripMenuItem
            // 
            this.produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            this.produtoToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.produtoToolStripMenuItem.Text = "Produto";
            this.produtoToolStripMenuItem.Click += new System.EventHandler(this.produtoToolStripMenuItem_Click);
            // 
            // subCategoriaToolStripMenuItem
            // 
            this.subCategoriaToolStripMenuItem.Name = "subCategoriaToolStripMenuItem";
            this.subCategoriaToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.subCategoriaToolStripMenuItem.Text = "SubCategoria";
            this.subCategoriaToolStripMenuItem.Click += new System.EventHandler(this.subCategoriaToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // unidadeDeMedidaToolStripMenuItem
            // 
            this.unidadeDeMedidaToolStripMenuItem.Name = "unidadeDeMedidaToolStripMenuItem";
            this.unidadeDeMedidaToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.unidadeDeMedidaToolStripMenuItem.Text = "Unidade de medida";
            this.unidadeDeMedidaToolStripMenuItem.Click += new System.EventHandler(this.unidadeDeMedidaToolStripMenuItem_Click);
            // 
            // formaPagamentoToolStripMenuItem
            // 
            this.formaPagamentoToolStripMenuItem.Name = "formaPagamentoToolStripMenuItem";
            this.formaPagamentoToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.formaPagamentoToolStripMenuItem.Text = "Fornecedor";
            this.formaPagamentoToolStripMenuItem.Click += new System.EventHandler(this.formaPagamentoToolStripMenuItem_Click);
            // 
            // funcionarioToolStripMenuItem
            // 
            this.funcionarioToolStripMenuItem.Name = "funcionarioToolStripMenuItem";
            this.funcionarioToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.funcionarioToolStripMenuItem.Text = "Funcionario";
            this.funcionarioToolStripMenuItem.Click += new System.EventHandler(this.funcionarioToolStripMenuItem_Click);
            // 
            // nivelDeAcessoToolStripMenuItem
            // 
            this.nivelDeAcessoToolStripMenuItem.Name = "nivelDeAcessoToolStripMenuItem";
            this.nivelDeAcessoToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.nivelDeAcessoToolStripMenuItem.Text = "Nivel de Acesso";
            this.nivelDeAcessoToolStripMenuItem.Click += new System.EventHandler(this.nivelDeAcessoToolStripMenuItem_Click);
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            this.usuarioToolStripMenuItem.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // ferramentasToolStripMenuItem
            // 
            this.ferramentasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuraçaoDoBancoDeDadosToolStripMenuItem,
            this.backupDoBancoDeDadosToolStripMenuItem});
            this.ferramentasToolStripMenuItem.Name = "ferramentasToolStripMenuItem";
            this.ferramentasToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.ferramentasToolStripMenuItem.Text = "Ferramentas";
            // 
            // configuraçaoDoBancoDeDadosToolStripMenuItem
            // 
            this.configuraçaoDoBancoDeDadosToolStripMenuItem.Name = "configuraçaoDoBancoDeDadosToolStripMenuItem";
            this.configuraçaoDoBancoDeDadosToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.configuraçaoDoBancoDeDadosToolStripMenuItem.Text = "Configuraçao do banco de Dados";
            this.configuraçaoDoBancoDeDadosToolStripMenuItem.Click += new System.EventHandler(this.configuraçaoDoBancoDeDadosToolStripMenuItem_Click);
            // 
            // backupDoBancoDeDadosToolStripMenuItem
            // 
            this.backupDoBancoDeDadosToolStripMenuItem.Name = "backupDoBancoDeDadosToolStripMenuItem";
            this.backupDoBancoDeDadosToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.backupDoBancoDeDadosToolStripMenuItem.Text = "Backup do Banco de Dados";
            this.backupDoBancoDeDadosToolStripMenuItem.Click += new System.EventHandler(this.backupDoBancoDeDadosToolStripMenuItem_Click);
            // 
            // movimentaçãoToolStripMenuItem
            // 
            this.movimentaçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.compraToolStripMenuItem,
            this.vendaToolStripMenuItem,
            this.pagamentoToolStripMenuItem,
            this.recebimentoToolStripMenuItem});
            this.movimentaçãoToolStripMenuItem.Name = "movimentaçãoToolStripMenuItem";
            this.movimentaçãoToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.movimentaçãoToolStripMenuItem.Text = "Movimentação";
            // 
            // compraToolStripMenuItem
            // 
            this.compraToolStripMenuItem.Name = "compraToolStripMenuItem";
            this.compraToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.compraToolStripMenuItem.Text = "compra";
            this.compraToolStripMenuItem.Click += new System.EventHandler(this.compraToolStripMenuItem_Click);
            // 
            // vendaToolStripMenuItem
            // 
            this.vendaToolStripMenuItem.Name = "vendaToolStripMenuItem";
            this.vendaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.vendaToolStripMenuItem.Text = "venda";
            this.vendaToolStripMenuItem.Click += new System.EventHandler(this.vendaToolStripMenuItem_Click);
            // 
            // pagamentoToolStripMenuItem
            // 
            this.pagamentoToolStripMenuItem.Name = "pagamentoToolStripMenuItem";
            this.pagamentoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pagamentoToolStripMenuItem.Text = "pagamento";
            this.pagamentoToolStripMenuItem.Click += new System.EventHandler(this.pagamentoToolStripMenuItem_Click);
            // 
            // recebimentoToolStripMenuItem
            // 
            this.recebimentoToolStripMenuItem.Name = "recebimentoToolStripMenuItem";
            this.recebimentoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.recebimentoToolStripMenuItem.Text = "recebimento";
            this.recebimentoToolStripMenuItem.Click += new System.EventHandler(this.recebimentoToolStripMenuItem_Click);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.compraToolStripMenuItem1,
            this.vendaToolStripMenuItem1});
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.consultaToolStripMenuItem.Text = "consulta";
            // 
            // compraToolStripMenuItem1
            // 
            this.compraToolStripMenuItem1.Name = "compraToolStripMenuItem1";
            this.compraToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.compraToolStripMenuItem1.Text = "compra";
            this.compraToolStripMenuItem1.Click += new System.EventHandler(this.compraToolStripMenuItem1_Click);
            // 
            // vendaToolStripMenuItem1
            // 
            this.vendaToolStripMenuItem1.Name = "vendaToolStripMenuItem1";
            this.vendaToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.vendaToolStripMenuItem1.Text = "venda";
            this.vendaToolStripMenuItem1.Click += new System.EventHandler(this.vendaToolStripMenuItem1_Click);
            // 
            // relatorioToolStripMenuItem
            // 
            this.relatorioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtoToolStripMenuItem1,
            this.compraToolStripMenuItem2,
            this.vendaToolStripMenuItem2});
            this.relatorioToolStripMenuItem.Name = "relatorioToolStripMenuItem";
            this.relatorioToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.relatorioToolStripMenuItem.Text = "Relatorio";
            // 
            // produtoToolStripMenuItem1
            // 
            this.produtoToolStripMenuItem1.Name = "produtoToolStripMenuItem1";
            this.produtoToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.produtoToolStripMenuItem1.Text = "Produto";
            this.produtoToolStripMenuItem1.Click += new System.EventHandler(this.produtoToolStripMenuItem1_Click);
            // 
            // compraToolStripMenuItem2
            // 
            this.compraToolStripMenuItem2.Name = "compraToolStripMenuItem2";
            this.compraToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.compraToolStripMenuItem2.Text = "Compra";
            this.compraToolStripMenuItem2.Click += new System.EventHandler(this.compraToolStripMenuItem2_Click);
            // 
            // vendaToolStripMenuItem2
            // 
            this.vendaToolStripMenuItem2.Name = "vendaToolStripMenuItem2";
            this.vendaToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.vendaToolStripMenuItem2.Text = "Venda";
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(11)))), ((int)(((byte)(83)))));
            this.panelLeft.Controls.Add(this.btnSettings);
            this.panelLeft.Controls.Add(this.btnViewSales);
            this.panelLeft.Controls.Add(this.btnFerramentas);
            this.panelLeft.Controls.Add(this.btnExpense);
            this.panelLeft.Controls.Add(this.btnPurchase);
            this.panelLeft.Controls.Add(this.btnConsultas);
            this.panelLeft.Controls.Add(this.panel3);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 24);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(215, 700);
            this.panelLeft.TabIndex = 32;
            // 
            // btnFerramentas
            // 
            this.btnFerramentas.FlatAppearance.BorderSize = 0;
            this.btnFerramentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFerramentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFerramentas.ForeColor = System.Drawing.Color.White;
            this.btnFerramentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFerramentas.Location = new System.Drawing.Point(12, 402);
            this.btnFerramentas.Name = "btnFerramentas";
            this.btnFerramentas.Size = new System.Drawing.Size(203, 60);
            this.btnFerramentas.TabIndex = 2;
            this.btnFerramentas.Text = "     Ferramentas";
            this.btnFerramentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFerramentas.UseVisualStyleBackColor = true;
            // 
            // btnConsultas
            // 
            this.btnConsultas.FlatAppearance.BorderSize = 0;
            this.btnConsultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultas.ForeColor = System.Drawing.Color.White;
            this.btnConsultas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultas.Location = new System.Drawing.Point(12, 203);
            this.btnConsultas.Name = "btnConsultas";
            this.btnConsultas.Size = new System.Drawing.Size(203, 60);
            this.btnConsultas.TabIndex = 2;
            this.btnConsultas.Text = "     Consultas";
            this.btnConsultas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsultas.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.button8);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(215, 134);
            this.panel3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(62, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 79);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pj";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(27, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "Palácio das Jóias";
            // 
            // btnSettings
            // 
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(12, 530);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(203, 60);
            this.btnSettings.TabIndex = 2;
            this.btnSettings.Text = "     Ferramentas";
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettings.UseVisualStyleBackColor = true;
            // 
            // btnViewSales
            // 
            this.btnViewSales.FlatAppearance.BorderSize = 0;
            this.btnViewSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewSales.ForeColor = System.Drawing.Color.White;
            this.btnViewSales.Image = ((System.Drawing.Image)(resources.GetObject("btnViewSales.Image")));
            this.btnViewSales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewSales.Location = new System.Drawing.Point(12, 466);
            this.btnViewSales.Name = "btnViewSales";
            this.btnViewSales.Size = new System.Drawing.Size(203, 60);
            this.btnViewSales.TabIndex = 2;
            this.btnViewSales.Text = "     View Sales";
            this.btnViewSales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnViewSales.UseVisualStyleBackColor = true;
            // 
            // btnExpense
            // 
            this.btnExpense.FlatAppearance.BorderSize = 0;
            this.btnExpense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpense.ForeColor = System.Drawing.Color.White;
            this.btnExpense.Image = ((System.Drawing.Image)(resources.GetObject("btnExpense.Image")));
            this.btnExpense.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExpense.Location = new System.Drawing.Point(12, 336);
            this.btnExpense.Name = "btnExpense";
            this.btnExpense.Size = new System.Drawing.Size(203, 60);
            this.btnExpense.TabIndex = 2;
            this.btnExpense.Text = "     Movimentação";
            this.btnExpense.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExpense.UseVisualStyleBackColor = true;
            // 
            // btnPurchase
            // 
            this.btnPurchase.FlatAppearance.BorderSize = 0;
            this.btnPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchase.ForeColor = System.Drawing.Color.White;
            this.btnPurchase.Image = ((System.Drawing.Image)(resources.GetObject("btnPurchase.Image")));
            this.btnPurchase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPurchase.Location = new System.Drawing.Point(12, 256);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(203, 60);
            this.btnPurchase.TabIndex = 2;
            this.btnPurchase.Text = "        Estoque";
            this.btnPurchase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPurchase.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(173, 8);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(38, 29);
            this.button8.TabIndex = 2;
            this.button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 724);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrincipal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subCategoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unidadeDeMedidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ferramentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraçaoDoBancoDeDadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backupDoBancoDeDadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formaPagamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimentaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compraToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pagamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem funcionarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recebimentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nivelDeAcessoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatorioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem compraToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem vendaToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnViewSales;
        private System.Windows.Forms.Button btnFerramentas;
        private System.Windows.Forms.Button btnExpense;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.Button btnConsultas;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label5;
    }
}
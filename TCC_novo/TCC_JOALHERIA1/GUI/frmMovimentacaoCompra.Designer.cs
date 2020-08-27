namespace GUI
{
    partial class frmMovimentacaoCompra
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtComCodigo = new System.Windows.Forms.TextBox();
            this.cbNParcelas = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNFiscal = new System.Windows.Forms.TextBox();
            this.txtTotalCompra = new System.Windows.Forms.TextBox();
            this.cbTpagto = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtForCod = new System.Windows.Forms.TextBox();
            this.btLocFor = new System.Windows.Forms.Button();
            this.lFornecedor = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCodPro = new System.Windows.Forms.TextBox();
            this.btLocProd = new System.Windows.Forms.Button();
            this.lProduto = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btAddProd = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.pnFinalizaCompra = new System.Windows.Forms.Panel();
            this.dgvParcelas = new MetroFramework.Controls.MetroGrid();
            this.pco_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pco_valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pco_datavecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label17 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btSalvarFinal = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dtDataCompra = new MetroFramework.Controls.MetroDateTime();
            this.dtDataini = new MetroFramework.Controls.MetroDateTime();
            this.dgvItens = new MetroFramework.Controls.MetroGrid();
            this.ProCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ForNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forQtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provund = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnDados.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            this.pnFinalizaCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            this.SuspendLayout();
            // 
            // pnDados
            // 
            this.pnDados.Controls.Add(this.dgvItens);
            this.pnDados.Controls.Add(this.dtDataini);
            this.pnDados.Controls.Add(this.dtDataCompra);
            this.pnDados.Controls.Add(this.lFornecedor);
            this.pnDados.Controls.Add(this.label13);
            this.pnDados.Controls.Add(this.btAddProd);
            this.pnDados.Controls.Add(this.txtValor);
            this.pnDados.Controls.Add(this.txtQtd);
            this.pnDados.Controls.Add(this.label12);
            this.pnDados.Controls.Add(this.label11);
            this.pnDados.Controls.Add(this.lProduto);
            this.pnDados.Controls.Add(this.btLocProd);
            this.pnDados.Controls.Add(this.txtCodPro);
            this.pnDados.Controls.Add(this.label10);
            this.pnDados.Controls.Add(this.btLocFor);
            this.pnDados.Controls.Add(this.txtForCod);
            this.pnDados.Controls.Add(this.label8);
            this.pnDados.Controls.Add(this.cbTpagto);
            this.pnDados.Controls.Add(this.txtTotalCompra);
            this.pnDados.Controls.Add(this.txtNFiscal);
            this.pnDados.Controls.Add(this.label7);
            this.pnDados.Controls.Add(this.label6);
            this.pnDados.Controls.Add(this.label5);
            this.pnDados.Controls.Add(this.label4);
            this.pnDados.Controls.Add(this.label3);
            this.pnDados.Controls.Add(this.label2);
            this.pnDados.Controls.Add(this.cbNParcelas);
            this.pnDados.Controls.Add(this.txtComCodigo);
            this.pnDados.Controls.Add(this.label1);
            this.pnDados.Controls.Add(this.label9);
            this.pnDados.Location = new System.Drawing.Point(3, -1);
            this.pnDados.Size = new System.Drawing.Size(707, 432);
            // 
            // pnBotoes
            // 
            this.pnBotoes.Location = new System.Drawing.Point(3, 437);
            this.pnBotoes.Size = new System.Drawing.Size(698, 106);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(594, 19);
            this.btCancelar.Size = new System.Drawing.Size(94, 79);
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(477, 19);
            this.btSalvar.Size = new System.Drawing.Size(94, 79);
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(360, 19);
            this.btExcluir.Size = new System.Drawing.Size(94, 79);
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Location = new System.Drawing.Point(243, 19);
            this.btAlterar.Size = new System.Drawing.Size(94, 79);
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btLocalizar
            // 
            this.btLocalizar.Location = new System.Drawing.Point(113, 19);
            this.btLocalizar.Size = new System.Drawing.Size(94, 79);
            this.btLocalizar.Click += new System.EventHandler(this.btLocalizar_Click);
            // 
            // btInserir
            // 
            this.btInserir.Location = new System.Drawing.Point(9, 19);
            this.btInserir.Size = new System.Drawing.Size(94, 79);
            this.btInserir.Click += new System.EventHandler(this.btInserir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // txtComCodigo
            // 
            this.txtComCodigo.Enabled = false;
            this.txtComCodigo.Location = new System.Drawing.Point(9, 29);
            this.txtComCodigo.Name = "txtComCodigo";
            this.txtComCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtComCodigo.TabIndex = 1;
            // 
            // cbNParcelas
            // 
            this.cbNParcelas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbNParcelas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbNParcelas.DisplayMember = "1";
            this.cbNParcelas.FormattingEnabled = true;
            this.cbNParcelas.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbNParcelas.Location = new System.Drawing.Point(9, 408);
            this.cbNParcelas.Name = "cbNParcelas";
            this.cbNParcelas.Size = new System.Drawing.Size(121, 21);
            this.cbNParcelas.TabIndex = 3;
            this.cbNParcelas.Tag = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Número da nota Fiscal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(237, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data da Compra";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 390);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Número de Parcelas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(133, 392);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Forma de Pagamento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(263, 384);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Data Inicial do Pagamento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(592, 383);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Valor Total";
            // 
            // txtNFiscal
            // 
            this.txtNFiscal.Location = new System.Drawing.Point(121, 29);
            this.txtNFiscal.Name = "txtNFiscal";
            this.txtNFiscal.Size = new System.Drawing.Size(110, 20);
            this.txtNFiscal.TabIndex = 10;
            this.txtNFiscal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNFiscal_KeyPress);
            // 
            // txtTotalCompra
            // 
            this.txtTotalCompra.Enabled = false;
            this.txtTotalCompra.Location = new System.Drawing.Point(547, 407);
            this.txtTotalCompra.Name = "txtTotalCompra";
            this.txtTotalCompra.Size = new System.Drawing.Size(141, 20);
            this.txtTotalCompra.TabIndex = 11;
            // 
            // cbTpagto
            // 
            this.cbTpagto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbTpagto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbTpagto.FormattingEnabled = true;
            this.cbTpagto.Location = new System.Drawing.Point(136, 408);
            this.cbTpagto.Name = "cbTpagto";
            this.cbTpagto.Size = new System.Drawing.Size(121, 21);
            this.cbTpagto.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Código do Fornecedor";
            // 
            // txtForCod
            // 
            this.txtForCod.Location = new System.Drawing.Point(9, 70);
            this.txtForCod.Name = "txtForCod";
            this.txtForCod.Size = new System.Drawing.Size(100, 20);
            this.txtForCod.TabIndex = 16;
            this.txtForCod.Leave += new System.EventHandler(this.txtForCod_Leave);
            // 
            // btLocFor
            // 
           
            this.btLocFor.Location = new System.Drawing.Point(121, 55);
            this.btLocFor.Name = "btLocFor";
            this.btLocFor.Size = new System.Drawing.Size(44, 35);
            this.btLocFor.TabIndex = 17;
            this.toolTip1.SetToolTip(this.btLocFor, "Localizar");
            this.btLocFor.UseVisualStyleBackColor = true;
            this.btLocFor.Click += new System.EventHandler(this.btLocFor_Click);
            // 
            // lFornecedor
            // 
            this.lFornecedor.AutoSize = true;
            this.lFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFornecedor.Location = new System.Drawing.Point(165, 68);
            this.lFornecedor.Name = "lFornecedor";
            this.lFornecedor.Size = new System.Drawing.Size(444, 20);
            this.lFornecedor.TabIndex = 18;
            this.lFornecedor.Text = "Informe o código do fornecedor ou clique em Localizar";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(5, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(675, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "__________________________________________________________________________";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Código do Produto:";
            // 
            // txtCodPro
            // 
            this.txtCodPro.Location = new System.Drawing.Point(9, 123);
            this.txtCodPro.Name = "txtCodPro";
            this.txtCodPro.Size = new System.Drawing.Size(352, 20);
            this.txtCodPro.TabIndex = 21;
            this.txtCodPro.Leave += new System.EventHandler(this.txtCodPro_Leave);
            // 
            // btLocProd
            // 
          
            this.btLocProd.Location = new System.Drawing.Point(367, 121);
            this.btLocProd.Name = "btLocProd";
            this.btLocProd.Size = new System.Drawing.Size(65, 26);
            this.btLocProd.TabIndex = 22;
            this.toolTip1.SetToolTip(this.btLocProd, "Localizar");
            this.btLocProd.UseVisualStyleBackColor = true;
            this.btLocProd.Click += new System.EventHandler(this.btLocProd_Click);
            // 
            // lProduto
            // 
            this.lProduto.AutoSize = true;
            this.lProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lProduto.Location = new System.Drawing.Point(110, 100);
            this.lProduto.Name = "lProduto";
            this.lProduto.Size = new System.Drawing.Size(334, 15);
            this.lProduto.TabIndex = 23;
            this.lProduto.Text = "Informe o codigo do produto ou clique em localizar";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(450, 109);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Quantidade";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(544, 109);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Valor Unitario";
            // 
            // txtQtd
            // 
            this.txtQtd.Location = new System.Drawing.Point(438, 124);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(100, 20);
            this.txtQtd.TabIndex = 26;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(544, 124);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 27;
            // 
            // btAddProd
            // 
            this.btAddProd.Location = new System.Drawing.Point(651, 121);
            this.btAddProd.Name = "btAddProd";
            this.btAddProd.Size = new System.Drawing.Size(35, 23);
            this.btAddProd.TabIndex = 28;
            this.btAddProd.Text = "+";
            this.toolTip1.SetToolTip(this.btAddProd, "Adicionar Item");
            this.btAddProd.UseVisualStyleBackColor = true;
            this.btAddProd.Click += new System.EventHandler(this.btAddProd_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 144);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(121, 16);
            this.label13.TabIndex = 29;
            this.label13.Text = "Itens da Compra";
            // 
            // pnFinalizaCompra
            // 
            this.pnFinalizaCompra.Controls.Add(this.dgvParcelas);
            this.pnFinalizaCompra.Controls.Add(this.label17);
            this.pnFinalizaCompra.Controls.Add(this.lbTotal);
            this.pnFinalizaCompra.Controls.Add(this.lb);
            this.pnFinalizaCompra.Controls.Add(this.btnCancelar);
            this.pnFinalizaCompra.Controls.Add(this.btSalvarFinal);
            this.pnFinalizaCompra.Controls.Add(this.label15);
            this.pnFinalizaCompra.Controls.Add(this.label14);
            this.pnFinalizaCompra.Controls.Add(this.label16);
            this.pnFinalizaCompra.Location = new System.Drawing.Point(2, 2);
            this.pnFinalizaCompra.Name = "pnFinalizaCompra";
            this.pnFinalizaCompra.Size = new System.Drawing.Size(724, 548);
            this.pnFinalizaCompra.TabIndex = 2;
            this.pnFinalizaCompra.Visible = false;
            // 
            // dgvParcelas
            // 
            this.dgvParcelas.AllowUserToAddRows = false;
            this.dgvParcelas.AllowUserToDeleteRows = false;
            this.dgvParcelas.AllowUserToResizeRows = false;
            this.dgvParcelas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvParcelas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvParcelas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvParcelas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvParcelas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvParcelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParcelas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pco_cod,
            this.pco_valor,
            this.pco_datavecto});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvParcelas.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgvParcelas.EnableHeadersVisualStyles = false;
            this.dgvParcelas.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvParcelas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvParcelas.Location = new System.Drawing.Point(10, 46);
            this.dgvParcelas.Name = "dgvParcelas";
            this.dgvParcelas.ReadOnly = true;
            this.dgvParcelas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvParcelas.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvParcelas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvParcelas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvParcelas.Size = new System.Drawing.Size(675, 413);
            this.dgvParcelas.TabIndex = 26;
            // 
            // pco_cod
            // 
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pco_cod.DefaultCellStyle = dataGridViewCellStyle10;
            this.pco_cod.HeaderText = "Parcelas";
            this.pco_cod.Name = "pco_cod";
            this.pco_cod.ReadOnly = true;
            this.pco_cod.Width = 200;
            // 
            // pco_valor
            // 
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pco_valor.DefaultCellStyle = dataGridViewCellStyle11;
            this.pco_valor.HeaderText = "Valor da Parcela";
            this.pco_valor.Name = "pco_valor";
            this.pco_valor.ReadOnly = true;
            this.pco_valor.Width = 225;
            // 
            // pco_datavecto
            // 
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pco_datavecto.DefaultCellStyle = dataGridViewCellStyle12;
            this.pco_datavecto.HeaderText = "Data do Vencimento";
            this.pco_datavecto.Name = "pco_datavecto";
            this.pco_datavecto.ReadOnly = true;
            this.pco_datavecto.Width = 225;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.DarkTurquoise;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label17.Location = new System.Drawing.Point(499, 486);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(88, 55);
            this.label17.TabIndex = 25;
            this.label17.Text = "R$";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.BackColor = System.Drawing.Color.DarkTurquoise;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbTotal.Location = new System.Drawing.Point(581, 486);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(108, 55);
            this.lbTotal.TabIndex = 24;
            this.lbTotal.Text = "000";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.Location = new System.Drawing.Point(507, 462);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(182, 25);
            this.lb.TabIndex = 23;
            this.lb.Text = "Total da compra";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
       
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(396, 465);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(92, 76);
            this.btnCancelar.TabIndex = 22;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btCancelarFinal_Click);
            // 
            // btSalvarFinal
            // 
            this.btSalvarFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            
            this.btSalvarFinal.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btSalvarFinal.Location = new System.Drawing.Point(298, 465);
            this.btSalvarFinal.Name = "btSalvarFinal";
            this.btSalvarFinal.Size = new System.Drawing.Size(92, 76);
            this.btSalvarFinal.TabIndex = 21;
            this.btSalvarFinal.Text = "Salvar";
            this.btSalvarFinal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btSalvarFinal.UseVisualStyleBackColor = true;
            this.btSalvarFinal.Click += new System.EventHandler(this.btSalvarFinal_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(11, 30);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "Parcelas da compra";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 5);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "Dados do Pagamento";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(9, 5);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(680, 16);
            this.label16.TabIndex = 20;
            this.label16.Text = "_________________________________________________________________________________" +
    "_______________";
            this.label16.Click += new System.EventHandler(this.btCancelarFinal_Click);
            // 
            // dtDataCompra
            // 
            this.dtDataCompra.Location = new System.Drawing.Point(237, 25);
            this.dtDataCompra.MinimumSize = new System.Drawing.Size(4, 29);
            this.dtDataCompra.Name = "dtDataCompra";
            this.dtDataCompra.Size = new System.Drawing.Size(240, 29);
            this.dtDataCompra.TabIndex = 30;
            // 
            // dtDataini
            // 
            this.dtDataini.Location = new System.Drawing.Point(263, 400);
            this.dtDataini.MinimumSize = new System.Drawing.Size(4, 29);
            this.dtDataini.Name = "dtDataini";
            this.dtDataini.Size = new System.Drawing.Size(229, 29);
            this.dtDataini.TabIndex = 31;
            // 
            // dgvItens
            // 
            this.dgvItens.AllowUserToAddRows = false;
            this.dgvItens.AllowUserToDeleteRows = false;
            this.dgvItens.AllowUserToResizeRows = false;
            this.dgvItens.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvItens.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvItens.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvItens.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItens.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProCod,
            this.ForNome,
            this.forQtde,
            this.provund,
            this.provTotal});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItens.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvItens.EnableHeadersVisualStyles = false;
            this.dgvItens.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvItens.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvItens.Location = new System.Drawing.Point(9, 163);
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.ReadOnly = true;
            this.dgvItens.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItens.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvItens.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItens.Size = new System.Drawing.Size(679, 217);
            this.dgvItens.TabIndex = 32;
            this.toolTip1.SetToolTip(this.dgvItens, "Para retornar os valores para os campos click duas vezes no grid.");
            this.dgvItens.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItens_CellDoubleClick);
            // 
            // ProCod
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProCod.DefaultCellStyle = dataGridViewCellStyle2;
            this.ProCod.HeaderText = "Código";
            this.ProCod.Name = "ProCod";
            this.ProCod.ReadOnly = true;
            this.ProCod.Width = 70;
            // 
            // ForNome
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForNome.DefaultCellStyle = dataGridViewCellStyle3;
            this.ForNome.HeaderText = "Nome";
            this.ForNome.Name = "ForNome";
            this.ForNome.ReadOnly = true;
            this.ForNome.Width = 170;
            // 
            // forQtde
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forQtde.DefaultCellStyle = dataGridViewCellStyle4;
            this.forQtde.HeaderText = "Quantidade";
            this.forQtde.Name = "forQtde";
            this.forQtde.ReadOnly = true;
            // 
            // provund
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.provund.DefaultCellStyle = dataGridViewCellStyle5;
            this.provund.HeaderText = "Valor Unitario";
            this.provund.Name = "provund";
            this.provund.ReadOnly = true;
            this.provund.Width = 150;
            // 
            // provTotal
            // 
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.provTotal.DefaultCellStyle = dataGridViewCellStyle6;
            this.provTotal.HeaderText = "Valor Total";
            this.provTotal.Name = "provTotal";
            this.provTotal.ReadOnly = true;
            this.provTotal.Width = 150;
            // 
            // frmMovimentacaoCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(860, 555);
            this.Controls.Add(this.pnFinalizaCompra);
            this.Name = "frmMovimentacaoCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movimentação - Compra";
            this.Load += new System.EventHandler(this.frmMovimentacaoCompra_Load);
            this.Controls.SetChildIndex(this.pnDados, 0);
            this.Controls.SetChildIndex(this.pnBotoes, 0);
            this.Controls.SetChildIndex(this.pnFinalizaCompra, 0);
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            this.pnBotoes.ResumeLayout(false);
            this.pnFinalizaCompra.ResumeLayout(false);
            this.pnFinalizaCompra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTpagto;
        private System.Windows.Forms.TextBox txtTotalCompra;
        private System.Windows.Forms.TextBox txtNFiscal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbNParcelas;
        private System.Windows.Forms.TextBox txtComCodigo;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lProduto;
        private System.Windows.Forms.Button btLocProd;
        private System.Windows.Forms.TextBox txtCodPro;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lFornecedor;
        private System.Windows.Forms.Button btLocFor;
        private System.Windows.Forms.TextBox txtForCod;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btAddProd;
        private System.Windows.Forms.Panel pnFinalizaCompra;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        protected System.Windows.Forms.Button btnCancelar;
        protected System.Windows.Forms.Button btSalvarFinal;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lb;
        private MetroFramework.Controls.MetroDateTime dtDataini;
        private MetroFramework.Controls.MetroDateTime dtDataCompra;
        private MetroFramework.Controls.MetroGrid dgvParcelas;
        private MetroFramework.Controls.MetroGrid dgvItens;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn ForNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn forQtde;
        private System.Windows.Forms.DataGridViewTextBoxColumn provund;
        private System.Windows.Forms.DataGridViewTextBoxColumn provTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn pco_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn pco_valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn pco_datavecto;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

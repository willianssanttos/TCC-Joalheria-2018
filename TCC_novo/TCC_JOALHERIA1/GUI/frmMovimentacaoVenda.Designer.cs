namespace GUI
{
    partial class frmMovimentacaoVenda
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label13 = new System.Windows.Forms.Label();
            this.btAddProd = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lProduto = new System.Windows.Forms.Label();
            this.btLocProd = new System.Windows.Forms.Button();
            this.txtCodPro = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lCliente = new System.Windows.Forms.Label();
            this.btLocCli = new System.Windows.Forms.Button();
            this.txtCliCod = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbTpagto = new System.Windows.Forms.ComboBox();
            this.txtTotalVenda = new System.Windows.Forms.TextBox();
            this.txtNFiscal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbNParcelas = new System.Windows.Forms.ComboBox();
            this.txtVenCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbVendaAVista = new System.Windows.Forms.CheckBox();
            this.pnFinalizaVenda = new System.Windows.Forms.Panel();
            this.dgvParcelas = new MetroFramework.Controls.MetroGrid();
            this.pco_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pco_valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pco_datavecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label17 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btSalvarFinal = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dtDataVenda = new MetroFramework.Controls.MetroDateTime();
            this.dtDataini = new MetroFramework.Controls.MetroDateTime();
            this.dgvItens = new MetroFramework.Controls.MetroGrid();
            this.ProCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ForNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forQtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provund = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbMsg = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.iconeencerar = new System.Windows.Forms.PictureBox();
            this.pnDados.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            this.pnFinalizaVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconeencerar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnDados
            // 
            this.pnDados.Controls.Add(this.lbMsg);
            this.pnDados.Controls.Add(this.dgvItens);
            this.pnDados.Controls.Add(this.dtDataini);
            this.pnDados.Controls.Add(this.dtDataVenda);
            this.pnDados.Controls.Add(this.cbVendaAVista);
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
            this.pnDados.Controls.Add(this.lCliente);
            this.pnDados.Controls.Add(this.btLocCli);
            this.pnDados.Controls.Add(this.txtCliCod);
            this.pnDados.Controls.Add(this.label8);
            this.pnDados.Controls.Add(this.cbTpagto);
            this.pnDados.Controls.Add(this.txtTotalVenda);
            this.pnDados.Controls.Add(this.txtNFiscal);
            this.pnDados.Controls.Add(this.label7);
            this.pnDados.Controls.Add(this.label6);
            this.pnDados.Controls.Add(this.label5);
            this.pnDados.Controls.Add(this.label4);
            this.pnDados.Controls.Add(this.label3);
            this.pnDados.Controls.Add(this.label2);
            this.pnDados.Controls.Add(this.cbNParcelas);
            this.pnDados.Controls.Add(this.txtVenCodigo);
            this.pnDados.Controls.Add(this.label1);
            this.pnDados.Controls.Add(this.label9);
            this.pnDados.Location = new System.Drawing.Point(3, 12);
            this.pnDados.Size = new System.Drawing.Size(733, 436);
            // 
            // pnBotoes
            // 
            this.pnBotoes.Location = new System.Drawing.Point(3, 454);
            this.pnBotoes.Size = new System.Drawing.Size(733, 101);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(590, 14);
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(446, 14);
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(302, 14);
            this.btExcluir.Text = "Cancelar Venda";
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Location = new System.Drawing.Point(3, 14);
            this.btAlterar.Size = new System.Drawing.Size(10, 48);
            this.btAlterar.Visible = false;
            // 
            // btLocalizar
            // 
            this.btLocalizar.Location = new System.Drawing.Point(158, 14);
            this.btLocalizar.Click += new System.EventHandler(this.btLocalizar_Click);
            // 
            // btInserir
            // 
            this.btInserir.Location = new System.Drawing.Point(14, 14);
            this.btInserir.Click += new System.EventHandler(this.btInserir_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(4, 135);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(121, 16);
            this.label13.TabIndex = 59;
            this.label13.Text = "Itens da Compra";
            // 
            // btAddProd
            // 
            this.btAddProd.Location = new System.Drawing.Point(647, 109);
            this.btAddProd.Name = "btAddProd";
            this.btAddProd.Size = new System.Drawing.Size(35, 23);
            this.btAddProd.TabIndex = 58;
            this.btAddProd.Text = "+";
            this.toolTip1.SetToolTip(this.btAddProd, "Adicionar Item");
            this.btAddProd.UseVisualStyleBackColor = true;
            this.btAddProd.Click += new System.EventHandler(this.btAddProd_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(541, 111);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 57;
            this.txtValor.Text = "0,00";
            // 
            // txtQtd
            // 
            this.txtQtd.Location = new System.Drawing.Point(435, 111);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(100, 20);
            this.txtQtd.TabIndex = 56;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(538, 93);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 13);
            this.label12.TabIndex = 55;
            this.label12.Text = "Valor Unitario";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(432, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 54;
            this.label11.Text = "Quantidade";
            // 
            // lProduto
            // 
            this.lProduto.AutoSize = true;
            this.lProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lProduto.Location = new System.Drawing.Point(107, 93);
            this.lProduto.Name = "lProduto";
            this.lProduto.Size = new System.Drawing.Size(294, 13);
            this.lProduto.TabIndex = 53;
            this.lProduto.Text = "Informe o codigo do produto ou clique em localizar";
            // 
            // btLocProd
            // 
            this.btLocProd.Location = new System.Drawing.Point(364, 111);
            this.btLocProd.Name = "btLocProd";
            this.btLocProd.Size = new System.Drawing.Size(65, 23);
            this.btLocProd.TabIndex = 52;
            this.toolTip1.SetToolTip(this.btLocProd, "Localizar");
            this.btLocProd.UseVisualStyleBackColor = true;
            this.btLocProd.Click += new System.EventHandler(this.btLocProd_Click);
            // 
            // txtCodPro
            // 
            this.txtCodPro.Location = new System.Drawing.Point(6, 112);
            this.txtCodPro.Name = "txtCodPro";
            this.txtCodPro.Size = new System.Drawing.Size(352, 20);
            this.txtCodPro.TabIndex = 51;
            this.txtCodPro.Leave += new System.EventHandler(this.txtCodPro_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 13);
            this.label10.TabIndex = 50;
            this.label10.Text = "Código do Produto:";
            // 
            // lCliente
            // 
            this.lCliente.AutoSize = true;
            this.lCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCliente.Location = new System.Drawing.Point(158, 68);
            this.lCliente.Name = "lCliente";
            this.lCliente.Size = new System.Drawing.Size(384, 16);
            this.lCliente.TabIndex = 48;
            this.lCliente.Text = "Informe o código do fornecedor ou clique em Localizar";
            // 
            // btLocCli
            // 
            this.btLocCli.Location = new System.Drawing.Point(113, 52);
            this.btLocCli.Name = "btLocCli";
            this.btLocCli.Size = new System.Drawing.Size(39, 32);
            this.btLocCli.TabIndex = 47;
            this.toolTip1.SetToolTip(this.btLocCli, "Localizar");
            this.btLocCli.UseVisualStyleBackColor = true;
            this.btLocCli.Click += new System.EventHandler(this.btLocCli_Click);
            // 
            // txtCliCod
            // 
            this.txtCliCod.Location = new System.Drawing.Point(7, 65);
            this.txtCliCod.Name = "txtCliCod";
            this.txtCliCod.Size = new System.Drawing.Size(100, 20);
            this.txtCliCod.TabIndex = 46;
            this.txtCliCod.TextChanged += new System.EventHandler(this.txtCliCod_TextChanged);
            this.txtCliCod.Leave += new System.EventHandler(this.txtCliCod_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 45;
            this.label8.Text = "Código do Cliente";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // cbTpagto
            // 
            this.cbTpagto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbTpagto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbTpagto.FormattingEnabled = true;
            this.cbTpagto.Location = new System.Drawing.Point(139, 394);
            this.cbTpagto.Name = "cbTpagto";
            this.cbTpagto.Size = new System.Drawing.Size(121, 21);
            this.cbTpagto.TabIndex = 42;
            // 
            // txtTotalVenda
            // 
            this.txtTotalVenda.Enabled = false;
            this.txtTotalVenda.Location = new System.Drawing.Point(590, 397);
            this.txtTotalVenda.Name = "txtTotalVenda";
            this.txtTotalVenda.Size = new System.Drawing.Size(108, 20);
            this.txtTotalVenda.TabIndex = 41;
            this.txtTotalVenda.Text = "0,00";
            this.txtTotalVenda.TextChanged += new System.EventHandler(this.txtTotalVenda_TextChanged);
            // 
            // txtNFiscal
            // 
            this.txtNFiscal.Location = new System.Drawing.Point(112, 26);
            this.txtNFiscal.Name = "txtNFiscal";
            this.txtNFiscal.Size = new System.Drawing.Size(110, 20);
            this.txtNFiscal.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(602, 373);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 20);
            this.label7.TabIndex = 39;
            this.label7.Text = "Valor Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(361, 373);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Data Inicial do Pagamento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(136, 373);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Forma de Pagamento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 373);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Número de Parcelas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Data da Venda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Número da nota Fiscal";
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
            this.cbNParcelas.Location = new System.Drawing.Point(7, 394);
            this.cbNParcelas.Name = "cbNParcelas";
            this.cbNParcelas.Size = new System.Drawing.Size(121, 21);
            this.cbNParcelas.TabIndex = 33;
            this.cbNParcelas.Tag = "";
            // 
            // txtVenCodigo
            // 
            this.txtVenCodigo.Enabled = false;
            this.txtVenCodigo.Location = new System.Drawing.Point(6, 26);
            this.txtVenCodigo.Name = "txtVenCodigo";
            this.txtVenCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtVenCodigo.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Código";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(680, 16);
            this.label9.TabIndex = 49;
            this.label9.Text = "_________________________________________________________________________________" +
    "_______________";
            // 
            // cbVendaAVista
            // 
            this.cbVendaAVista.AutoSize = true;
            this.cbVendaAVista.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVendaAVista.Location = new System.Drawing.Point(266, 396);
            this.cbVendaAVista.Name = "cbVendaAVista";
            this.cbVendaAVista.Size = new System.Drawing.Size(104, 17);
            this.cbVendaAVista.TabIndex = 60;
            this.cbVendaAVista.Text = "Venda a vista";
            this.cbVendaAVista.UseVisualStyleBackColor = true;
            this.cbVendaAVista.CheckedChanged += new System.EventHandler(this.cbVendaAVista_CheckedChanged);
            // 
            // pnFinalizaVenda
            // 
            this.pnFinalizaVenda.Controls.Add(this.dgvParcelas);
            this.pnFinalizaVenda.Controls.Add(this.label17);
            this.pnFinalizaVenda.Controls.Add(this.lbTotal);
            this.pnFinalizaVenda.Controls.Add(this.lb);
            this.pnFinalizaVenda.Controls.Add(this.btnCancelar);
            this.pnFinalizaVenda.Controls.Add(this.btSalvarFinal);
            this.pnFinalizaVenda.Controls.Add(this.label14);
            this.pnFinalizaVenda.Controls.Add(this.label16);
            this.pnFinalizaVenda.Location = new System.Drawing.Point(3, 11);
            this.pnFinalizaVenda.Name = "pnFinalizaVenda";
            this.pnFinalizaVenda.Size = new System.Drawing.Size(730, 540);
            this.pnFinalizaVenda.TabIndex = 3;
            this.pnFinalizaVenda.Visible = false;
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvParcelas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvParcelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParcelas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pco_cod,
            this.pco_valor,
            this.pco_datavecto});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvParcelas.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvParcelas.EnableHeadersVisualStyles = false;
            this.dgvParcelas.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvParcelas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvParcelas.Location = new System.Drawing.Point(9, 26);
            this.dgvParcelas.Name = "dgvParcelas";
            this.dgvParcelas.ReadOnly = true;
            this.dgvParcelas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvParcelas.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvParcelas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvParcelas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvParcelas.Size = new System.Drawing.Size(689, 422);
            this.dgvParcelas.TabIndex = 26;
            // 
            // pco_cod
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pco_cod.DefaultCellStyle = dataGridViewCellStyle5;
            this.pco_cod.HeaderText = "Código";
            this.pco_cod.Name = "pco_cod";
            this.pco_cod.ReadOnly = true;
            // 
            // pco_valor
            // 
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pco_valor.DefaultCellStyle = dataGridViewCellStyle6;
            this.pco_valor.HeaderText = "Valor da parcela";
            this.pco_valor.Name = "pco_valor";
            this.pco_valor.ReadOnly = true;
            this.pco_valor.Width = 250;
            // 
            // pco_datavecto
            // 
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pco_datavecto.DefaultCellStyle = dataGridViewCellStyle7;
            this.pco_datavecto.HeaderText = "Data da Venda";
            this.pco_datavecto.Name = "pco_datavecto";
            this.pco_datavecto.ReadOnly = true;
            this.pco_datavecto.Width = 250;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.DarkTurquoise;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label17.Location = new System.Drawing.Point(508, 479);
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
            this.lbTotal.Location = new System.Drawing.Point(590, 479);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(108, 55);
            this.lbTotal.TabIndex = 24;
            this.lbTotal.Text = "000";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.Location = new System.Drawing.Point(516, 455);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(169, 25);
            this.lb.TabIndex = 23;
            this.lb.Text = "Total da venda";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::GUI.Properties.Resources.Cancelar;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(408, 457);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(92, 77);
            this.btnCancelar.TabIndex = 22;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btSalvarFinal
            // 
            this.btSalvarFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalvarFinal.Image = global::GUI.Properties.Resources.Salvar1_fw;
            this.btSalvarFinal.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btSalvarFinal.Location = new System.Drawing.Point(310, 457);
            this.btSalvarFinal.Name = "btSalvarFinal";
            this.btSalvarFinal.Size = new System.Drawing.Size(92, 77);
            this.btSalvarFinal.TabIndex = 21;
            this.btSalvarFinal.Text = "Salvar";
            this.btSalvarFinal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btSalvarFinal.UseVisualStyleBackColor = true;
            this.btSalvarFinal.Click += new System.EventHandler(this.btSalvarFinal_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 6);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "Dados do Pagamento";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(6, 6);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(680, 16);
            this.label16.TabIndex = 20;
            this.label16.Text = "_________________________________________________________________________________" +
    "_______________";
            // 
            // dtDataVenda
            // 
            this.dtDataVenda.Location = new System.Drawing.Point(228, 25);
            this.dtDataVenda.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtDataVenda.Name = "dtDataVenda";
            this.dtDataVenda.Size = new System.Drawing.Size(248, 29);
            this.dtDataVenda.TabIndex = 61;
            // 
            // dtDataini
            // 
            this.dtDataini.Location = new System.Drawing.Point(364, 392);
            this.dtDataini.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtDataini.Name = "dtDataini";
            this.dtDataini.Size = new System.Drawing.Size(220, 29);
            this.dtDataini.TabIndex = 62;
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
            this.forQtd,
            this.provund,
            this.provTotal});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItens.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvItens.EnableHeadersVisualStyles = false;
            this.dgvItens.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvItens.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvItens.Location = new System.Drawing.Point(7, 154);
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.ReadOnly = true;
            this.dgvItens.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItens.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvItens.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItens.Size = new System.Drawing.Size(691, 216);
            this.dgvItens.TabIndex = 63;
            this.toolTip1.SetToolTip(this.dgvItens, "Para retornar os valores para os campos click duas vezes no grid.");
            this.dgvItens.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItens_CellDoubleClick_1);
            // 
            // ProCod
            // 
            this.ProCod.HeaderText = "Código";
            this.ProCod.Name = "ProCod";
            this.ProCod.ReadOnly = true;
            // 
            // ForNome
            // 
            this.ForNome.HeaderText = "Nome";
            this.ForNome.Name = "ForNome";
            this.ForNome.ReadOnly = true;
            this.ForNome.Width = 250;
            // 
            // forQtd
            // 
            this.forQtd.HeaderText = "Quantidade";
            this.forQtd.Name = "forQtd";
            this.forQtd.ReadOnly = true;
            // 
            // provund
            // 
            this.provund.HeaderText = "Valor Unitario";
            this.provund.Name = "provund";
            this.provund.ReadOnly = true;
            // 
            // provTotal
            // 
            this.provTotal.HeaderText = "Valor Total";
            this.provTotal.Name = "provTotal";
            this.provTotal.ReadOnly = true;
            // 
            // lbMsg
            // 
            this.lbMsg.AutoSize = true;
            this.lbMsg.BackColor = System.Drawing.Color.White;
            this.lbMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMsg.ForeColor = System.Drawing.Color.Red;
            this.lbMsg.Location = new System.Drawing.Point(240, 266);
            this.lbMsg.Name = "lbMsg";
            this.lbMsg.Size = new System.Drawing.Size(198, 25);
            this.lbMsg.TabIndex = 64;
            this.lbMsg.Text = "Venda Cancelada";
            this.lbMsg.Visible = false;
            // 
            // iconeencerar
            // 
            this.iconeencerar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconeencerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconeencerar.Image = global::GUI.Properties.Resources.icon_cerrar2;
            this.iconeencerar.Location = new System.Drawing.Point(798, 12);
            this.iconeencerar.Name = "iconeencerar";
            this.iconeencerar.Size = new System.Drawing.Size(15, 15);
            this.iconeencerar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconeencerar.TabIndex = 47;
            this.iconeencerar.TabStop = false;
            this.iconeencerar.Click += new System.EventHandler(this.iconeencerar_Click);
            // 
            // frmMovimentacaoVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(825, 563);
            this.Controls.Add(this.pnFinalizaVenda);
            this.Controls.Add(this.iconeencerar);
            this.Name = "frmMovimentacaoVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movimentação - Venda";
            this.Load += new System.EventHandler(this.frmMovimentacaoVenda_Load);
            this.Controls.SetChildIndex(this.iconeencerar, 0);
            this.Controls.SetChildIndex(this.pnDados, 0);
            this.Controls.SetChildIndex(this.pnBotoes, 0);
            this.Controls.SetChildIndex(this.pnFinalizaVenda, 0);
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            this.pnBotoes.ResumeLayout(false);
            this.pnFinalizaVenda.ResumeLayout(false);
            this.pnFinalizaVenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconeencerar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btAddProd;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lProduto;
        private System.Windows.Forms.Button btLocProd;
        private System.Windows.Forms.TextBox txtCodPro;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lCliente;
        private System.Windows.Forms.Button btLocCli;
        private System.Windows.Forms.TextBox txtCliCod;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbTpagto;
        private System.Windows.Forms.TextBox txtTotalVenda;
        private System.Windows.Forms.TextBox txtNFiscal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbNParcelas;
        private System.Windows.Forms.TextBox txtVenCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox cbVendaAVista;
        private System.Windows.Forms.Panel pnFinalizaVenda;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lb;
        protected System.Windows.Forms.Button btnCancelar;
        protected System.Windows.Forms.Button btSalvarFinal;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private MetroFramework.Controls.MetroDateTime dtDataini;
        private MetroFramework.Controls.MetroDateTime dtDataVenda;
        private MetroFramework.Controls.MetroGrid dgvItens;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn ForNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn forQtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn provund;
        private System.Windows.Forms.DataGridViewTextBoxColumn provTotal;
        private Bunifu.Framework.UI.BunifuCustomLabel lbMsg;
        private MetroFramework.Controls.MetroGrid dgvParcelas;
        private System.Windows.Forms.DataGridViewTextBoxColumn pco_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn pco_valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn pco_datavecto;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox iconeencerar;
    }
}

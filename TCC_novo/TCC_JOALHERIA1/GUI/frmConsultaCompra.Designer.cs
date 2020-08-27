namespace GUI
{
    partial class frmConsultaCompra
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtTipo = new System.Windows.Forms.GroupBox();
            this.rbGeral = new System.Windows.Forms.RadioButton();
            this.rbParcelas = new System.Windows.Forms.RadioButton();
            this.rbData = new System.Windows.Forms.RadioButton();
            this.rbFornecedor = new System.Windows.Forms.RadioButton();
            this.pFornecedor = new System.Windows.Forms.Panel();
            this.lbForNome = new System.Windows.Forms.Label();
            this.btLocFornecedor = new System.Windows.Forms.Button();
            this.txtForCod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pData = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnLocData = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbcDados = new System.Windows.Forms.TabControl();
            this.tpCompra = new System.Windows.Forms.TabPage();
            this.dgvDados = new MetroFramework.Controls.MetroGrid();
            this.tpItens = new System.Windows.Forms.TabPage();
            this.dgvItens = new MetroFramework.Controls.MetroGrid();
            this.tpParcelas = new System.Windows.Forms.TabPage();
            this.dgvParcelas = new MetroFramework.Controls.MetroGrid();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.iconeencerar = new System.Windows.Forms.PictureBox();
            this.txtTipo.SuspendLayout();
            this.pFornecedor.SuspendLayout();
            this.pData.SuspendLayout();
            this.tbcDados.SuspendLayout();
            this.tpCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.tpItens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            this.tpParcelas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconeencerar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTipo
            // 
            this.txtTipo.Controls.Add(this.iconeencerar);
            this.txtTipo.Controls.Add(this.rbGeral);
            this.txtTipo.Controls.Add(this.rbParcelas);
            this.txtTipo.Controls.Add(this.rbData);
            this.txtTipo.Controls.Add(this.rbFornecedor);
            this.txtTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtTipo.Location = new System.Drawing.Point(12, 13);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(836, 50);
            this.txtTipo.TabIndex = 17;
            this.txtTipo.TabStop = false;
            this.txtTipo.Text = "Consultar Por";
            // 
            // rbGeral
            // 
            this.rbGeral.AutoSize = true;
            this.rbGeral.Checked = true;
            this.rbGeral.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbGeral.Location = new System.Drawing.Point(6, 21);
            this.rbGeral.Name = "rbGeral";
            this.rbGeral.Size = new System.Drawing.Size(156, 20);
            this.rbGeral.TabIndex = 3;
            this.rbGeral.TabStop = true;
            this.rbGeral.Text = "Todas as compras";
            this.rbGeral.UseVisualStyleBackColor = true;
            this.rbGeral.CheckedChanged += new System.EventHandler(this.rbGeral_CheckedChanged);
            // 
            // rbParcelas
            // 
            this.rbParcelas.AutoSize = true;
            this.rbParcelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbParcelas.Location = new System.Drawing.Point(491, 21);
            this.rbParcelas.Name = "rbParcelas";
            this.rbParcelas.Size = new System.Drawing.Size(162, 20);
            this.rbParcelas.TabIndex = 2;
            this.rbParcelas.Text = "Parcelas em aberto";
            this.rbParcelas.UseVisualStyleBackColor = true;
            this.rbParcelas.CheckedChanged += new System.EventHandler(this.rbGeral_CheckedChanged);
            // 
            // rbData
            // 
            this.rbData.AutoSize = true;
            this.rbData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbData.Location = new System.Drawing.Point(326, 21);
            this.rbData.Name = "rbData";
            this.rbData.Size = new System.Drawing.Size(137, 20);
            this.rbData.TabIndex = 1;
            this.rbData.Text = "Data da compra";
            this.rbData.UseVisualStyleBackColor = true;
            this.rbData.CheckedChanged += new System.EventHandler(this.rbGeral_CheckedChanged);
            // 
            // rbFornecedor
            // 
            this.rbFornecedor.AutoSize = true;
            this.rbFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFornecedor.Location = new System.Drawing.Point(188, 21);
            this.rbFornecedor.Name = "rbFornecedor";
            this.rbFornecedor.Size = new System.Drawing.Size(106, 20);
            this.rbFornecedor.TabIndex = 0;
            this.rbFornecedor.Text = "Fornecedor";
            this.rbFornecedor.UseVisualStyleBackColor = true;
            this.rbFornecedor.CheckedChanged += new System.EventHandler(this.rbGeral_CheckedChanged);
            // 
            // pFornecedor
            // 
            this.pFornecedor.Controls.Add(this.lbForNome);
            this.pFornecedor.Controls.Add(this.btLocFornecedor);
            this.pFornecedor.Controls.Add(this.txtForCod);
            this.pFornecedor.Controls.Add(this.label1);
            this.pFornecedor.Location = new System.Drawing.Point(12, 69);
            this.pFornecedor.Name = "pFornecedor";
            this.pFornecedor.Size = new System.Drawing.Size(836, 59);
            this.pFornecedor.TabIndex = 18;
            // 
            // lbForNome
            // 
            this.lbForNome.AutoSize = true;
            this.lbForNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbForNome.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbForNome.Location = new System.Drawing.Point(181, 12);
            this.lbForNome.Name = "lbForNome";
            this.lbForNome.Size = new System.Drawing.Size(155, 16);
            this.lbForNome.TabIndex = 3;
            this.lbForNome.Text = "Nome do Fornecedor";
            // 
            // btLocFornecedor
            // 
            this.btLocFornecedor.Location = new System.Drawing.Point(174, 31);
            this.btLocFornecedor.Name = "btLocFornecedor";
            this.btLocFornecedor.Size = new System.Drawing.Size(162, 23);
            this.btLocFornecedor.TabIndex = 2;
            this.btLocFornecedor.Text = "Localizar Fornecedor";
            this.btLocFornecedor.UseVisualStyleBackColor = true;
            this.btLocFornecedor.Click += new System.EventHandler(this.btLocFornecedor_Click);
            // 
            // txtForCod
            // 
            this.txtForCod.Enabled = false;
            this.txtForCod.Location = new System.Drawing.Point(6, 34);
            this.txtForCod.Name = "txtForCod";
            this.txtForCod.Size = new System.Drawing.Size(162, 20);
            this.txtForCod.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(7, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código do fornecedor";
            // 
            // pData
            // 
            this.pData.Controls.Add(this.label2);
            this.pData.Controls.Add(this.dateTimePicker2);
            this.pData.Controls.Add(this.dateTimePicker1);
            this.pData.Controls.Add(this.btnLocData);
            this.pData.Controls.Add(this.label3);
            this.pData.Location = new System.Drawing.Point(12, 68);
            this.pData.Name = "pData";
            this.pData.Size = new System.Drawing.Size(836, 56);
            this.pData.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(284, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Data Final";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(287, 27);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(248, 20);
            this.dateTimePicker2.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 28);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(263, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // btnLocData
            // 
            this.btnLocData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocData.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLocData.Location = new System.Drawing.Point(575, 13);
            this.btnLocData.Name = "btnLocData";
            this.btnLocData.Size = new System.Drawing.Size(200, 34);
            this.btnLocData.TabIndex = 2;
            this.btnLocData.Text = "Localizar";
            this.btnLocData.UseVisualStyleBackColor = true;
            this.btnLocData.Click += new System.EventHandler(this.btnLocData_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(3, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Data Inicial";
            // 
            // tbcDados
            // 
            this.tbcDados.Controls.Add(this.tpCompra);
            this.tbcDados.Controls.Add(this.tpItens);
            this.tbcDados.Controls.Add(this.tpParcelas);
            this.tbcDados.Location = new System.Drawing.Point(12, 129);
            this.tbcDados.Name = "tbcDados";
            this.tbcDados.SelectedIndex = 0;
            this.tbcDados.Size = new System.Drawing.Size(836, 412);
            this.tbcDados.TabIndex = 20;
            // 
            // tpCompra
            // 
            this.tpCompra.Controls.Add(this.dgvDados);
            this.tpCompra.Location = new System.Drawing.Point(4, 22);
            this.tpCompra.Name = "tpCompra";
            this.tpCompra.Padding = new System.Windows.Forms.Padding(3);
            this.tpCompra.Size = new System.Drawing.Size(828, 386);
            this.tpCompra.TabIndex = 0;
            this.tpCompra.Text = "Compras";
            this.tpCompra.UseVisualStyleBackColor = true;
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToAddRows = false;
            this.dgvDados.AllowUserToDeleteRows = false;
            this.dgvDados.AllowUserToResizeRows = false;
            this.dgvDados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvDados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvDados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDados.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDados.EnableHeadersVisualStyles = false;
            this.dgvDados.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvDados.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvDados.Location = new System.Drawing.Point(3, 3);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.ReadOnly = true;
            this.dgvDados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDados.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDados.Size = new System.Drawing.Size(822, 380);
            this.dgvDados.TabIndex = 17;
            this.dgvDados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellClick);
            this.dgvDados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellDoubleClick);
            // 
            // tpItens
            // 
            this.tpItens.Controls.Add(this.dgvItens);
            this.tpItens.Location = new System.Drawing.Point(4, 22);
            this.tpItens.Name = "tpItens";
            this.tpItens.Padding = new System.Windows.Forms.Padding(3);
            this.tpItens.Size = new System.Drawing.Size(828, 386);
            this.tpItens.TabIndex = 1;
            this.tpItens.Text = "Itens da compra selecionadas";
            this.tpItens.UseVisualStyleBackColor = true;
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItens.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItens.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvItens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItens.EnableHeadersVisualStyles = false;
            this.dgvItens.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvItens.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvItens.Location = new System.Drawing.Point(3, 3);
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.ReadOnly = true;
            this.dgvItens.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItens.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvItens.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItens.Size = new System.Drawing.Size(822, 380);
            this.dgvItens.TabIndex = 0;
            // 
            // tpParcelas
            // 
            this.tpParcelas.Controls.Add(this.dgvParcelas);
            this.tpParcelas.Location = new System.Drawing.Point(4, 22);
            this.tpParcelas.Name = "tpParcelas";
            this.tpParcelas.Padding = new System.Windows.Forms.Padding(3);
            this.tpParcelas.Size = new System.Drawing.Size(828, 386);
            this.tpParcelas.TabIndex = 2;
            this.tpParcelas.Text = "Parcelas da compra selecionadas";
            this.tpParcelas.UseVisualStyleBackColor = true;
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvParcelas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvParcelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvParcelas.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvParcelas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvParcelas.EnableHeadersVisualStyles = false;
            this.dgvParcelas.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvParcelas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvParcelas.Location = new System.Drawing.Point(3, 3);
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
            this.dgvParcelas.Size = new System.Drawing.Size(822, 380);
            this.dgvParcelas.TabIndex = 0;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 45;
            this.bunifuElipse1.TargetControl = this;
            // 
            // iconeencerar
            // 
            this.iconeencerar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconeencerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconeencerar.Image = global::GUI.Properties.Resources.cerrar;
            this.iconeencerar.Location = new System.Drawing.Point(814, 26);
            this.iconeencerar.Name = "iconeencerar";
            this.iconeencerar.Size = new System.Drawing.Size(15, 15);
            this.iconeencerar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconeencerar.TabIndex = 50;
            this.iconeencerar.TabStop = false;
            this.iconeencerar.Click += new System.EventHandler(this.iconeencerar_Click);
            // 
            // frmConsultaCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(11)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(860, 553);
            this.Controls.Add(this.pData);
            this.Controls.Add(this.tbcDados);
            this.Controls.Add(this.pFornecedor);
            this.Controls.Add(this.txtTipo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConsultaCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de compras";
            this.Load += new System.EventHandler(this.frmConsultaCompra_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmConsultaCompra_MouseDown);
            this.txtTipo.ResumeLayout(false);
            this.txtTipo.PerformLayout();
            this.pFornecedor.ResumeLayout(false);
            this.pFornecedor.PerformLayout();
            this.pData.ResumeLayout(false);
            this.pData.PerformLayout();
            this.tbcDados.ResumeLayout(false);
            this.tpCompra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.tpItens.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            this.tpParcelas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconeencerar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox txtTipo;
        private System.Windows.Forms.RadioButton rbGeral;
        private System.Windows.Forms.RadioButton rbParcelas;
        private System.Windows.Forms.RadioButton rbData;
        private System.Windows.Forms.RadioButton rbFornecedor;
        private System.Windows.Forms.Panel pFornecedor;
        private System.Windows.Forms.Button btLocFornecedor;
        private System.Windows.Forms.TextBox txtForCod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbForNome;
        private System.Windows.Forms.Panel pData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnLocData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tbcDados;
        private System.Windows.Forms.TabPage tpCompra;
        private System.Windows.Forms.TabPage tpItens;
        private System.Windows.Forms.TabPage tpParcelas;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private MetroFramework.Controls.MetroGrid dgvDados;
        private MetroFramework.Controls.MetroGrid dgvItens;
        private MetroFramework.Controls.MetroGrid dgvParcelas;
        private System.Windows.Forms.PictureBox iconeencerar;
    }
}
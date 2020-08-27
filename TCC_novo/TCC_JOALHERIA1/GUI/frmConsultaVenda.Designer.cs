namespace GUI
{
    partial class frmConsultaVenda
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbcDados = new System.Windows.Forms.TabControl();
            this.tpVenda = new System.Windows.Forms.TabPage();
            this.dgvDados = new MetroFramework.Controls.MetroGrid();
            this.tpItens = new System.Windows.Forms.TabPage();
            this.dgvItens = new MetroFramework.Controls.MetroGrid();
            this.tpParcelas = new System.Windows.Forms.TabPage();
            this.dgvParcelas = new MetroFramework.Controls.MetroGrid();
            this.pData = new System.Windows.Forms.Panel();
            this.data2 = new MetroFramework.Controls.MetroDateTime();
            this.label2 = new System.Windows.Forms.Label();
            this.data1 = new MetroFramework.Controls.MetroDateTime();
            this.btnLocData = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pCliente = new System.Windows.Forms.Panel();
            this.lbCliNome = new System.Windows.Forms.Label();
            this.btLocCliente = new System.Windows.Forms.Button();
            this.txtCliCod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.GroupBox();
            this.rbGeral = new System.Windows.Forms.RadioButton();
            this.rbParcelas = new System.Windows.Forms.RadioButton();
            this.rbData = new System.Windows.Forms.RadioButton();
            this.rbCliente = new System.Windows.Forms.RadioButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.iconeencerar = new System.Windows.Forms.PictureBox();
            this.tbcDados.SuspendLayout();
            this.tpVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.tpItens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            this.tpParcelas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelas)).BeginInit();
            this.pData.SuspendLayout();
            this.pCliente.SuspendLayout();
            this.txtTipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconeencerar)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcDados
            // 
            this.tbcDados.Controls.Add(this.tpVenda);
            this.tbcDados.Controls.Add(this.tpItens);
            this.tbcDados.Controls.Add(this.tpParcelas);
            this.tbcDados.Location = new System.Drawing.Point(12, 120);
            this.tbcDados.Name = "tbcDados";
            this.tbcDados.SelectedIndex = 0;
            this.tbcDados.Size = new System.Drawing.Size(820, 382);
            this.tbcDados.TabIndex = 24;
            // 
            // tpVenda
            // 
            this.tpVenda.Controls.Add(this.dgvDados);
            this.tpVenda.Location = new System.Drawing.Point(4, 22);
            this.tpVenda.Name = "tpVenda";
            this.tpVenda.Padding = new System.Windows.Forms.Padding(3);
            this.tpVenda.Size = new System.Drawing.Size(812, 356);
            this.tpVenda.TabIndex = 0;
            this.tpVenda.Text = "Vendas";
            this.tpVenda.UseVisualStyleBackColor = true;
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
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDados.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvDados.EnableHeadersVisualStyles = false;
            this.dgvDados.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvDados.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvDados.Location = new System.Drawing.Point(2, 3);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.ReadOnly = true;
            this.dgvDados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDados.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvDados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDados.Size = new System.Drawing.Size(806, 347);
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
            this.tpItens.Size = new System.Drawing.Size(812, 356);
            this.tpItens.TabIndex = 1;
            this.tpItens.Text = "Itens da venda selecionadas";
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
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItens.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItens.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvItens.EnableHeadersVisualStyles = false;
            this.dgvItens.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvItens.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvItens.Location = new System.Drawing.Point(3, 3);
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.ReadOnly = true;
            this.dgvItens.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItens.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvItens.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItens.Size = new System.Drawing.Size(806, 350);
            this.dgvItens.TabIndex = 0;
            // 
            // tpParcelas
            // 
            this.tpParcelas.Controls.Add(this.dgvParcelas);
            this.tpParcelas.Location = new System.Drawing.Point(4, 22);
            this.tpParcelas.Name = "tpParcelas";
            this.tpParcelas.Padding = new System.Windows.Forms.Padding(3);
            this.tpParcelas.Size = new System.Drawing.Size(812, 356);
            this.tpParcelas.TabIndex = 2;
            this.tpParcelas.Text = "Parcelas da venda selecionadas";
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
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvParcelas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvParcelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvParcelas.DefaultCellStyle = dataGridViewCellStyle17;
            this.dgvParcelas.EnableHeadersVisualStyles = false;
            this.dgvParcelas.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvParcelas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvParcelas.Location = new System.Drawing.Point(3, 3);
            this.dgvParcelas.Name = "dgvParcelas";
            this.dgvParcelas.ReadOnly = true;
            this.dgvParcelas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvParcelas.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvParcelas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvParcelas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvParcelas.Size = new System.Drawing.Size(806, 350);
            this.dgvParcelas.TabIndex = 0;
            // 
            // pData
            // 
            this.pData.Controls.Add(this.data2);
            this.pData.Controls.Add(this.label2);
            this.pData.Controls.Add(this.data1);
            this.pData.Controls.Add(this.btnLocData);
            this.pData.Controls.Add(this.label3);
            this.pData.Location = new System.Drawing.Point(12, 59);
            this.pData.Name = "pData";
            this.pData.Size = new System.Drawing.Size(820, 55);
            this.pData.TabIndex = 23;
            // 
            // data2
            // 
            this.data2.Location = new System.Drawing.Point(261, 22);
            this.data2.MinimumSize = new System.Drawing.Size(0, 29);
            this.data2.Name = "data2";
            this.data2.Size = new System.Drawing.Size(245, 29);
            this.data2.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(257, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Data Final";
            // 
            // data1
            // 
            this.data1.Location = new System.Drawing.Point(4, 23);
            this.data1.MinimumSize = new System.Drawing.Size(0, 29);
            this.data1.Name = "data1";
            this.data1.Size = new System.Drawing.Size(251, 29);
            this.data1.TabIndex = 18;
            // 
            // btnLocData
            // 
            this.btnLocData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocData.Location = new System.Drawing.Point(532, 22);
            this.btnLocData.Name = "btnLocData";
            this.btnLocData.Size = new System.Drawing.Size(188, 28);
            this.btnLocData.TabIndex = 2;
            this.btnLocData.Text = "Localizar";
            this.btnLocData.UseVisualStyleBackColor = true;
            this.btnLocData.Click += new System.EventHandler(this.btnLocData_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(1, -1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Data Inicial";
            // 
            // pCliente
            // 
            this.pCliente.Controls.Add(this.lbCliNome);
            this.pCliente.Controls.Add(this.btLocCliente);
            this.pCliente.Controls.Add(this.txtCliCod);
            this.pCliente.Controls.Add(this.label1);
            this.pCliente.Location = new System.Drawing.Point(12, 59);
            this.pCliente.Name = "pCliente";
            this.pCliente.Size = new System.Drawing.Size(820, 55);
            this.pCliente.TabIndex = 22;
            // 
            // lbCliNome
            // 
            this.lbCliNome.AutoSize = true;
            this.lbCliNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCliNome.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbCliNome.Location = new System.Drawing.Point(170, 5);
            this.lbCliNome.Name = "lbCliNome";
            this.lbCliNome.Size = new System.Drawing.Size(138, 20);
            this.lbCliNome.TabIndex = 3;
            this.lbCliNome.Text = "Nome do cliente";
            // 
            // btLocCliente
            // 
            this.btLocCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLocCliente.Location = new System.Drawing.Point(174, 28);
            this.btLocCliente.Name = "btLocCliente";
            this.btLocCliente.Size = new System.Drawing.Size(192, 24);
            this.btLocCliente.TabIndex = 2;
            this.btLocCliente.Text = "Localizar Cliente";
            this.btLocCliente.UseVisualStyleBackColor = true;
            this.btLocCliente.Click += new System.EventHandler(this.btLocCliente_Click);
            // 
            // txtCliCod
            // 
            this.txtCliCod.Enabled = false;
            this.txtCliCod.Location = new System.Drawing.Point(6, 28);
            this.txtCliCod.Multiline = true;
            this.txtCliCod.Name = "txtCliCod";
            this.txtCliCod.Size = new System.Drawing.Size(162, 24);
            this.txtCliCod.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(7, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código do cliente";
            // 
            // txtTipo
            // 
            this.txtTipo.Controls.Add(this.iconeencerar);
            this.txtTipo.Controls.Add(this.rbGeral);
            this.txtTipo.Controls.Add(this.rbParcelas);
            this.txtTipo.Controls.Add(this.rbData);
            this.txtTipo.Controls.Add(this.rbCliente);
            this.txtTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtTipo.Location = new System.Drawing.Point(12, 3);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(820, 50);
            this.txtTipo.TabIndex = 21;
            this.txtTipo.TabStop = false;
            this.txtTipo.Text = "Consultar Por";
            // 
            // rbGeral
            // 
            this.rbGeral.AutoSize = true;
            this.rbGeral.Checked = true;
            this.rbGeral.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbGeral.Location = new System.Drawing.Point(11, 20);
            this.rbGeral.Name = "rbGeral";
            this.rbGeral.Size = new System.Drawing.Size(147, 24);
            this.rbGeral.TabIndex = 3;
            this.rbGeral.TabStop = true;
            this.rbGeral.Text = "Todas as vendas";
            this.rbGeral.UseVisualStyleBackColor = true;
            this.rbGeral.CheckedChanged += new System.EventHandler(this.rbGeral_CheckedChanged);
            // 
            // rbParcelas
            // 
            this.rbParcelas.AutoSize = true;
            this.rbParcelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbParcelas.Location = new System.Drawing.Point(606, 20);
            this.rbParcelas.Name = "rbParcelas";
            this.rbParcelas.Size = new System.Drawing.Size(164, 24);
            this.rbParcelas.TabIndex = 2;
            this.rbParcelas.Text = "Parcelas em aberto";
            this.rbParcelas.UseVisualStyleBackColor = true;
            this.rbParcelas.CheckedChanged += new System.EventHandler(this.rbGeral_CheckedChanged);
            // 
            // rbData
            // 
            this.rbData.AutoSize = true;
            this.rbData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbData.Location = new System.Drawing.Point(422, 20);
            this.rbData.Name = "rbData";
            this.rbData.Size = new System.Drawing.Size(131, 24);
            this.rbData.TabIndex = 1;
            this.rbData.Text = "Data da venda";
            this.rbData.UseVisualStyleBackColor = true;
            this.rbData.CheckedChanged += new System.EventHandler(this.rbGeral_CheckedChanged);
            // 
            // rbCliente
            // 
            this.rbCliente.AutoSize = true;
            this.rbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCliente.Location = new System.Drawing.Point(252, 20);
            this.rbCliente.Name = "rbCliente";
            this.rbCliente.Size = new System.Drawing.Size(76, 24);
            this.rbCliente.TabIndex = 0;
            this.rbCliente.Text = "Cliente";
            this.rbCliente.UseVisualStyleBackColor = true;
            this.rbCliente.CheckedChanged += new System.EventHandler(this.rbGeral_CheckedChanged);
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
            this.iconeencerar.Location = new System.Drawing.Point(797, 20);
            this.iconeencerar.Name = "iconeencerar";
            this.iconeencerar.Size = new System.Drawing.Size(15, 15);
            this.iconeencerar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconeencerar.TabIndex = 48;
            this.iconeencerar.TabStop = false;
            this.iconeencerar.Click += new System.EventHandler(this.iconeencerar_Click);
            // 
            // frmConsultaVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(11)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(844, 514);
            this.Controls.Add(this.tbcDados);
            this.Controls.Add(this.pData);
            this.Controls.Add(this.pCliente);
            this.Controls.Add(this.txtTipo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConsultaVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConsultaVenda";
            this.Load += new System.EventHandler(this.frmConsultaVenda_Load);
            this.tbcDados.ResumeLayout(false);
            this.tpVenda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.tpItens.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            this.tpParcelas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelas)).EndInit();
            this.pData.ResumeLayout(false);
            this.pData.PerformLayout();
            this.pCliente.ResumeLayout(false);
            this.pCliente.PerformLayout();
            this.txtTipo.ResumeLayout(false);
            this.txtTipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconeencerar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcDados;
        private System.Windows.Forms.TabPage tpVenda;
        private System.Windows.Forms.TabPage tpItens;
        private System.Windows.Forms.TabPage tpParcelas;
        private System.Windows.Forms.Panel pData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLocData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pCliente;
        private System.Windows.Forms.Label lbCliNome;
        private System.Windows.Forms.Button btLocCliente;
        private System.Windows.Forms.TextBox txtCliCod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox txtTipo;
        private System.Windows.Forms.RadioButton rbGeral;
        private System.Windows.Forms.RadioButton rbParcelas;
        private System.Windows.Forms.RadioButton rbData;
        private System.Windows.Forms.RadioButton rbCliente;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private MetroFramework.Controls.MetroGrid dgvDados;
        private MetroFramework.Controls.MetroGrid dgvItens;
        private MetroFramework.Controls.MetroGrid dgvParcelas;
        private MetroFramework.Controls.MetroDateTime data2;
        private MetroFramework.Controls.MetroDateTime data1;
        private System.Windows.Forms.PictureBox iconeencerar;
    }
}
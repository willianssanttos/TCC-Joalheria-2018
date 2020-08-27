namespace GUI
{
    partial class frmCadastroDeFatura
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdata = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeFatura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtsubtotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtpreco = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtquantidade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdescricao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnApagarf = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnApagarTudo = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTaxa = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSub = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCliente);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtdata);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNomeFatura);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(640, 67);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(472, 29);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(162, 24);
            this.txtCliente.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(413, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cliente";
            // 
            // txtdata
            // 
            this.txtdata.Location = new System.Drawing.Point(296, 29);
            this.txtdata.Name = "txtdata";
            this.txtdata.Size = new System.Drawing.Size(100, 24);
            this.txtdata.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data Atual";
            // 
            // txtNomeFatura
            // 
            this.txtNomeFatura.Location = new System.Drawing.Point(102, 29);
            this.txtNomeFatura.Name = "txtNomeFatura";
            this.txtNomeFatura.Size = new System.Drawing.Size(100, 24);
            this.txtNomeFatura.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nº da Fatura";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSalvar);
            this.groupBox2.Controls.Add(this.txtsubtotal);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtpreco);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtquantidade);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtdescricao);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtcodigo);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(640, 109);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Produto";
            // 
            // txtsubtotal
            // 
            this.txtsubtotal.Location = new System.Drawing.Point(260, 65);
            this.txtsubtotal.Name = "txtsubtotal";
            this.txtsubtotal.Size = new System.Drawing.Size(100, 24);
            this.txtsubtotal.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(178, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 18);
            this.label8.TabIndex = 8;
            this.label8.Text = "SubTotal";
            // 
            // txtpreco
            // 
            this.txtpreco.Location = new System.Drawing.Point(431, 29);
            this.txtpreco.Name = "txtpreco";
            this.txtpreco.Size = new System.Drawing.Size(100, 24);
            this.txtpreco.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(377, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Preço";
            // 
            // txtquantidade
            // 
            this.txtquantidade.Location = new System.Drawing.Point(103, 65);
            this.txtquantidade.Name = "txtquantidade";
            this.txtquantidade.Size = new System.Drawing.Size(66, 24);
            this.txtquantidade.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Quantidade";
            // 
            // txtdescricao
            // 
            this.txtdescricao.Location = new System.Drawing.Point(261, 32);
            this.txtdescricao.Name = "txtdescricao";
            this.txtdescricao.Size = new System.Drawing.Size(100, 24);
            this.txtdescricao.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(178, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Descrição";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(103, 29);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(66, 24);
            this.txtcodigo.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Código";
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnApagar);
            this.groupBox3.Controls.Add(this.btnApagarTudo);
            this.groupBox3.Controls.Add(this.metroGrid1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 212);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(640, 231);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Faturas";
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToAddRows = false;
            this.metroGrid1.AllowUserToDeleteRows = false;
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(9, 23);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.ReadOnly = true;
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(503, 194);
            this.metroGrid1.TabIndex = 11;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnMenu);
            this.groupBox4.Controls.Add(this.btnSair);
            this.groupBox4.Controls.Add(this.btnApagarf);
            this.groupBox4.Controls.Add(this.btnFinalizar);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 449);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(313, 147);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ações";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtTotal);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.txtTaxa);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.txtDesconto);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.txtSub);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(339, 449);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(313, 147);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Resumo";
            // 
            // btnMenu
            // 
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.Location = new System.Drawing.Point(153, 94);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(137, 38);
            this.btnMenu.TabIndex = 16;
            this.btnMenu.Text = "Menu";
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMenu.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
           
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(9, 94);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(118, 38);
            this.btnSair.TabIndex = 15;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // btnApagarf
            // 
            this.btnApagarf.FlatAppearance.BorderSize = 0;
            this.btnApagarf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
          
            this.btnApagarf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApagarf.Location = new System.Drawing.Point(153, 32);
            this.btnApagarf.Name = "btnApagarf";
            this.btnApagarf.Size = new System.Drawing.Size(137, 38);
            this.btnApagarf.TabIndex = 14;
            this.btnApagarf.Text = "Apagar";
            this.btnApagarf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnApagarf.UseVisualStyleBackColor = true;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.FlatAppearance.BorderSize = 0;
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         
            this.btnFinalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinalizar.Location = new System.Drawing.Point(9, 32);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(137, 38);
            this.btnFinalizar.TabIndex = 13;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroToolTip1.SetToolTip(this.btnFinalizar, "Apagar Tudo");
            this.btnFinalizar.UseVisualStyleBackColor = true;
            // 
            // btnApagar
            // 
            this.btnApagar.FlatAppearance.BorderSize = 0;
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
           
            this.btnApagar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnApagar.Location = new System.Drawing.Point(518, 23);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(105, 94);
            this.btnApagar.TabIndex = 13;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroToolTip1.SetToolTip(this.btnApagar, "Apagar");
            this.btnApagar.UseVisualStyleBackColor = true;
            // 
            // btnApagarTudo
            // 
            this.btnApagarTudo.FlatAppearance.BorderSize = 0;
            this.btnApagarTudo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
          
            this.btnApagarTudo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnApagarTudo.Location = new System.Drawing.Point(518, 123);
            this.btnApagarTudo.Name = "btnApagarTudo";
            this.btnApagarTudo.Size = new System.Drawing.Size(105, 94);
            this.btnApagarTudo.TabIndex = 12;
            this.btnApagarTudo.Text = "Apagar Tudo";
            this.btnApagarTudo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroToolTip1.SetToolTip(this.btnApagarTudo, "Apagar Tudo");
            this.btnApagarTudo.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
           
            this.btnSalvar.Location = new System.Drawing.Point(548, 19);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 84);
            this.btnSalvar.TabIndex = 10;
            this.metroToolTip1.SetToolTip(this.btnSalvar, "Salvar");
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(114, 116);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(154, 24);
            this.txtTotal.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 18);
            this.label9.TabIndex = 16;
            this.label9.Text = "SubTotal";
            // 
            // txtTaxa
            // 
            this.txtTaxa.Location = new System.Drawing.Point(114, 56);
            this.txtTaxa.Name = "txtTaxa";
            this.txtTaxa.Size = new System.Drawing.Size(154, 24);
            this.txtTaxa.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 18);
            this.label10.TabIndex = 14;
            this.label10.Text = "Taxas";
            // 
            // txtDesconto
            // 
            this.txtDesconto.Location = new System.Drawing.Point(114, 86);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(154, 24);
            this.txtDesconto.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(31, 119);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 18);
            this.label11.TabIndex = 12;
            this.label11.Text = "TotalGeral";
            // 
            // txtSub
            // 
            this.txtSub.Location = new System.Drawing.Point(114, 26);
            this.txtSub.Name = "txtSub";
            this.txtSub.Size = new System.Drawing.Size(154, 24);
            this.txtSub.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(31, 89);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 18);
            this.label12.TabIndex = 10;
            this.label12.Text = "Desconto";
            // 
            // frmCadastroDeFatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 606);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadastroDeFatura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtdata;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeFatura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSalvar;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private System.Windows.Forms.TextBox txtsubtotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtpreco;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtquantidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdescricao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnApagarTudo;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnApagarf;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTaxa;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSub;
        private System.Windows.Forms.Label label12;
    }
}
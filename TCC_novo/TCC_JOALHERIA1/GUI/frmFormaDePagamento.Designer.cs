namespace GUI
{
    partial class frmFormaDePagamento
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
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.topo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPago = new System.Windows.Forms.Label();
            this.lblTroco = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtDataini = new MetroFramework.Controls.MetroDateTime();
            this.cbVendaAVista = new System.Windows.Forms.CheckBox();
            this.cbTpagto = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbNParcelas = new System.Windows.Forms.ComboBox();
            this.topo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 45;
            this.bunifuElipse1.TargetControl = this;
            // 
            // topo
            // 
            this.topo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(11)))), ((int)(((byte)(83)))));
            this.topo.Controls.Add(this.label1);
            this.topo.Dock = System.Windows.Forms.DockStyle.Top;
            this.topo.Location = new System.Drawing.Point(0, 0);
            this.topo.Name = "topo";
            this.topo.Size = new System.Drawing.Size(673, 60);
            this.topo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(151, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Forma de Pagamento";
            // 
            // lblPago
            // 
            this.lblPago.AutoSize = true;
            this.lblPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblPago.Location = new System.Drawing.Point(53, 30);
            this.lblPago.Name = "lblPago";
            this.lblPago.Size = new System.Drawing.Size(116, 31);
            this.lblPago.TabIndex = 25;
            this.lblPago.Text = "R$ 0,00";
            this.lblPago.Click += new System.EventHandler(this.frmFormaDePagamento_Load);
            // 
            // lblTroco
            // 
            this.lblTroco.AutoSize = true;
            this.lblTroco.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTroco.ForeColor = System.Drawing.Color.Blue;
            this.lblTroco.Location = new System.Drawing.Point(53, 29);
            this.lblTroco.Name = "lblTroco";
            this.lblTroco.Size = new System.Drawing.Size(116, 31);
            this.lblTroco.TabIndex = 27;
            this.lblTroco.Text = "R$ 0,00";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(337, 339);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(111, 20);
            this.label15.TabIndex = 28;
            this.label15.Text = "MENSAGEM";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(337, 375);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(211, 20);
            this.label16.TabIndex = 29;
            this.label16.Text = "Obrigado e Volte Sempre";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(337, 409);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(54, 13);
            this.label17.TabIndex = 30;
            this.label17.Text = "Operador:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(397, 409);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(51, 13);
            this.lblNome.TabIndex = 31;
            this.lblNome.Text = "Operador";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTotal);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(341, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 74);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TOTAL";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Red;
            this.lblTotal.Location = new System.Drawing.Point(53, 34);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(116, 31);
            this.lblTotal.TabIndex = 18;
            this.lblTotal.Text = "R$ 0,00";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblPago);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(341, 167);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(254, 74);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PAGO";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblTroco);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(341, 247);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(254, 74);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "TROCO";
            // 
            // dtDataini
            // 
            this.dtDataini.Location = new System.Drawing.Point(128, 272);
            this.dtDataini.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtDataini.Name = "dtDataini";
            this.dtDataini.Size = new System.Drawing.Size(220, 29);
            this.dtDataini.TabIndex = 69;
            // 
            // cbVendaAVista
            // 
            this.cbVendaAVista.AutoSize = true;
            this.cbVendaAVista.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVendaAVista.Location = new System.Drawing.Point(30, 276);
            this.cbVendaAVista.Name = "cbVendaAVista";
            this.cbVendaAVista.Size = new System.Drawing.Size(104, 17);
            this.cbVendaAVista.TabIndex = 68;
            this.cbVendaAVista.Text = "Venda a vista";
            this.cbVendaAVista.UseVisualStyleBackColor = true;
            // 
            // cbTpagto
            // 
            this.cbTpagto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbTpagto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbTpagto.FormattingEnabled = true;
            this.cbTpagto.Location = new System.Drawing.Point(147, 167);
            this.cbTpagto.Name = "cbTpagto";
            this.cbTpagto.Size = new System.Drawing.Size(121, 21);
            this.cbTpagto.TabIndex = 67;
            this.cbTpagto.EnabledChanged += new System.EventHandler(this.cbTpagto_EnabledChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(125, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 13);
            this.label6.TabIndex = 66;
            this.label6.Text = "Data Inicial do Pagamento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(144, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 65;
            this.label5.Text = "Forma de Pagamento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 64;
            this.label4.Text = "Número de Parcelas";
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
            this.cbNParcelas.Location = new System.Drawing.Point(13, 105);
            this.cbNParcelas.Name = "cbNParcelas";
            this.cbNParcelas.Size = new System.Drawing.Size(121, 21);
            this.cbNParcelas.TabIndex = 63;
            this.cbNParcelas.Tag = "";
            // 
            // frmFormaDePagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 431);
            this.Controls.Add(this.dtDataini);
            this.Controls.Add(this.cbVendaAVista);
            this.Controls.Add(this.cbTpagto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbNParcelas);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.topo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFormaDePagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFormaDePagamento";
            this.Load += new System.EventHandler(this.frmFormaDePagamento_Load);
            this.Enter += new System.EventHandler(this.frmFormaDePagamento_Enter);
            this.topo.ResumeLayout(false);
            this.topo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel topo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTroco;
        private System.Windows.Forms.Label lblPago;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroDateTime dtDataini;
        private System.Windows.Forms.CheckBox cbVendaAVista;
        private System.Windows.Forms.ComboBox cbTpagto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbNParcelas;
    }
}
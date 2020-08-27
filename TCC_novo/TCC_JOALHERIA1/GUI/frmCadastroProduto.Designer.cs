namespace GUI
{
    partial class frmCadastroProduto
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
            this.btRmFoto = new System.Windows.Forms.Button();
            this.btLoFoto = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.cbSubCategoria = new System.Windows.Forms.ComboBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.cbUnd = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtValorVenda = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtValorPago = new System.Windows.Forms.TextBox();
            this.txtQtde = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dtCadastro = new MetroFramework.Controls.MetroDateTime();
            this.label11 = new System.Windows.Forms.Label();
            this.iconeencerar = new System.Windows.Forms.PictureBox();
            this.pnDados.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconeencerar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnDados
            // 
            this.pnDados.Controls.Add(this.label11);
            this.pnDados.Controls.Add(this.dtCadastro);
            this.pnDados.Controls.Add(this.button1);
            this.pnDados.Controls.Add(this.btRmFoto);
            this.pnDados.Controls.Add(this.btLoFoto);
            this.pnDados.Controls.Add(this.label10);
            this.pnDados.Controls.Add(this.panel1);
            this.pnDados.Controls.Add(this.cbSubCategoria);
            this.pnDados.Controls.Add(this.cbCategoria);
            this.pnDados.Controls.Add(this.cbUnd);
            this.pnDados.Controls.Add(this.label9);
            this.pnDados.Controls.Add(this.label8);
            this.pnDados.Controls.Add(this.label7);
            this.pnDados.Controls.Add(this.txtValorVenda);
            this.pnDados.Controls.Add(this.label6);
            this.pnDados.Controls.Add(this.txtValorPago);
            this.pnDados.Controls.Add(this.txtQtde);
            this.pnDados.Controls.Add(this.label5);
            this.pnDados.Controls.Add(this.label4);
            this.pnDados.Controls.Add(this.txtDescricao);
            this.pnDados.Controls.Add(this.label3);
            this.pnDados.Controls.Add(this.txtNome);
            this.pnDados.Controls.Add(this.txtCodigo);
            this.pnDados.Controls.Add(this.label2);
            this.pnDados.Controls.Add(this.label1);
            this.pnDados.Location = new System.Drawing.Point(3, 33);
            this.pnDados.Size = new System.Drawing.Size(851, 412);
            this.pnDados.Paint += new System.Windows.Forms.PaintEventHandler(this.pnDados_Paint);
            // 
            // pnBotoes
            // 
            this.pnBotoes.Location = new System.Drawing.Point(3, 451);
            this.pnBotoes.Size = new System.Drawing.Size(851, 101);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(735, 16);
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(595, 16);
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(455, 16);
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Location = new System.Drawing.Point(315, 16);
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btLocalizar
            // 
            this.btLocalizar.Location = new System.Drawing.Point(175, 16);
            this.btLocalizar.Click += new System.EventHandler(this.btLocalizar_Click);
            // 
            // btInserir
            // 
            this.btInserir.Click += new System.EventHandler(this.btInserir_Click);
            // 
            // btRmFoto
            // 
            this.btRmFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRmFoto.Image = global::GUI.Properties.Resources.aesthetica_5138_blog_post_delete;
            this.btRmFoto.Location = new System.Drawing.Point(702, 266);
            this.btRmFoto.Margin = new System.Windows.Forms.Padding(2);
            this.btRmFoto.Name = "btRmFoto";
            this.btRmFoto.Size = new System.Drawing.Size(134, 54);
            this.btRmFoto.TabIndex = 43;
            this.btRmFoto.Text = "Remover Foto";
            this.btRmFoto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btRmFoto.UseVisualStyleBackColor = true;
            this.btRmFoto.Click += new System.EventHandler(this.btRmFoto_Click);
            // 
            // btLoFoto
            // 
            this.btLoFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLoFoto.Image = global::GUI.Properties.Resources.fotos_4736_152_128x128;
            this.btLoFoto.Location = new System.Drawing.Point(528, 267);
            this.btLoFoto.Margin = new System.Windows.Forms.Padding(2);
            this.btLoFoto.Name = "btLoFoto";
            this.btLoFoto.Size = new System.Drawing.Size(134, 54);
            this.btLoFoto.TabIndex = 42;
            this.btLoFoto.Text = "Carregar Foto";
            this.btLoFoto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btLoFoto.UseVisualStyleBackColor = true;
            this.btLoFoto.Click += new System.EventHandler(this.btLoFoto_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(525, 7);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 13);
            this.label10.TabIndex = 41;
            this.label10.Text = "Foto";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pbFoto);
            this.panel1.Location = new System.Drawing.Point(527, 23);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 237);
            this.panel1.TabIndex = 40;
            // 
            // pbFoto
            // 
            this.pbFoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbFoto.Location = new System.Drawing.Point(0, 0);
            this.pbFoto.Margin = new System.Windows.Forms.Padding(2);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(308, 235);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 0;
            this.pbFoto.TabStop = false;
            // 
            // cbSubCategoria
            // 
            this.cbSubCategoria.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbSubCategoria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbSubCategoria.FormattingEnabled = true;
            this.cbSubCategoria.Location = new System.Drawing.Point(286, 301);
            this.cbSubCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.cbSubCategoria.Name = "cbSubCategoria";
            this.cbSubCategoria.Size = new System.Drawing.Size(228, 21);
            this.cbSubCategoria.TabIndex = 39;
            // 
            // cbCategoria
            // 
            this.cbCategoria.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbCategoria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(24, 301);
            this.cbCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(228, 21);
            this.cbCategoria.TabIndex = 38;
            this.cbCategoria.SelectedIndexChanged += new System.EventHandler(this.cbCategoria_SelectedIndexChanged);
            // 
            // cbUnd
            // 
            this.cbUnd.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbUnd.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbUnd.FormattingEnabled = true;
            this.cbUnd.Location = new System.Drawing.Point(286, 251);
            this.cbUnd.Margin = new System.Windows.Forms.Padding(2);
            this.cbUnd.Name = "cbUnd";
            this.cbUnd.Size = new System.Drawing.Size(228, 21);
            this.cbUnd.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(285, 284);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "SubCategoria";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 284);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Categoria";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(285, 236);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Unidade de medida";
            // 
            // txtValorVenda
            // 
            this.txtValorVenda.Location = new System.Drawing.Point(45, 345);
            this.txtValorVenda.Margin = new System.Windows.Forms.Padding(2);
            this.txtValorVenda.Name = "txtValorVenda";
            this.txtValorVenda.Size = new System.Drawing.Size(358, 20);
            this.txtValorVenda.TabIndex = 32;
            this.txtValorVenda.Text = "0.00";
            this.txtValorVenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorVenda_KeyPress);
            this.txtValorVenda.Leave += new System.EventHandler(this.txtValorVenda_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 328);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Valor de venda";
            // 
            // txtValorPago
            // 
            this.txtValorPago.Location = new System.Drawing.Point(286, 368);
            this.txtValorPago.Margin = new System.Windows.Forms.Padding(2);
            this.txtValorPago.Name = "txtValorPago";
            this.txtValorPago.Size = new System.Drawing.Size(227, 20);
            this.txtValorPago.TabIndex = 30;
            this.txtValorPago.Text = "0.00";
            this.txtValorPago.Visible = false;
            this.txtValorPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorPago_KeyPress);
            this.txtValorPago.Leave += new System.EventHandler(this.txtValorPago_Leave);
            // 
            // txtQtde
            // 
            this.txtQtde.Location = new System.Drawing.Point(26, 249);
            this.txtQtde.Margin = new System.Windows.Forms.Padding(2);
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.Size = new System.Drawing.Size(227, 20);
            this.txtQtde.TabIndex = 33;
            this.txtQtde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtde_KeyPress);
            this.txtQtde.Leave += new System.EventHandler(this.txtQtde_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(421, 352);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Valor Pago";
            this.label5.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 233);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Quantidade ";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(27, 112);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(488, 108);
            this.txtDescricao.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Descrição";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(24, 72);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(490, 20);
            this.txtNome.TabIndex = 25;
            this.txtNome.Leave += new System.EventHandler(this.txtNome_Leave);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(24, 23);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(118, 20);
            this.txtCodigo.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Código";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(528, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(308, 53);
            this.button1.TabIndex = 44;
            this.button1.Text = "Relatorio";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtCadastro
            // 
            this.dtCadastro.Location = new System.Drawing.Point(160, 23);
            this.dtCadastro.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtCadastro.Name = "dtCadastro";
            this.dtCadastro.Size = new System.Drawing.Size(354, 29);
            this.dtCadastro.TabIndex = 46;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(157, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 13);
            this.label11.TabIndex = 48;
            this.label11.Text = "Data Cadastro";
            // 
            // iconeencerar
            // 
            this.iconeencerar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconeencerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconeencerar.Image = global::GUI.Properties.Resources.icon_cerrar2;
            this.iconeencerar.Location = new System.Drawing.Point(833, 12);
            this.iconeencerar.Name = "iconeencerar";
            this.iconeencerar.Size = new System.Drawing.Size(15, 15);
            this.iconeencerar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconeencerar.TabIndex = 49;
            this.iconeencerar.TabStop = false;
            this.iconeencerar.Click += new System.EventHandler(this.iconeencerar_Click);
            // 
            // frmCadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(860, 563);
            this.Controls.Add(this.iconeencerar);
            this.Name = "frmCadastroProduto";
            this.Text = "Cadastro de Produto";
            this.Load += new System.EventHandler(this.frmCadastroProduto_Load);
            this.Controls.SetChildIndex(this.pnDados, 0);
            this.Controls.SetChildIndex(this.pnBotoes, 0);
            this.Controls.SetChildIndex(this.iconeencerar, 0);
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            this.pnBotoes.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconeencerar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btRmFoto;
        private System.Windows.Forms.Button btLoFoto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.ComboBox cbSubCategoria;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.ComboBox cbUnd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtValorVenda;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtValorPago;
        private System.Windows.Forms.TextBox txtQtde;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private MetroFramework.Controls.MetroDateTime dtCadastro;
        private System.Windows.Forms.PictureBox iconeencerar;

    }
}

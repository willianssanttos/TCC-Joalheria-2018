namespace GUI
{
    partial class frmCadastroFornecedor
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
            this.lbValorIncorreto = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtFone = new System.Windows.Forms.MaskedTextBox();
            this.txtCel = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtEndNumero = new System.Windows.Forms.TextBox();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.txtie = new System.Windows.Forms.TextBox();
            this.txtCnpj = new System.Windows.Forms.TextBox();
            this.txtRsocial = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lbRgIe = new System.Windows.Forms.Label();
            this.lbCPFCNPJ = new System.Windows.Forms.Label();
            this.lbRsocial = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdatacadastro = new MetroFramework.Controls.MetroDateTime();
            this.pnDados.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnDados
            // 
            this.pnDados.Controls.Add(this.txtdatacadastro);
            this.pnDados.Controls.Add(this.lbValorIncorreto);
            this.pnDados.Controls.Add(this.txtCep);
            this.pnDados.Controls.Add(this.label13);
            this.pnDados.Controls.Add(this.txtEmail);
            this.pnDados.Controls.Add(this.txtFone);
            this.pnDados.Controls.Add(this.txtCel);
            this.pnDados.Controls.Add(this.label12);
            this.pnDados.Controls.Add(this.label11);
            this.pnDados.Controls.Add(this.txtBairro);
            this.pnDados.Controls.Add(this.label10);
            this.pnDados.Controls.Add(this.txtEstado);
            this.pnDados.Controls.Add(this.label9);
            this.pnDados.Controls.Add(this.label8);
            this.pnDados.Controls.Add(this.label6);
            this.pnDados.Controls.Add(this.label5);
            this.pnDados.Controls.Add(this.label4);
            this.pnDados.Controls.Add(this.txtCidade);
            this.pnDados.Controls.Add(this.txtEndNumero);
            this.pnDados.Controls.Add(this.txtLogradouro);
            this.pnDados.Controls.Add(this.txtie);
            this.pnDados.Controls.Add(this.txtCnpj);
            this.pnDados.Controls.Add(this.txtRsocial);
            this.pnDados.Controls.Add(this.txtNome);
            this.pnDados.Controls.Add(this.txtCodigo);
            this.pnDados.Controls.Add(this.lbRgIe);
            this.pnDados.Controls.Add(this.lbCPFCNPJ);
            this.pnDados.Controls.Add(this.lbRsocial);
            this.pnDados.Controls.Add(this.lbNome);
            this.pnDados.Controls.Add(this.label2);
            this.pnDados.Controls.Add(this.label1);
            this.pnDados.Location = new System.Drawing.Point(3, 12);
            this.pnDados.Size = new System.Drawing.Size(837, 414);
            // 
            // pnBotoes
            // 
            this.pnBotoes.Location = new System.Drawing.Point(3, 432);
            this.pnBotoes.Size = new System.Drawing.Size(837, 111);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(725, 16);
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(587, 16);
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(449, 16);
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Location = new System.Drawing.Point(311, 16);
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btLocalizar
            // 
            this.btLocalizar.Location = new System.Drawing.Point(173, 16);
            this.btLocalizar.Click += new System.EventHandler(this.btLocalizar_Click);
            // 
            // btInserir
            // 
            this.btInserir.Click += new System.EventHandler(this.btInserir_Click);
            // 
            // lbValorIncorreto
            // 
            this.lbValorIncorreto.AutoSize = true;
            this.lbValorIncorreto.ForeColor = System.Drawing.Color.Red;
            this.lbValorIncorreto.Location = new System.Drawing.Point(338, 181);
            this.lbValorIncorreto.Name = "lbValorIncorreto";
            this.lbValorIncorreto.Size = new System.Drawing.Size(71, 13);
            this.lbValorIncorreto.TabIndex = 71;
            this.lbValorIncorreto.Text = "Valor Invalido";
            this.lbValorIncorreto.Visible = false;
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(72, 247);
            this.txtCep.Mask = "00000-999";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(100, 20);
            this.txtCep.TabIndex = 70;
            this.txtCep.Leave += new System.EventHandler(this.txtCep_Leave);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(69, 339);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 13);
            this.label13.TabIndex = 69;
            this.label13.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(72, 354);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(702, 20);
            this.txtEmail.TabIndex = 68;
            // 
            // txtFone
            // 
            this.txtFone.Location = new System.Drawing.Point(506, 300);
            this.txtFone.Mask = "(00)00000-9999";
            this.txtFone.Name = "txtFone";
            this.txtFone.Size = new System.Drawing.Size(129, 20);
            this.txtFone.TabIndex = 66;
            // 
            // txtCel
            // 
            this.txtCel.Location = new System.Drawing.Point(644, 300);
            this.txtCel.Mask = "(00)00000-9999";
            this.txtCel.Name = "txtCel";
            this.txtCel.Size = new System.Drawing.Size(130, 20);
            this.txtCel.TabIndex = 65;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(641, 284);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 64;
            this.label12.Text = "Celular";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(503, 285);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 63;
            this.label11.Text = "Telefone";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(642, 247);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(132, 20);
            this.txtBairro.TabIndex = 62;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(639, 231);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 61;
            this.label10.Text = "Bairro";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(289, 300);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(211, 20);
            this.txtEstado.TabIndex = 60;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(291, 284);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 59;
            this.label9.Text = "Estado";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(69, 284);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 58;
            this.label8.Text = "Cidade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(552, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 57;
            this.label6.Text = "Número";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(175, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 56;
            this.label5.Text = "Logradouro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 55;
            this.label4.Text = "CEP";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(72, 300);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(211, 20);
            this.txtCidade.TabIndex = 54;
            // 
            // txtEndNumero
            // 
            this.txtEndNumero.Location = new System.Drawing.Point(555, 247);
            this.txtEndNumero.Name = "txtEndNumero";
            this.txtEndNumero.Size = new System.Drawing.Size(80, 20);
            this.txtEndNumero.TabIndex = 53;
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Location = new System.Drawing.Point(178, 247);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(371, 20);
            this.txtLogradouro.TabIndex = 52;
            // 
            // txtie
            // 
            this.txtie.Location = new System.Drawing.Point(431, 197);
            this.txtie.Name = "txtie";
            this.txtie.Size = new System.Drawing.Size(343, 20);
            this.txtie.TabIndex = 51;
            // 
            // txtCnpj
            // 
            this.txtCnpj.Location = new System.Drawing.Point(72, 197);
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(343, 20);
            this.txtCnpj.TabIndex = 50;
            this.txtCnpj.Leave += new System.EventHandler(this.txtCnpj_Leave);
            // 
            // txtRsocial
            // 
            this.txtRsocial.Location = new System.Drawing.Point(72, 144);
            this.txtRsocial.Name = "txtRsocial";
            this.txtRsocial.Size = new System.Drawing.Size(702, 20);
            this.txtRsocial.TabIndex = 49;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(72, 95);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(702, 20);
            this.txtNome.TabIndex = 48;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(72, 45);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 47;
            // 
            // lbRgIe
            // 
            this.lbRgIe.AutoSize = true;
            this.lbRgIe.Location = new System.Drawing.Point(428, 181);
            this.lbRgIe.Name = "lbRgIe";
            this.lbRgIe.Size = new System.Drawing.Size(17, 13);
            this.lbRgIe.TabIndex = 46;
            this.lbRgIe.Text = "IE";
            // 
            // lbCPFCNPJ
            // 
            this.lbCPFCNPJ.AutoSize = true;
            this.lbCPFCNPJ.Location = new System.Drawing.Point(69, 181);
            this.lbCPFCNPJ.Name = "lbCPFCNPJ";
            this.lbCPFCNPJ.Size = new System.Drawing.Size(34, 13);
            this.lbCPFCNPJ.TabIndex = 45;
            this.lbCPFCNPJ.Text = "CNPJ";
            // 
            // lbRsocial
            // 
            this.lbRsocial.AutoSize = true;
            this.lbRsocial.Location = new System.Drawing.Point(69, 128);
            this.lbRsocial.Name = "lbRsocial";
            this.lbRsocial.Size = new System.Drawing.Size(70, 13);
            this.lbRsocial.TabIndex = 44;
            this.lbRsocial.Text = "Razão Social";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(69, 79);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(35, 13);
            this.lbNome.TabIndex = 43;
            this.lbNome.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Data Cadastro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Código";
            // 
            // txtdatacadastro
            // 
            this.txtdatacadastro.Location = new System.Drawing.Point(178, 45);
            this.txtdatacadastro.MinimumSize = new System.Drawing.Size(0, 29);
            this.txtdatacadastro.Name = "txtdatacadastro";
            this.txtdatacadastro.Size = new System.Drawing.Size(267, 29);
            this.txtdatacadastro.TabIndex = 72;
            // 
            // frmCadastroFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(844, 544);
            this.Name = "frmCadastroFornecedor";
            this.Text = "Cadastro de Fornecedor";
            this.Load += new System.EventHandler(this.frmCadastroFornecedor_Load);
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            this.pnBotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbValorIncorreto;
        private System.Windows.Forms.MaskedTextBox txtCep;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.MaskedTextBox txtFone;
        private System.Windows.Forms.MaskedTextBox txtCel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtEndNumero;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.TextBox txtie;
        private System.Windows.Forms.TextBox txtCnpj;
        private System.Windows.Forms.TextBox txtRsocial;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lbRgIe;
        private System.Windows.Forms.Label lbCPFCNPJ;
        private System.Windows.Forms.Label lbRsocial;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroDateTime txtdatacadastro;
    }
}

namespace GUI
{
    partial class frmCadastroCliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbRsocial = new System.Windows.Forms.Label();
            this.lbCPFCNPJ = new System.Windows.Forms.Label();
            this.lbRgIe = new System.Windows.Forms.Label();
            this.lbsexo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.GroupBox();
            this.rbJuridica = new System.Windows.Forms.RadioButton();
            this.rbFisica = new System.Windows.Forms.RadioButton();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtRsocial = new System.Windows.Forms.TextBox();
            this.txtCpfCnpj = new System.Windows.Forms.TextBox();
            this.txtRgie = new System.Windows.Forms.TextBox();
            this.lbnasc = new System.Windows.Forms.Label();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.txtEndNumero = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCel = new System.Windows.Forms.MaskedTextBox();
            this.txtFone = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.lbValorIncorreto = new System.Windows.Forms.Label();
            this.txtdatacadastro = new MetroFramework.Controls.MetroDateTime();
            this.txtdtnascimento = new MetroFramework.Controls.MetroDateTime();
            this.label3 = new System.Windows.Forms.Label();
            this.iconeencerar = new System.Windows.Forms.PictureBox();
            this.pnDados.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            this.txtTipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconeencerar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnDados
            // 
            this.pnDados.Controls.Add(this.label3);
            this.pnDados.Controls.Add(this.txtdtnascimento);
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
            this.pnDados.Controls.Add(this.txtSexo);
            this.pnDados.Controls.Add(this.lbnasc);
            this.pnDados.Controls.Add(this.txtRgie);
            this.pnDados.Controls.Add(this.txtCpfCnpj);
            this.pnDados.Controls.Add(this.txtRsocial);
            this.pnDados.Controls.Add(this.txtNome);
            this.pnDados.Controls.Add(this.txtTipo);
            this.pnDados.Controls.Add(this.txtCodigo);
            this.pnDados.Controls.Add(this.lbsexo);
            this.pnDados.Controls.Add(this.lbRgIe);
            this.pnDados.Controls.Add(this.lbCPFCNPJ);
            this.pnDados.Controls.Add(this.lbRsocial);
            this.pnDados.Controls.Add(this.lbNome);
            this.pnDados.Controls.Add(this.label2);
            this.pnDados.Controls.Add(this.label1);
            this.pnDados.Location = new System.Drawing.Point(3, 32);
            this.pnDados.Size = new System.Drawing.Size(854, 420);
            // 
            // pnBotoes
            // 
            this.pnBotoes.Location = new System.Drawing.Point(3, 458);
            this.pnBotoes.Size = new System.Drawing.Size(854, 100);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(740, 16);
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(599, 16);
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(458, 16);
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Location = new System.Drawing.Point(317, 16);
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btLocalizar
            // 
            this.btLocalizar.Location = new System.Drawing.Point(176, 16);
            this.btLocalizar.Click += new System.EventHandler(this.btLocalizar_Click);
            // 
            // btInserir
            // 
            this.btInserir.Click += new System.EventHandler(this.btInserir_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data Cadastro";
            // 
            // lbNome
            // 
            this.lbNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(34, 112);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(35, 13);
            this.lbNome.TabIndex = 2;
            this.lbNome.Text = "Nome";
            // 
            // lbRsocial
            // 
            this.lbRsocial.AutoSize = true;
            this.lbRsocial.Location = new System.Drawing.Point(34, 161);
            this.lbRsocial.Name = "lbRsocial";
            this.lbRsocial.Size = new System.Drawing.Size(70, 13);
            this.lbRsocial.TabIndex = 3;
            this.lbRsocial.Text = "Razão Social";
            this.lbRsocial.Visible = false;
            // 
            // lbCPFCNPJ
            // 
            this.lbCPFCNPJ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCPFCNPJ.AutoSize = true;
            this.lbCPFCNPJ.Location = new System.Drawing.Point(34, 214);
            this.lbCPFCNPJ.Name = "lbCPFCNPJ";
            this.lbCPFCNPJ.Size = new System.Drawing.Size(27, 13);
            this.lbCPFCNPJ.TabIndex = 4;
            this.lbCPFCNPJ.Text = "CPF";
            // 
            // lbRgIe
            // 
            this.lbRgIe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbRgIe.AutoSize = true;
            this.lbRgIe.Location = new System.Drawing.Point(434, 214);
            this.lbRgIe.Name = "lbRgIe";
            this.lbRgIe.Size = new System.Drawing.Size(23, 13);
            this.lbRgIe.TabIndex = 5;
            this.lbRgIe.Text = "RG";
            // 
            // lbsexo
            // 
            this.lbsexo.AutoSize = true;
            this.lbsexo.Location = new System.Drawing.Point(703, 62);
            this.lbsexo.Name = "lbsexo";
            this.lbsexo.Size = new System.Drawing.Size(31, 13);
            this.lbsexo.TabIndex = 6;
            this.lbsexo.Text = "Sexo";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(37, 78);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 7;
            // 
            // txtTipo
            // 
            this.txtTipo.Controls.Add(this.rbJuridica);
            this.txtTipo.Controls.Add(this.rbFisica);
            this.txtTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipo.Location = new System.Drawing.Point(317, 60);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(177, 46);
            this.txtTipo.TabIndex = 9;
            this.txtTipo.TabStop = false;
            this.txtTipo.Text = "Tipo de Cliente";
            // 
            // rbJuridica
            // 
            this.rbJuridica.AutoSize = true;
            this.rbJuridica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbJuridica.Location = new System.Drawing.Point(92, 20);
            this.rbJuridica.Name = "rbJuridica";
            this.rbJuridica.Size = new System.Drawing.Size(76, 20);
            this.rbJuridica.TabIndex = 1;
            this.rbJuridica.Text = " Juridica";
            this.rbJuridica.UseVisualStyleBackColor = true;
            this.rbJuridica.CheckedChanged += new System.EventHandler(this.rbJuridica_CheckedChanged);
            // 
            // rbFisica
            // 
            this.rbFisica.AutoSize = true;
            this.rbFisica.Checked = true;
            this.rbFisica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFisica.Location = new System.Drawing.Point(17, 21);
            this.rbFisica.Name = "rbFisica";
            this.rbFisica.Size = new System.Drawing.Size(62, 20);
            this.rbFisica.TabIndex = 0;
            this.rbFisica.TabStop = true;
            this.rbFisica.Text = "Fisica";
            this.rbFisica.UseVisualStyleBackColor = true;
            this.rbFisica.CheckedChanged += new System.EventHandler(this.rbFisica_CheckedChanged);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(37, 128);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(782, 20);
            this.txtNome.TabIndex = 10;
            // 
            // txtRsocial
            // 
            this.txtRsocial.Location = new System.Drawing.Point(37, 177);
            this.txtRsocial.Name = "txtRsocial";
            this.txtRsocial.Size = new System.Drawing.Size(782, 20);
            this.txtRsocial.TabIndex = 11;
            this.txtRsocial.Visible = false;
            // 
            // txtCpfCnpj
            // 
            this.txtCpfCnpj.Location = new System.Drawing.Point(37, 230);
            this.txtCpfCnpj.Name = "txtCpfCnpj";
            this.txtCpfCnpj.Size = new System.Drawing.Size(380, 20);
            this.txtCpfCnpj.TabIndex = 12;
            this.txtCpfCnpj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCpfCnpj_KeyPress);
            this.txtCpfCnpj.Leave += new System.EventHandler(this.txtCpfCnpj_Leave);
            // 
            // txtRgie
            // 
            this.txtRgie.Location = new System.Drawing.Point(437, 230);
            this.txtRgie.Name = "txtRgie";
            this.txtRgie.Size = new System.Drawing.Size(382, 20);
            this.txtRgie.TabIndex = 13;
            // 
            // lbnasc
            // 
            this.lbnasc.AutoSize = true;
            this.lbnasc.Location = new System.Drawing.Point(500, 58);
            this.lbnasc.Name = "lbnasc";
            this.lbnasc.Size = new System.Drawing.Size(89, 13);
            this.lbnasc.TabIndex = 14;
            this.lbnasc.Text = "Data Nascimento";
            // 
            // txtSexo
            // 
            this.txtSexo.Location = new System.Drawing.Point(706, 78);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(113, 20);
            this.txtSexo.TabIndex = 16;
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Location = new System.Drawing.Point(143, 280);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(371, 20);
            this.txtLogradouro.TabIndex = 18;
            // 
            // txtEndNumero
            // 
            this.txtEndNumero.Location = new System.Drawing.Point(520, 280);
            this.txtEndNumero.Name = "txtEndNumero";
            this.txtEndNumero.Size = new System.Drawing.Size(80, 20);
            this.txtEndNumero.TabIndex = 19;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(37, 333);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(247, 20);
            this.txtCidade.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "CEP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(155, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Logradouro";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(517, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Número";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 317);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Cidade";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(287, 317);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Estado";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(290, 333);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(249, 20);
            this.txtEstado.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(604, 264);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Bairro";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(607, 280);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(212, 20);
            this.txtBairro.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(548, 318);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Telefone";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(686, 317);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "Celular";
            // 
            // txtCel
            // 
            this.txtCel.Location = new System.Drawing.Point(689, 333);
            this.txtCel.Mask = "(00)00000-9999";
            this.txtCel.Name = "txtCel";
            this.txtCel.Size = new System.Drawing.Size(130, 20);
            this.txtCel.TabIndex = 33;
            // 
            // txtFone
            // 
            this.txtFone.Location = new System.Drawing.Point(551, 333);
            this.txtFone.Mask = "(00)00000-9999";
            this.txtFone.Name = "txtFone";
            this.txtFone.Size = new System.Drawing.Size(129, 20);
            this.txtFone.TabIndex = 34;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(37, 387);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(782, 20);
            this.txtEmail.TabIndex = 37;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(34, 372);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 13);
            this.label13.TabIndex = 38;
            this.label13.Text = "Email";
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(37, 280);
            this.txtCep.Mask = "00000-999";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(100, 20);
            this.txtCep.TabIndex = 39;
            this.txtCep.Leave += new System.EventHandler(this.txtCep_Leave);
            // 
            // lbValorIncorreto
            // 
            this.lbValorIncorreto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbValorIncorreto.AutoSize = true;
            this.lbValorIncorreto.ForeColor = System.Drawing.Color.Red;
            this.lbValorIncorreto.Location = new System.Drawing.Point(346, 214);
            this.lbValorIncorreto.Name = "lbValorIncorreto";
            this.lbValorIncorreto.Size = new System.Drawing.Size(71, 13);
            this.lbValorIncorreto.TabIndex = 40;
            this.lbValorIncorreto.Text = "Valor Invalido";
            this.lbValorIncorreto.Visible = false;
            // 
            // txtdatacadastro
            // 
            this.txtdatacadastro.Location = new System.Drawing.Point(143, 76);
            this.txtdatacadastro.MinimumSize = new System.Drawing.Size(0, 29);
            this.txtdatacadastro.Name = "txtdatacadastro";
            this.txtdatacadastro.Size = new System.Drawing.Size(168, 29);
            this.txtdatacadastro.TabIndex = 41;
            // 
            // txtdtnascimento
            // 
            this.txtdtnascimento.Location = new System.Drawing.Point(500, 76);
            this.txtdtnascimento.MinimumSize = new System.Drawing.Size(0, 29);
            this.txtdtnascimento.Name = "txtdtnascimento";
            this.txtdtnascimento.Size = new System.Drawing.Size(200, 29);
            this.txtdtnascimento.TabIndex = 42;
            this.txtdtnascimento.ValueChanged += new System.EventHandler(this.txtdtnascimento_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(11)))), ((int)(((byte)(83)))));
            this.label3.Location = new System.Drawing.Point(311, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(273, 31);
            this.label3.TabIndex = 43;
            this.label3.Text = "Cadastro de Cliente";
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
            this.iconeencerar.TabIndex = 44;
            this.iconeencerar.TabStop = false;
            this.iconeencerar.Click += new System.EventHandler(this.iconeencerar_Click);
            // 
            // frmCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(860, 570);
            this.Controls.Add(this.iconeencerar);
            this.Name = "frmCadastroCliente";
            this.Text = "Cadastro de Cliente";
            this.Load += new System.EventHandler(this.frmCadastroCliente_Load);
            this.Controls.SetChildIndex(this.pnDados, 0);
            this.Controls.SetChildIndex(this.pnBotoes, 0);
            this.Controls.SetChildIndex(this.iconeencerar, 0);
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            this.pnBotoes.ResumeLayout(false);
            this.txtTipo.ResumeLayout(false);
            this.txtTipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconeencerar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox txtTipo;
        private System.Windows.Forms.RadioButton rbJuridica;
        private System.Windows.Forms.RadioButton rbFisica;
        private System.Windows.Forms.Label lbsexo;
        private System.Windows.Forms.Label lbRgIe;
        private System.Windows.Forms.Label lbCPFCNPJ;
        private System.Windows.Forms.Label lbRsocial;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbnasc;
        private System.Windows.Forms.Label lbValorIncorreto;
        private MetroFramework.Controls.MetroDateTime txtdatacadastro;
        private MetroFramework.Controls.MetroDateTime txtdtnascimento;
        public System.Windows.Forms.TextBox txtRsocial;
        public System.Windows.Forms.TextBox txtNome;
        public System.Windows.Forms.TextBox txtCodigo;
        public System.Windows.Forms.TextBox txtRgie;
        public System.Windows.Forms.TextBox txtCpfCnpj;
        public System.Windows.Forms.TextBox txtEmail;
        public System.Windows.Forms.MaskedTextBox txtFone;
        public System.Windows.Forms.MaskedTextBox txtCel;
        public System.Windows.Forms.TextBox txtBairro;
        public System.Windows.Forms.TextBox txtEstado;
        public System.Windows.Forms.TextBox txtCidade;
        public System.Windows.Forms.TextBox txtEndNumero;
        public System.Windows.Forms.TextBox txtLogradouro;
        public System.Windows.Forms.TextBox txtSexo;
        public System.Windows.Forms.MaskedTextBox txtCep;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox iconeencerar;
    }
}

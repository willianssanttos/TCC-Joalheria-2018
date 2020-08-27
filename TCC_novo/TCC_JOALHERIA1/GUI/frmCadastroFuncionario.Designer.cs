namespace GUI
{
    partial class frmCadastroFuncionario
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
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
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
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lbsexo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.GroupBox();
            this.txtdtadmisao = new MetroFramework.Controls.MetroDateTime();
            this.txtdtnascimento = new MetroFramework.Controls.MetroDateTime();
            this.txtCarFunc = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtescolaridade = new System.Windows.Forms.TextBox();
            this.lbRsocial = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbValorIncorreto = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbnasc = new System.Windows.Forms.Label();
            this.txtRg = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lbRgIe = new System.Windows.Forms.Label();
            this.lbCPFCNPJ = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.txtdtcadastro = new MetroFramework.Controls.MetroDateTime();
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
            this.pnDados.Controls.Add(this.txtdtcadastro);
            this.pnDados.Controls.Add(this.txtdtnascimento);
            this.pnDados.Controls.Add(this.txtTipo);
            this.pnDados.Controls.Add(this.txtCep);
            this.pnDados.Controls.Add(this.txtFone);
            this.pnDados.Controls.Add(this.txtCel);
            this.pnDados.Controls.Add(this.label12);
            this.pnDados.Controls.Add(this.label11);
            this.pnDados.Controls.Add(this.txtBairro);
            this.pnDados.Controls.Add(this.label10);
            this.pnDados.Controls.Add(this.lbnasc);
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
            this.pnDados.Controls.Add(this.txtCodigo);
            this.pnDados.Controls.Add(this.lbsexo);
            this.pnDados.Controls.Add(this.label2);
            this.pnDados.Controls.Add(this.label1);
            this.pnDados.Location = new System.Drawing.Point(3, 46);
            this.pnDados.Size = new System.Drawing.Size(851, 362);
            // 
            // pnBotoes
            // 
            this.pnBotoes.Location = new System.Drawing.Point(3, 414);
            this.pnBotoes.Size = new System.Drawing.Size(851, 110);
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
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(76, 266);
            this.txtCep.Mask = "00000-999";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(100, 20);
            this.txtCep.TabIndex = 75;
            this.txtCep.Leave += new System.EventHandler(this.txtCep_Leave);
            // 
            // txtFone
            // 
            this.txtFone.Location = new System.Drawing.Point(510, 319);
            this.txtFone.Mask = "(00)00000-9999";
            this.txtFone.Name = "txtFone";
            this.txtFone.Size = new System.Drawing.Size(129, 20);
            this.txtFone.TabIndex = 70;
            // 
            // txtCel
            // 
            this.txtCel.Location = new System.Drawing.Point(648, 319);
            this.txtCel.Mask = "(00)00000-9999";
            this.txtCel.Name = "txtCel";
            this.txtCel.Size = new System.Drawing.Size(130, 20);
            this.txtCel.TabIndex = 69;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(645, 303);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 68;
            this.label12.Text = "Celular";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(507, 304);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 67;
            this.label11.Text = "Telefone";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(646, 266);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(132, 20);
            this.txtBairro.TabIndex = 66;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(643, 250);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 65;
            this.label10.Text = "Bairro";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(293, 319);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(211, 20);
            this.txtEstado.TabIndex = 64;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(295, 303);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 63;
            this.label9.Text = "Estado";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(73, 303);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 62;
            this.label8.Text = "Cidade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(556, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 61;
            this.label6.Text = "Número";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(179, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 60;
            this.label5.Text = "Logradouro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 59;
            this.label4.Text = "CEP";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(76, 319);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(211, 20);
            this.txtCidade.TabIndex = 58;
            // 
            // txtEndNumero
            // 
            this.txtEndNumero.Location = new System.Drawing.Point(559, 266);
            this.txtEndNumero.Name = "txtEndNumero";
            this.txtEndNumero.Size = new System.Drawing.Size(80, 20);
            this.txtEndNumero.TabIndex = 57;
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Location = new System.Drawing.Point(182, 266);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(371, 20);
            this.txtLogradouro.TabIndex = 56;
            // 
            // txtSexo
            // 
            this.txtSexo.Location = new System.Drawing.Point(416, 25);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(161, 20);
            this.txtSexo.TabIndex = 55;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(39, 25);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 48;
            // 
            // lbsexo
            // 
            this.lbsexo.AutoSize = true;
            this.lbsexo.Location = new System.Drawing.Point(413, 9);
            this.lbsexo.Name = "lbsexo";
            this.lbsexo.Size = new System.Drawing.Size(31, 13);
            this.lbsexo.TabIndex = 47;
            this.lbsexo.Text = "Sexo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Data Cadastro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Código";
            // 
            // txtTipo
            // 
            this.txtTipo.Controls.Add(this.txtdtadmisao);
            this.txtTipo.Controls.Add(this.txtCarFunc);
            this.txtTipo.Controls.Add(this.label14);
            this.txtTipo.Controls.Add(this.txtescolaridade);
            this.txtTipo.Controls.Add(this.lbRsocial);
            this.txtTipo.Controls.Add(this.label7);
            this.txtTipo.Controls.Add(this.lbValorIncorreto);
            this.txtTipo.Controls.Add(this.label13);
            this.txtTipo.Controls.Add(this.txtEmail);
            this.txtTipo.Controls.Add(this.txtRg);
            this.txtTipo.Controls.Add(this.txtCpf);
            this.txtTipo.Controls.Add(this.txtNome);
            this.txtTipo.Controls.Add(this.lbRgIe);
            this.txtTipo.Controls.Add(this.lbCPFCNPJ);
            this.txtTipo.Controls.Add(this.lbNome);
            this.txtTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipo.Location = new System.Drawing.Point(9, 60);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(836, 178);
            this.txtTipo.TabIndex = 86;
            this.txtTipo.TabStop = false;
            this.txtTipo.Text = "Dados Obrigatorio";
            // 
            // txtdtadmisao
            // 
            this.txtdtadmisao.Location = new System.Drawing.Point(426, 189);
            this.txtdtadmisao.MinimumSize = new System.Drawing.Size(0, 29);
            this.txtdtadmisao.Name = "txtdtadmisao";
            this.txtdtadmisao.Size = new System.Drawing.Size(343, 29);
            this.txtdtadmisao.TabIndex = 106;
            this.txtdtadmisao.Visible = false;
            // 
            // txtdtnascimento
            // 
            this.txtdtnascimento.Location = new System.Drawing.Point(583, 25);
            this.txtdtnascimento.MinimumSize = new System.Drawing.Size(0, 29);
            this.txtdtnascimento.Name = "txtdtnascimento";
            this.txtdtnascimento.Size = new System.Drawing.Size(249, 29);
            this.txtdtnascimento.TabIndex = 105;
            // 
            // txtCarFunc
            // 
            this.txtCarFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarFunc.Location = new System.Drawing.Point(426, 143);
            this.txtCarFunc.Name = "txtCarFunc";
            this.txtCarFunc.Size = new System.Drawing.Size(343, 20);
            this.txtCarFunc.TabIndex = 103;
            this.txtCarFunc.TextChanged += new System.EventHandler(this.txtCarFunc_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(425, 127);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(116, 15);
            this.label14.TabIndex = 102;
            this.label14.Text = "Cargo ou Funçao";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // txtescolaridade
            // 
            this.txtescolaridade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtescolaridade.Location = new System.Drawing.Point(72, 197);
            this.txtescolaridade.Name = "txtescolaridade";
            this.txtescolaridade.Size = new System.Drawing.Size(343, 20);
            this.txtescolaridade.TabIndex = 101;
            this.txtescolaridade.Visible = false;
            // 
            // lbRsocial
            // 
            this.lbRsocial.AutoSize = true;
            this.lbRsocial.Location = new System.Drawing.Point(69, 181);
            this.lbRsocial.Name = "lbRsocial";
            this.lbRsocial.Size = new System.Drawing.Size(91, 15);
            this.lbRsocial.TabIndex = 100;
            this.lbRsocial.Text = "Escolaridade";
            this.lbRsocial.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(423, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 15);
            this.label7.TabIndex = 99;
            this.label7.Text = "Data admisão";
            this.label7.Visible = false;
            // 
            // lbValorIncorreto
            // 
            this.lbValorIncorreto.AutoSize = true;
            this.lbValorIncorreto.ForeColor = System.Drawing.Color.Red;
            this.lbValorIncorreto.Location = new System.Drawing.Point(316, 75);
            this.lbValorIncorreto.Name = "lbValorIncorreto";
            this.lbValorIncorreto.Size = new System.Drawing.Size(94, 15);
            this.lbValorIncorreto.TabIndex = 98;
            this.lbValorIncorreto.Text = "Valor Invalido";
            this.lbValorIncorreto.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(69, 124);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 15);
            this.label13.TabIndex = 97;
            this.label13.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(70, 143);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(340, 20);
            this.txtEmail.TabIndex = 96;
            // 
            // lbnasc
            // 
            this.lbnasc.AutoSize = true;
            this.lbnasc.Location = new System.Drawing.Point(580, 9);
            this.lbnasc.Name = "lbnasc";
            this.lbnasc.Size = new System.Drawing.Size(89, 13);
            this.lbnasc.TabIndex = 95;
            this.lbnasc.Text = "Data Nascimento";
            // 
            // txtRg
            // 
            this.txtRg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRg.Location = new System.Drawing.Point(426, 91);
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(343, 20);
            this.txtRg.TabIndex = 94;
            // 
            // txtCpf
            // 
            this.txtCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpf.Location = new System.Drawing.Point(67, 91);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(343, 20);
            this.txtCpf.TabIndex = 93;
            this.txtCpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCpf_KeyPress);
            this.txtCpf.Leave += new System.EventHandler(this.txtCpf_Leave_1);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(67, 39);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(702, 20);
            this.txtNome.TabIndex = 92;
            // 
            // lbRgIe
            // 
            this.lbRgIe.AutoSize = true;
            this.lbRgIe.Location = new System.Drawing.Point(426, 72);
            this.lbRgIe.Name = "lbRgIe";
            this.lbRgIe.Size = new System.Drawing.Size(27, 15);
            this.lbRgIe.TabIndex = 91;
            this.lbRgIe.Text = "RG";
            // 
            // lbCPFCNPJ
            // 
            this.lbCPFCNPJ.AutoSize = true;
            this.lbCPFCNPJ.Location = new System.Drawing.Point(64, 75);
            this.lbCPFCNPJ.Name = "lbCPFCNPJ";
            this.lbCPFCNPJ.Size = new System.Drawing.Size(33, 15);
            this.lbCPFCNPJ.TabIndex = 90;
            this.lbCPFCNPJ.Text = "CPF";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(67, 21);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(45, 15);
            this.lbNome.TabIndex = 89;
            this.lbNome.Text = "Nome";
            // 
            // txtdtcadastro
            // 
            this.txtdtcadastro.Location = new System.Drawing.Point(154, 25);
            this.txtdtcadastro.MinimumSize = new System.Drawing.Size(0, 29);
            this.txtdtcadastro.Name = "txtdtcadastro";
            this.txtdtcadastro.Size = new System.Drawing.Size(248, 29);
            this.txtdtcadastro.TabIndex = 106;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(11)))), ((int)(((byte)(83)))));
            this.label3.Location = new System.Drawing.Point(258, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(334, 31);
            this.label3.TabIndex = 44;
            this.label3.Text = "Cadastro de Funcionario";
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
            this.iconeencerar.TabIndex = 48;
            this.iconeencerar.TabStop = false;
            this.iconeencerar.Click += new System.EventHandler(this.iconeencerar_Click);
            // 
            // frmCadastroFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(860, 536);
            this.Controls.Add(this.iconeencerar);
            this.Controls.Add(this.label3);
            this.Name = "frmCadastroFuncionario";
            this.Text = "Cadastro de Funcionario";
            this.Load += new System.EventHandler(this.frmCadastroFuncionario_Load);
            this.Controls.SetChildIndex(this.pnDados, 0);
            this.Controls.SetChildIndex(this.pnBotoes, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.iconeencerar, 0);
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            this.pnBotoes.ResumeLayout(false);
            this.txtTipo.ResumeLayout(false);
            this.txtTipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconeencerar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtCep;
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
        private System.Windows.Forms.TextBox txtSexo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lbsexo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox txtTipo;
        private System.Windows.Forms.TextBox txtCarFunc;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtescolaridade;
        private System.Windows.Forms.Label lbRsocial;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbValorIncorreto;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbnasc;
        private System.Windows.Forms.TextBox txtRg;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lbRgIe;
        private System.Windows.Forms.Label lbCPFCNPJ;
        private System.Windows.Forms.Label lbNome;
        private MetroFramework.Controls.MetroDateTime txtdtcadastro;
        private MetroFramework.Controls.MetroDateTime txtdtadmisao;
        private MetroFramework.Controls.MetroDateTime txtdtnascimento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox iconeencerar;
    }
}

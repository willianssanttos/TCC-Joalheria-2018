namespace GUI
{
    partial class frmCadastroNivelAcesso
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
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbMarcarTodos = new System.Windows.Forms.GroupBox();
            this.chMIMP = new System.Windows.Forms.CheckBox();
            this.chMEXC = new System.Windows.Forms.CheckBox();
            this.chMALT = new System.Windows.Forms.CheckBox();
            this.chMINS = new System.Windows.Forms.CheckBox();
            this.chMBLO = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNomePesquisado = new System.Windows.Forms.TextBox();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.dgvDados = new MetroFramework.Controls.MetroGrid();
            this.nivel_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomefrm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bloqueado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.inserir = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.alterar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.excluir = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.imprimir = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btLocalizar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.iconeencerar = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.gbMarcarTodos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconeencerar)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbMarcarTodos);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnLocalizar);
            this.panel1.Controls.Add(this.dgvDados);
            this.panel1.Controls.Add(this.txtCodigo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(836, 412);
            this.panel1.TabIndex = 0;
            // 
            // gbMarcarTodos
            // 
            this.gbMarcarTodos.Controls.Add(this.chMIMP);
            this.gbMarcarTodos.Controls.Add(this.chMEXC);
            this.gbMarcarTodos.Controls.Add(this.chMALT);
            this.gbMarcarTodos.Controls.Add(this.chMINS);
            this.gbMarcarTodos.Controls.Add(this.chMBLO);
            this.gbMarcarTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMarcarTodos.Location = new System.Drawing.Point(325, 63);
            this.gbMarcarTodos.Name = "gbMarcarTodos";
            this.gbMarcarTodos.Size = new System.Drawing.Size(484, 51);
            this.gbMarcarTodos.TabIndex = 27;
            this.gbMarcarTodos.TabStop = false;
            this.gbMarcarTodos.Text = "Marca ou Desmarcar para Todos";
            // 
            // chMIMP
            // 
            this.chMIMP.AutoSize = true;
            this.chMIMP.Location = new System.Drawing.Point(426, 25);
            this.chMIMP.Name = "chMIMP";
            this.chMIMP.Size = new System.Drawing.Size(15, 14);
            this.chMIMP.TabIndex = 4;
            this.chMIMP.UseVisualStyleBackColor = true;
            this.chMIMP.Visible = false;
            this.chMIMP.CheckedChanged += new System.EventHandler(this.chMIMP_CheckedChanged);
            // 
            // chMEXC
            // 
            this.chMEXC.AutoSize = true;
            this.chMEXC.Location = new System.Drawing.Point(328, 25);
            this.chMEXC.Name = "chMEXC";
            this.chMEXC.Size = new System.Drawing.Size(15, 14);
            this.chMEXC.TabIndex = 3;
            this.chMEXC.UseVisualStyleBackColor = true;
            this.chMEXC.Visible = false;
            this.chMEXC.CheckedChanged += new System.EventHandler(this.chMEXC_CheckedChanged);
            // 
            // chMALT
            // 
            this.chMALT.AutoSize = true;
            this.chMALT.Location = new System.Drawing.Point(230, 25);
            this.chMALT.Name = "chMALT";
            this.chMALT.Size = new System.Drawing.Size(15, 14);
            this.chMALT.TabIndex = 2;
            this.chMALT.UseVisualStyleBackColor = true;
            this.chMALT.Visible = false;
            this.chMALT.CheckedChanged += new System.EventHandler(this.chMALT_CheckedChanged);
            // 
            // chMINS
            // 
            this.chMINS.AutoSize = true;
            this.chMINS.Location = new System.Drawing.Point(132, 25);
            this.chMINS.Name = "chMINS";
            this.chMINS.Size = new System.Drawing.Size(15, 14);
            this.chMINS.TabIndex = 1;
            this.chMINS.UseVisualStyleBackColor = true;
            this.chMINS.Visible = false;
            this.chMINS.CheckedChanged += new System.EventHandler(this.chMINS_CheckedChanged);
            // 
            // chMBLO
            // 
            this.chMBLO.AutoSize = true;
            this.chMBLO.Location = new System.Drawing.Point(173, 25);
            this.chMBLO.Name = "chMBLO";
            this.chMBLO.Size = new System.Drawing.Size(15, 14);
            this.chMBLO.TabIndex = 0;
            this.chMBLO.UseVisualStyleBackColor = true;
            this.chMBLO.CheckedChanged += new System.EventHandler(this.chMBLO_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNomePesquisado);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(27, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 51);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Permissões para o Usuário";
            // 
            // txtNomePesquisado
            // 
            this.txtNomePesquisado.Enabled = false;
            this.txtNomePesquisado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomePesquisado.Location = new System.Drawing.Point(6, 19);
            this.txtNomePesquisado.Name = "txtNomePesquisado";
            this.txtNomePesquisado.Size = new System.Drawing.Size(280, 20);
            this.txtNomePesquisado.TabIndex = 19;
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.Image = global::GUI.Properties.Resources.Search_48pxcolo;
            this.btnLocalizar.Location = new System.Drawing.Point(762, 17);
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(47, 47);
            this.btnLocalizar.TabIndex = 25;
            this.toolTip1.SetToolTip(this.btnLocalizar, "Localizar Usuário");
            this.btnLocalizar.UseVisualStyleBackColor = true;
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
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
            this.dgvDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nivel_id,
            this.nomefrm,
            this.descricao,
            this.bloqueado,
            this.inserir,
            this.alterar,
            this.excluir,
            this.imprimir});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDados.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDados.EnableHeadersVisualStyles = false;
            this.dgvDados.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvDados.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvDados.Location = new System.Drawing.Point(27, 123);
            this.dgvDados.Name = "dgvDados";
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
            this.dgvDados.Size = new System.Drawing.Size(782, 279);
            this.dgvDados.TabIndex = 24;
            // 
            // nivel_id
            // 
            this.nivel_id.HeaderText = "Código";
            this.nivel_id.Name = "nivel_id";
            this.nivel_id.Visible = false;
            // 
            // nomefrm
            // 
            this.nomefrm.HeaderText = "Formulário";
            this.nomefrm.Name = "nomefrm";
            this.nomefrm.Visible = false;
            this.nomefrm.Width = 200;
            // 
            // descricao
            // 
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            this.descricao.Width = 400;
            // 
            // bloqueado
            // 
            this.bloqueado.HeaderText = "Bloqueado";
            this.bloqueado.Name = "bloqueado";
            this.bloqueado.Width = 300;
            // 
            // inserir
            // 
            this.inserir.HeaderText = "Inserir";
            this.inserir.Name = "inserir";
            this.inserir.Visible = false;
            // 
            // alterar
            // 
            this.alterar.HeaderText = "Alterar";
            this.alterar.Name = "alterar";
            this.alterar.Visible = false;
            // 
            // excluir
            // 
            this.excluir.HeaderText = "Excluir";
            this.excluir.Name = "excluir";
            this.excluir.Visible = false;
            // 
            // imprimir
            // 
            this.imprimir.HeaderText = "Imprimir";
            this.imprimir.Name = "imprimir";
            this.imprimir.Visible = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(27, 31);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(727, 20);
            this.txtCodigo.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Código do Usuário";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btCancelar);
            this.panel2.Controls.Add(this.btSalvar);
            this.panel2.Controls.Add(this.btExcluir);
            this.panel2.Controls.Add(this.btAlterar);
            this.panel2.Controls.Add(this.btLocalizar);
            this.panel2.Location = new System.Drawing.Point(12, 463);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(836, 100);
            this.panel2.TabIndex = 1;
            // 
            // btCancelar
            // 
            this.btCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Image = global::GUI.Properties.Resources.Cancelar;
            this.btCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btCancelar.Location = new System.Drawing.Point(718, 10);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(92, 78);
            this.btCancelar.TabIndex = 10;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalvar.Image = global::GUI.Properties.Resources.Salvar1_fw;
            this.btSalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btSalvar.Location = new System.Drawing.Point(545, 10);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(92, 78);
            this.btSalvar.TabIndex = 9;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExcluir.Image = global::GUI.Properties.Resources.Excluir;
            this.btExcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btExcluir.Location = new System.Drawing.Point(372, 10);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(92, 78);
            this.btExcluir.TabIndex = 8;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAlterar.Image = global::GUI.Properties.Resources.Alterar;
            this.btAlterar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btAlterar.Location = new System.Drawing.Point(26, 10);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(92, 78);
            this.btAlterar.TabIndex = 7;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btAlterar.UseVisualStyleBackColor = true;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btLocalizar
            // 
            this.btLocalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLocalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLocalizar.Image = global::GUI.Properties.Resources.localizar_fw;
            this.btLocalizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btLocalizar.Location = new System.Drawing.Point(199, 13);
            this.btLocalizar.Name = "btLocalizar";
            this.btLocalizar.Size = new System.Drawing.Size(92, 78);
            this.btLocalizar.TabIndex = 6;
            this.btLocalizar.Text = "Localizar";
            this.btLocalizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btLocalizar.UseVisualStyleBackColor = true;
            this.btLocalizar.Click += new System.EventHandler(this.btLocalizar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(11)))), ((int)(((byte)(83)))));
            this.label5.Location = new System.Drawing.Point(248, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(284, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Cadastro Nivel de Acesso";
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
            this.iconeencerar.TabIndex = 47;
            this.iconeencerar.TabStop = false;
            this.iconeencerar.Click += new System.EventHandler(this.iconeencerar_Click);
            // 
            // frmCadastroNivelAcesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 575);
            this.Controls.Add(this.iconeencerar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadastroNivelAcesso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCadastroNivelAcesso";
            this.Load += new System.EventHandler(this.frmCadastroNivelAcesso_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbMarcarTodos.ResumeLayout(false);
            this.gbMarcarTodos.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconeencerar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbMarcarTodos;
        private System.Windows.Forms.CheckBox chMIMP;
        private System.Windows.Forms.CheckBox chMEXC;
        private System.Windows.Forms.CheckBox chMALT;
        private System.Windows.Forms.CheckBox chMINS;
        private System.Windows.Forms.CheckBox chMBLO;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNomePesquisado;
        private System.Windows.Forms.Button btnLocalizar;
        private MetroFramework.Controls.MetroGrid dgvDados;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        protected System.Windows.Forms.Button btCancelar;
        protected System.Windows.Forms.Button btSalvar;
        protected System.Windows.Forms.Button btExcluir;
        protected System.Windows.Forms.Button btAlterar;
        protected System.Windows.Forms.Button btLocalizar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nivel_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomefrm;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bloqueado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn inserir;
        private System.Windows.Forms.DataGridViewCheckBoxColumn alterar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn excluir;
        private System.Windows.Forms.DataGridViewCheckBoxColumn imprimir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox iconeencerar;
    }
}
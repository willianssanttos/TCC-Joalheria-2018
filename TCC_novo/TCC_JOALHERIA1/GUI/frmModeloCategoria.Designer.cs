namespace GUI
{
    partial class frmModeloCategoria
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
            this.pnDados = new System.Windows.Forms.Panel();
            this.pnBotoes = new System.Windows.Forms.Panel();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btLocalizar = new System.Windows.Forms.Button();
            this.btInserir = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnDados
            // 
            this.pnDados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnDados.Location = new System.Drawing.Point(12, 12);
            this.pnDados.Name = "pnDados";
            this.pnDados.Size = new System.Drawing.Size(836, 426);
            this.pnDados.TabIndex = 0;
            this.pnDados.Paint += new System.Windows.Forms.PaintEventHandler(this.pnDados_Paint);
            // 
            // pnBotoes
            // 
            this.pnBotoes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnBotoes.Controls.Add(this.btCancelar);
            this.pnBotoes.Controls.Add(this.btSalvar);
            this.pnBotoes.Controls.Add(this.btExcluir);
            this.pnBotoes.Controls.Add(this.btAlterar);
            this.pnBotoes.Controls.Add(this.btLocalizar);
            this.pnBotoes.Controls.Add(this.btInserir);
            this.pnBotoes.Location = new System.Drawing.Point(12, 444);
            this.pnBotoes.Name = "pnBotoes";
            this.pnBotoes.Size = new System.Drawing.Size(836, 97);
            this.pnBotoes.TabIndex = 1;
            // 
            // btCancelar
            // 
            this.btCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Image = global::GUI.Properties.Resources.Cancelar;
            this.btCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btCancelar.Location = new System.Drawing.Point(720, 16);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(92, 78);
            this.btCancelar.TabIndex = 5;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btCancelar.UseVisualStyleBackColor = true;
            // 
            // btSalvar
            // 
            this.btSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalvar.Image = global::GUI.Properties.Resources.Salvar1_fw;
            this.btSalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btSalvar.Location = new System.Drawing.Point(583, 16);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(92, 78);
            this.btSalvar.TabIndex = 4;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btSalvar.UseVisualStyleBackColor = true;
            // 
            // btExcluir
            // 
            this.btExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExcluir.Image = global::GUI.Properties.Resources.Excluir;
            this.btExcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btExcluir.Location = new System.Drawing.Point(446, 16);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(92, 78);
            this.btExcluir.TabIndex = 3;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btExcluir.UseVisualStyleBackColor = true;
            // 
            // btAlterar
            // 
            this.btAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAlterar.Image = global::GUI.Properties.Resources.Alterar;
            this.btAlterar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btAlterar.Location = new System.Drawing.Point(309, 16);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(92, 78);
            this.btAlterar.TabIndex = 2;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btAlterar.UseVisualStyleBackColor = true;
            // 
            // btLocalizar
            // 
            this.btLocalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLocalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLocalizar.Image = global::GUI.Properties.Resources.localizar_fw;
            this.btLocalizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btLocalizar.Location = new System.Drawing.Point(172, 16);
            this.btLocalizar.Name = "btLocalizar";
            this.btLocalizar.Size = new System.Drawing.Size(92, 78);
            this.btLocalizar.TabIndex = 1;
            this.btLocalizar.Text = "Localizar";
            this.btLocalizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btLocalizar.UseVisualStyleBackColor = true;
            // 
            // btInserir
            // 
            this.btInserir.BackColor = System.Drawing.Color.White;
            this.btInserir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInserir.Image = global::GUI.Properties.Resources.Novo;
            this.btInserir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btInserir.Location = new System.Drawing.Point(35, 16);
            this.btInserir.Name = "btInserir";
            this.btInserir.Size = new System.Drawing.Size(92, 78);
            this.btInserir.TabIndex = 0;
            this.btInserir.Text = "Inserir";
            this.btInserir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btInserir.UseVisualStyleBackColor = false;
            this.btInserir.Click += new System.EventHandler(this.btInserir_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // frmModeloCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 553);
            this.Controls.Add(this.pnBotoes);
            this.Controls.Add(this.pnDados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmModeloCategoria";
            this.Text = "Cadastro Modelo";
            this.Load += new System.EventHandler(this.frmModeloCategoria_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmModeloCategoria_KeyDown);
            this.pnBotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel pnDados;
        protected System.Windows.Forms.Panel pnBotoes;
        protected System.Windows.Forms.Button btCancelar;
        protected System.Windows.Forms.Button btSalvar;
        protected System.Windows.Forms.Button btExcluir;
        protected System.Windows.Forms.Button btAlterar;
        protected System.Windows.Forms.Button btLocalizar;
        protected System.Windows.Forms.Button btInserir;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;

    }
}
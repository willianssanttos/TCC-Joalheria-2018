namespace GUI
{
    partial class frmBackupBancoDeDados
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
            this.btBackup = new System.Windows.Forms.Button();
            this.btRestaurar = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.iconeencerar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconeencerar)).BeginInit();
            this.SuspendLayout();
            // 
            // btBackup
            // 
            this.btBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBackup.Location = new System.Drawing.Point(12, 28);
            this.btBackup.Name = "btBackup";
            this.btBackup.Size = new System.Drawing.Size(417, 204);
            this.btBackup.TabIndex = 0;
            this.btBackup.Text = "Backup do banco de dados";
            this.btBackup.UseVisualStyleBackColor = true;
            this.btBackup.Click += new System.EventHandler(this.btBackup_Click);
            // 
            // btRestaurar
            // 
            this.btRestaurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRestaurar.Location = new System.Drawing.Point(12, 249);
            this.btRestaurar.Name = "btRestaurar";
            this.btRestaurar.Size = new System.Drawing.Size(417, 204);
            this.btRestaurar.TabIndex = 3;
            this.btRestaurar.Text = "Restaurar o banco de dados";
            this.btRestaurar.UseVisualStyleBackColor = true;
            this.btRestaurar.Click += new System.EventHandler(this.btRestaurar_Click);
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
            this.iconeencerar.Image = global::GUI.Properties.Resources.icon_cerrar2;
            this.iconeencerar.Location = new System.Drawing.Point(414, 7);
            this.iconeencerar.Name = "iconeencerar";
            this.iconeencerar.Size = new System.Drawing.Size(15, 15);
            this.iconeencerar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconeencerar.TabIndex = 47;
            this.iconeencerar.TabStop = false;
            this.iconeencerar.Click += new System.EventHandler(this.iconeencerar_Click_1);
            // 
            // frmBackupBancoDeDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(444, 465);
            this.Controls.Add(this.iconeencerar);
            this.Controls.Add(this.btRestaurar);
            this.Controls.Add(this.btBackup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBackupBancoDeDados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backup do Banco de Dados";
            ((System.ComponentModel.ISupportInitialize)(this.iconeencerar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btBackup;
        private System.Windows.Forms.Button btRestaurar;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox iconeencerar;
    }
}
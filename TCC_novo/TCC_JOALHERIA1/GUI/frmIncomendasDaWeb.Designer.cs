namespace GUI
{
    partial class frmIncomendasDaWeb
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtMensagem = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAnexar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAssunto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPara = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(11)))), ((int)(((byte)(83)))));
            this.label5.Location = new System.Drawing.Point(207, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(222, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "Encomenda da Web";
            // 
            // txtMensagem
            // 
            this.txtMensagem.Location = new System.Drawing.Point(179, 248);
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(411, 136);
            this.txtMensagem.TabIndex = 18;
            this.txtMensagem.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Mensagem:";
            // 
            // txtAnexar
            // 
            this.txtAnexar.Enabled = false;
            this.txtAnexar.Location = new System.Drawing.Point(179, 183);
            this.txtAnexar.Name = "txtAnexar";
            this.txtAnexar.Size = new System.Drawing.Size(411, 20);
            this.txtAnexar.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Material:";
            // 
            // txtAssunto
            // 
            this.txtAssunto.Location = new System.Drawing.Point(179, 139);
            this.txtAssunto.Name = "txtAssunto";
            this.txtAssunto.Size = new System.Drawing.Size(411, 20);
            this.txtAssunto.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "E-mail:";
            // 
            // txtPara
            // 
            this.txtPara.Location = new System.Drawing.Point(179, 93);
            this.txtPara.Name = "txtPara";
            this.txtPara.Size = new System.Drawing.Size(411, 20);
            this.txtPara.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nome completo:";
            // 
            // frmIncomendasDaWeb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 460);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMensagem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAnexar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAssunto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPara);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmIncomendasDaWeb";
            this.Text = "frmIncomendasDaWeb";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox txtMensagem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAnexar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAssunto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPara;
        private System.Windows.Forms.Label label1;
    }
}
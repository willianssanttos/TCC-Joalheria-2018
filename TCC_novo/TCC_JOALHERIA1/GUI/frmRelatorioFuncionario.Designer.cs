namespace GUI
{
    partial class frmRelatorioFuncionario
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconeencerar = new System.Windows.Forms.PictureBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.JOALHERIADataSet = new GUI.JOALHERIADataSet();
            this.funcionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.funcionarioTableAdapter = new GUI.JOALHERIADataSetTableAdapters.funcionarioTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconeencerar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JOALHERIADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.reportViewer1);
            this.panel1.Location = new System.Drawing.Point(12, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 490);
            this.panel1.TabIndex = 0;
            // 
            // iconeencerar
            // 
            this.iconeencerar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconeencerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconeencerar.Image = global::GUI.Properties.Resources.cerrar;
            this.iconeencerar.Location = new System.Drawing.Point(857, 12);
            this.iconeencerar.Name = "iconeencerar";
            this.iconeencerar.Size = new System.Drawing.Size(15, 15);
            this.iconeencerar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconeencerar.TabIndex = 51;
            this.iconeencerar.TabStop = false;
            this.iconeencerar.Click += new System.EventHandler(this.iconeencerar_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "funcionario";
            reportDataSource2.Value = this.funcionarioBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.Funcionario.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(860, 490);
            this.reportViewer1.TabIndex = 0;
            // 
            // JOALHERIADataSet
            // 
            this.JOALHERIADataSet.DataSetName = "JOALHERIADataSet";
            this.JOALHERIADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // funcionarioBindingSource
            // 
            this.funcionarioBindingSource.DataMember = "funcionario";
            this.funcionarioBindingSource.DataSource = this.JOALHERIADataSet;
            // 
            // funcionarioTableAdapter
            // 
            this.funcionarioTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(301, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(238, 25);
            this.label5.TabIndex = 52;
            this.label5.Text = "Relatório Funcionario";
            // 
            // frmRelatorioFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(11)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(884, 550);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.iconeencerar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRelatorioFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRelatorioFuncionario";
            this.Load += new System.EventHandler(this.frmRelatorioFuncionario_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconeencerar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JOALHERIADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox iconeencerar;
        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource funcionarioBindingSource;
        private JOALHERIADataSet JOALHERIADataSet;
        private JOALHERIADataSetTableAdapters.funcionarioTableAdapter funcionarioTableAdapter;
        private System.Windows.Forms.Label label5;
    }
}
namespace YurtKayitSistemi
{
    partial class FrmOgrenciRapor
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOgrenciRapor));
            this.OgrenciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.YurtKayitDataSet9 = new YurtKayitSistemi.YurtKayitDataSet9();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.OgrenciTableAdapter = new YurtKayitSistemi.YurtKayitDataSet9TableAdapters.OgrenciTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.OgrenciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YurtKayitDataSet9)).BeginInit();
            this.SuspendLayout();
            // 
            // OgrenciBindingSource
            // 
            this.OgrenciBindingSource.DataMember = "Ogrenci";
            this.OgrenciBindingSource.DataSource = this.YurtKayitDataSet9;
            // 
            // YurtKayitDataSet9
            // 
            this.YurtKayitDataSet9.DataSetName = "YurtKayitDataSet9";
            this.YurtKayitDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.MintCream;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.OgrenciBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "YurtKayitSistemi.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(915, 423);
            this.reportViewer1.TabIndex = 0;
            // 
            // OgrenciTableAdapter
            // 
            this.OgrenciTableAdapter.ClearBeforeFill = true;
            // 
            // FrmOgrenciRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(914, 424);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOgrenciRapor";
            this.Text = "Öğrenci Rapor";
            this.Load += new System.EventHandler(this.FrmOgrenciRapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OgrenciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YurtKayitDataSet9)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource OgrenciBindingSource;
        private YurtKayitDataSet9 YurtKayitDataSet9;
        private YurtKayitDataSet9TableAdapters.OgrenciTableAdapter OgrenciTableAdapter;
    }
}
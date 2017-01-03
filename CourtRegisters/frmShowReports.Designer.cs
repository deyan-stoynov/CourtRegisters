namespace CourtRegisters.Reports
{
    partial class frmShowReports
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
            this.biddersByCSIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rwReports = new Microsoft.Reporting.WinForms.ReportViewer();
            this.vwProtocolsForDayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BidderByDateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.biddersByCSIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwProtocolsForDayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BidderByDateBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // biddersByCSIBindingSource
            // 
            this.biddersByCSIBindingSource.DataSource = typeof(CourtRegisters.Reports.BiddersByCSI);
            // 
            // rwReports
            // 
            this.rwReports.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "dsBidders";
            reportDataSource2.Value = this.biddersByCSIBindingSource;
            this.rwReports.LocalReport.DataSources.Add(reportDataSource2);
            this.rwReports.LocalReport.ReportEmbeddedResource = "CourtRegisters.Reports.BidderByCSI.rdlc";
            this.rwReports.Location = new System.Drawing.Point(0, 0);
            this.rwReports.Name = "rwReports";
            this.rwReports.Size = new System.Drawing.Size(727, 262);
            this.rwReports.TabIndex = 0;
            // 
            // vwProtocolsForDayBindingSource
            // 
            this.vwProtocolsForDayBindingSource.DataSource = typeof(CourtRegisters.vwProtocolsForDay);
            // 
            // BidderByDateBindingSource
            // 
            this.BidderByDateBindingSource.DataSource = typeof(CourtRegisters.BidderByDate);
            // 
            // frmShowReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 262);
            this.Controls.Add(this.rwReports);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmShowReports";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.BiddersReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.biddersByCSIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwProtocolsForDayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BidderByDateBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rwReports;
        private System.Windows.Forms.BindingSource biddersByCSIBindingSource;
        private System.Windows.Forms.BindingSource vwProtocolsForDayBindingSource;
        private System.Windows.Forms.BindingSource BidderByDateBindingSource;
    }
}
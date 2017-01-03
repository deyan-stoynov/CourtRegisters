using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using CourtRegisters.ReportManagers;

namespace CourtRegisters.Reports
{
    public partial class frmShowReports : Form
    {
        public int IdCSI { get; set; }
        public string CaseNumber { get; set; }
        public enReports ReportType { get; set; }
        public DateTime PostingDate { get; set; }
        public DateTime EndPostingDate { get; set; }

        public frmShowReports(int nIdCSI, string sCaseNumber, enReports enReportType)
        {
            this.IdCSI = nIdCSI;
            this.CaseNumber = sCaseNumber;
            ReportType = enReportType;
            InitializeComponent();
        }

        private void BiddersReport_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            switch (ReportType)
            {
                case enReports.BiddersByCSI:
                    {
                        GenReportBidderByCSI();
                        break;
                    }
                case enReports.ProtocolsForDay:
                    {
                        GenReportProtocolsForDay();
                        break;
                    }
                case enReports.BiddersByDate:
                    {
                        GenReportBiddersForDate();
                        break;
                    }
            }
        }

        private void GenReportBiddersForDate()
        {
            ReportDataSource reportDataSource1 = new ReportDataSource();
            reportDataSource1.Name = "dsBiddersByDate";
            reportDataSource1.Value = this.BidderByDateBindingSource;
            this.rwReports.LocalReport.DataSources.Add(reportDataSource1);
            this.rwReports.LocalReport.ReportEmbeddedResource = "CourtRegisters.Reports.BidderByDate.rdlc";
            BidderByDateBindingSource.DataSource = clsBidderByDate.PopulateBidders(PostingDate);
            this.rwReports.RefreshReport();
        }

        private void GenReportProtocolsForDay()
        {
            ReportDataSource reportDataSource1 = new ReportDataSource();
            reportDataSource1.Name = "dsProtocols";
            reportDataSource1.Value = this.vwProtocolsForDayBindingSource;
            this.rwReports.LocalReport.DataSources.Add(reportDataSource1);
            this.rwReports.LocalReport.ReportEmbeddedResource = "CourtRegisters.Reports.ProtocolsByDate.rdlc";
            vwProtocolsForDayBindingSource.DataSource = ProtocolsForDay.PopulateProtocols(IdCSI, PostingDate, EndPostingDate);
            this.rwReports.RefreshReport();
        }

        private void GenReportBidderByCSI()
        {
            this.rwReports.LocalReport.ReportEmbeddedResource = "CourtRegisters.Reports.BidderByCSI.rdlc";
            biddersByCSIBindingSource.DataSource = BiddersByCSI.PopulateBidders(IdCSI, CaseNumber);
            rwReports.LocalReport.SetParameters(BiddersByCSI.PrepareParameters(IdCSI, CaseNumber));
            this.rwReports.RefreshReport();
        }
    }
}

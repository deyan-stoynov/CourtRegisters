using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CourtRegisters.Reports;

namespace CourtRegisters
{
    public partial class frmBiddersByDate : ListForm
    {
        public frmBiddersByDate()
        {
            InitializeComponent();
        }

        private void frmAllBidders_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void BindGrid()
        {
            DateTime dtTo = dtpPostingDate.Value.AddDays(1).Date;
            DateTime dtFrom = dtpPostingDate.Value.Date;//.AddDays(-1).Date;

            CourtRegistersDBEntities db = new CourtRegistersDBEntities();
            {
                var res = from eBidders in db.tblRegisterBidders.Include("tblCSI")
                          orderby eBidders.ID descending
                          where eBidders.PostingDate > dtFrom && eBidders.PostingDate < dtTo
                          select new
                          {
                              ID = eBidders.ID,
                              IncomeNumber = eBidders.IncomeNumber,
                              tblCSI = eBidders.tblCSI.CSIName,
                              CaseNumber = eBidders.CaseNumber,
                              BidderName = eBidders.BidderName,
                              BidderAddress = eBidders.BidderAddress,
                              PostingDate = eBidders.PostingDate,
                              IdCSI = eBidders.IdCSI
                          };

                tblRegisterBidderBindingSource.DataSource = res;
            }

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            dtpPostingDate.Value = DateTime.Today;
            BindGrid();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            frmShowReports report = new frmShowReports(0, "", enReports.BiddersByDate) { PostingDate = dtpPostingDate.Value.Date };
            report.ShowDialog();
            report.Dispose();
        }

        private void cmsCopyCell_Opening(object sender, CancelEventArgs e)
        {
            Clipboard.SetText(dgvBidders.SelectedCells[0].Value.ToString());
        }
    }
}

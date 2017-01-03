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
    public partial class frmAllBidders : ListForm
    {
        public frmAllBidders()
        {
            InitializeComponent();
        }

        private void frmAllBidders_Load(object sender, EventArgs e)
        {
            BindCSI();
            BindGrid();
        }

        private void BindCSI()
        {
            using (CourtRegistersDBEntities db = new CourtRegistersDBEntities())
            {
                cbCSI.DisplayMember = "CSIName";
                cbCSI.ValueMember = "IdCSI";
                List<tblCSI> CSIlist = db.tblCSIs.OrderBy(csi => csi.CSIName).ToList();
                CSIlist.Insert(0, new tblCSI() { CSIName = "Всички", IdCSI = 0 });
                cbCSI.DataSource = CSIlist;
            }
        }

        private void BindGrid()
        {
            CourtRegistersDBEntities db = new CourtRegistersDBEntities();
            {
                var res = from eBidders in db.tblRegisterBidders.Include("tblCSI")
                          orderby eBidders.ID descending
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

                int nCSIId = cbCSI.SelectedValue.ToString().ToInt();
                if (nCSIId != 0)
                {
                    res = res.Where(bider => bider.IdCSI == nCSIId);
                }

                if (txtCaseNumber.Text.Trim() != string.Empty)
                {
                    res = res.Where(bider => bider.CaseNumber.Contains(txtCaseNumber.Text));
                }

                tblRegisterBidderBindingSource.DataSource = res;
            }

        }

        private void dgvBidders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvBidders.Columns[e.ColumnIndex].Name == "Edit")
            {
                frmBidder frmSelectedBidder = new frmBidder((int)dgvBidders["ID", e.RowIndex].Value);
                frmSelectedBidder.ShowDialog();
                frmSelectedBidder.Dispose();
                BindGrid();
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            txtCaseNumber.Text = string.Empty;
            cbCSI.SelectedValue = 0;
            BindGrid();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            int nIdCSI = cbCSI.SelectedValue.ToString().ToInt();
            string sCaseNumber = txtCaseNumber.Text.Trim();
            if (sCaseNumber == string.Empty || nIdCSI == 0)
            {
                MessageBox.Show("Полето 'Номер на дело' и 'Име на ЧСИ' са задължителни");
                return;
            }
            frmShowReports report = new frmShowReports(nIdCSI, sCaseNumber, enReports.BiddersByCSI);
            report.ShowDialog();
            report.Dispose();
        }

        private void cmsCopyCell_Opening(object sender, CancelEventArgs e)
        {
            Clipboard.SetText(dgvBidders.SelectedCells[0].Value.ToString());
        }

        private void dgvBidders_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvBidders.SelectedCells[0].OwningColumn.Name == "CaseNumber")
            {
                txtCaseNumber.Text = dgvBidders.SelectedCells[0].Value.ToString();
            }
        }
    }
}

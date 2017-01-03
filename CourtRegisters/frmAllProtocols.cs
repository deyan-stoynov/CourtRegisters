using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CourtRegisters.Reports;
using System.Globalization;
using System.Threading;

namespace CourtRegisters
{
    public partial class frmAllProtocols : ListForm
    {
        public frmAllProtocols()
        {
            InitializeComponent();
        }

        private void dgvProtocols_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProtocols.Columns[e.ColumnIndex].Name == "Edit")
            {
                frmProtocol frmSelectedProt = new frmProtocol((int)dgvProtocols["ID", e.RowIndex].Value);
                frmSelectedProt.ShowDialog();
                frmSelectedProt.Dispose();
                BindGrid();
            }
        }

        private void BindGrid()
        {
            CourtRegistersDBEntities db = new CourtRegistersDBEntities();
            {

                DateTime dtFrom = dtpFrom.Value;//.AddDays(-1);
                DateTime dtTo = dtpTo.Value.AddDays(1);

                var res = from eProt in db.tblRegisterProtocols
                          where eProt.PostingDate > dtFrom && eProt.PostingDate < dtTo
                          orderby eProt.ID descending
                          select new
                          {
                              eProt.ID,
                              eProt.IncomeNumber,
                              eProt.IdCSI,
                              tblCSI = eProt.tblCSI.CSIName,
                              eProt.CaseNumber,
                              eProt.tblCSI.CSIName,
                              eProt.Remarks,
                              eProt.PostingDate,
                              //eProt.Canceled
                          };

                int nCSIId = cbCSI.SelectedValue.ToString().ToInt();
                if (nCSIId != 0)
                {
                    res = res.Where(bider => bider.IdCSI == nCSIId);
                }
                //if (chbCanceled.Checked)
                //{
                //    res = res.Where(it => it.Canceled == chbCanceled.Checked);
                //}

                tblRegisterProtocolBindingSource.DataSource = res;
            }
        }

        private void frmAllProtocols_Load(object sender, EventArgs e)
        {
            dtpFrom.Value = DateTime.Today;
            dtpTo.Value = DateTime.Today;
            dtpFrom.MaxDate = DateTime.Today;
            dtpTo.MaxDate = DateTime.Today;
            BindCSI();
            BindGrid();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //if (dtpFrom.Value == dtpTo.Value)
            //{
            int nIdCSI = cbCSI.SelectedValue.ToString().ToInt();
            frmShowReports report = new frmShowReports(nIdCSI, "", enReports.ProtocolsForDay) { PostingDate = dtpFrom.Value, EndPostingDate = dtpTo.Value };
            report.ShowDialog();
            report.Dispose();
            //}
            //else
            //{
            //    MessageBox.Show("Датата 'От:' и 'До:' трябва да са еднакви за нужната справка!");
            //}
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

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            cbCSI.SelectedIndex = 0;
            chbCanceled.Checked = false;
            BindGrid();
        }

        private void dtpTo_ValueChanged(object sender, EventArgs e)
        {
            //if (dtpFrom.Value > dtpTo.Value)
            //{
            //    MessageBox.Show("Началната дата не може да бъде по-голяма от крайната!");
            //    dtpTo.Value = dtpFrom.Value;
            //}
        }
    }
}

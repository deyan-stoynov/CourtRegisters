using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CourtRegisters
{
    public partial class frmAllSaleLocation : ListForm
    {
        public frmAllSaleLocation()
        {
            InitializeComponent();
        }

        private void frmAllSaleLocation_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void BindGrid()
        {
            CourtRegistersDBEntities db = new CourtRegistersDBEntities();
            {
                var res = from eSaleRoom in db.tblRegisterPublicSalesRooms
                          orderby eSaleRoom.ID descending
                          select new
                          {
                              eSaleRoom.ID,
                              eSaleRoom.IncomeNumber,
                              eSaleRoom.PublicSaleLocation,
                              tblCSI = eSaleRoom.tblCSI.CSIName,
                              eSaleRoom.PostingDate,
                              eSaleRoom.Remarks,
                              eSaleRoom.PublicSaleDateTime,
                              //eSaleRoom.Canceled
                          };
                //if (chbCanceled.Checked)
                //{
                //    res = res.Where(it => it.Canceled);
                //}
                tblRegisterPublicSalesRoomBindingSource.DataSource = res;
            }
        }

        private void dgvBidders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvBidders.Columns[e.ColumnIndex].Name == "Edit")
            {
                frmSaleLocation frmSelectedSaleLocation = new frmSaleLocation((int)dgvBidders["ID", e.RowIndex].Value);
                frmSelectedSaleLocation.ShowDialog();
                frmSelectedSaleLocation.Dispose();
                BindGrid();
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            chbCanceled.Checked = false;
        }
    }
}

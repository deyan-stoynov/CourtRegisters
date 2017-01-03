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
    public partial class frmAllCSI : ListForm
    {
        public frmAllCSI()
        {
            InitializeComponent();
        }

        private void frmAllCSI_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void BindGrid()
        {
            using (CourtRegistersDBEntities db = new CourtRegistersDBEntities())
            {
                gvCSIs.AutoGenerateColumns = false;
                gvCSIs.DataSource = db.tblCSIs.OrderBy(it => it.CSIName).ToList();
            }
        }

        private void gvCSIs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var grid = sender as DataGridView;
                int id = (grid.Rows[e.RowIndex].DataBoundItem as tblCSI).IdCSI;
                if (grid.Columns[e.ColumnIndex].Name == "Edit")
                {
                    using (var csiForm = new frmCSI(id))
                    {
                        csiForm.ShowDialog(this);
                    }
                    BindGrid();
                }
                else if (grid.Columns[e.ColumnIndex].Name == "Delete")
                {
                    using (CourtRegistersDBEntities db = new CourtRegistersDBEntities())
                    {
                        var csi = new tblCSI()
                        {
                            IdCSI = id
                        };
                        db.tblCSIs.Attach(csi);
                        db.DeleteObject(csi);
                        db.SaveChanges();
                        BindGrid();
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (frmCSI frmCSI = new frmCSI(0))
            {
                frmCSI.ShowDialog();
                BindGrid();
            }
        }
    }
}

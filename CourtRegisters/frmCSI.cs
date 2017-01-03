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
    public partial class frmCSI : EditForm
    {
        public frmCSI(int aID)
        {
            nID = aID;
            InitializeComponent();
        }

        private int nID;

        private void frmBidders_Load(object sender, EventArgs e)
        {
            if (nID != 0)
            {
                GetBidder();
            }
            txtCSINumber.Focus();
        }


        private void GetBidder()
        {
            using (CourtRegistersDBEntities db = new CourtRegistersDBEntities())
            {
                var csi = db.tblCSIs.FirstOrDefault(bid => bid.IdCSI == nID);
                txtCSIName.Text = csi.CSIName;
                txtCSINumber.Text = csi.CSINumber.ToString();
                IsActive_ckb.Checked = csi.IsActive;
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateSave())
            {
                MessageBox.Show("Моля Въведете Задължителните полета");
                return;
            }
            if (SaveCSI())
            {
                this.Close();
            }
        }

        private bool SaveCSI()
        {
            using (CourtRegistersDBEntities db = new CourtRegistersDBEntities())
            {
                try
                {
                    if (nID == 0)
                    {
                        var newCSI = new tblCSI()
                        {
                            CSIName = txtCSIName.Text,
                            CSINumber = txtCSINumber.Text.ToInt(),
                            IsActive = IsActive_ckb.Checked
                        };

                        db.tblCSIs.AddObject(newCSI);
                    }
                    else
                    {
                        var csi = db.tblCSIs.FirstOrDefault(it => it.IdCSI == nID);
                        if (csi != null)
                        {
                            csi.CSIName = txtCSIName.Text;
                            csi.CSINumber = txtCSINumber.Text.ToInt();
                            csi.IsActive = IsActive_ckb.Checked;
                        }
                    }
                    db.SaveChanges();

                    MessageBox.Show("Записът Успешен!", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return true;
                }
                catch (Exception err)
                {
                    if (err.InnerException == null)
                    {
                        MessageBox.Show(err.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show(err.InnerException.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    return false;
                }
            }
        }

        private bool ValidateSave()
        {
            if (txtCSIName.Text.Trim() == string.Empty)
                return false;
            if (txtCSINumber.Text.Trim() == string.Empty)
                return false;

            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveAndNew_Click(object sender, EventArgs e)
        {
            if (!ValidateSave())
            {
                MessageBox.Show("Моля Въведете Задължителните полета");
                return;
            }
            if (SaveCSI())
            {
                frmCSI frmCSI = new frmCSI(0);
                frmCSI.ShowDialog();
                this.Close();
            }
        }
    }
}

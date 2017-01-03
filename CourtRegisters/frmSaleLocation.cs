using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using CourtRegisters.Repository;

namespace CourtRegisters
{
    public partial class frmSaleLocation : EditForm
    {
        private int nID;

        public frmSaleLocation(int aID)
        {
            nID = aID;
            InitializeComponent();
        }

        private void frmSaleLocation_Load(object sender, EventArgs e)
        {
            BindCSI();
            if (nID != 0)
            {
                GetSaleLocation();
            }
            else
            {
                txtSaleLocation.Text = ConfigurationManager.AppSettings["SaleLocation"] ?? string.Empty;
            }
            cbCSI.Focus();
        }

        private void GetSaleLocation()
        {
            using (CourtRegistersDBEntities db = new CourtRegistersDBEntities())
            {
                tblRegisterPublicSalesRoom oSaleLocation = db.tblRegisterPublicSalesRooms.FirstOrDefault(bid => bid.ID == nID);
                dtpPostingDate.Value = oSaleLocation.PostingDate;
                txtRemark.Text = oSaleLocation.Remarks;
                txtSaleLocation.Text = oSaleLocation.PublicSaleLocation;
                dtpSaleTime.Value = oSaleLocation.PublicSaleDateTime;
                cbCSI.SelectedValue = oSaleLocation.IdCSI;
            }
        }

        private void BindCSI()
        {
            using (CourtRegistersDBEntities db = new CourtRegistersDBEntities())
            {
                cbCSI.DisplayMember = "CSINumber";
                cbCSI.ValueMember = "IdCSI";
                cbCSI.DataSource = db.tblCSIs.OrderBy(csi => csi.CSINumber);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateSave())
            {
                MessageBox.Show("Моля Въведете Задължителните полета");
                return;
            }
            if (SaveSaleLocation())
            {
                this.Close();
            }
        }

        private bool SaveSaleLocation()
        {
            bool success = false;
            using (PublicSalesRoomsRepository repository = new PublicSalesRoomsRepository())
            {
                try
                {
                    //var IdReg = db.Insert_RegSaleLocation_SP(nID
                    //                       , (int)cbCSI.SelectedValue
                    //                       , dtpSaleTime.Value
                    //                       , txtSaleLocation.Text
                    //                       , txtRemark.Text
                    //                       , dtpPostingDate.Value);
                    var model = new tblRegisterPublicSalesRoom()
                    {
                        ID = nID,
                        IdCSI = (int)cbCSI.SelectedValue,
                        PublicSaleDateTime = dtpSaleTime.Value,
                        PublicSaleLocation = txtSaleLocation.Text,
                        Remarks = txtRemark.Text,
                        PostingDate = dtpPostingDate.Value
                    };
                    success = repository.Save(ref model);
                    MessageBox.Show("Записът Успешен! Входящ № " + model.IncomeNumber, "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
                }
            }
            return success;
        }

        private bool ValidateSave()
        {
            if (txtSaleLocation.Text.Trim() == string.Empty)
                return false;
            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbCSI_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (CourtRegistersDBEntities db = new CourtRegistersDBEntities())
            {
                int nIdCSI = cbCSI.SelectedValue.ToString().ToInt();
                lblCSIName.Text = db.tblCSIs.FirstOrDefault(p => p.IdCSI == nIdCSI).CSIName;
            }
        }

        private void btnSaveAndNew_Click(object sender, EventArgs e)
        {
            if (!ValidateSave())
            {
                MessageBox.Show("Моля Въведете Задължителните полета");
                return;
            }
            if (SaveSaleLocation())
            {
                frmSaleLocation frmSaleLocation = new frmSaleLocation(0);
                frmSaleLocation.ShowDialog();
                this.Close();
            }
        }
    }
}

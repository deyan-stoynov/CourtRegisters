using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CourtRegisters.Repository;

namespace CourtRegisters
{
    public partial class frmProtocol : EditForm
    {
        private int nID;

        public frmProtocol(int aID)
        {
            nID = aID;
            InitializeComponent();
        }

        private void frmProtocol_Load(object sender, EventArgs e)
        {
            BindCSI();
            if (nID != 0)
            {
                GetProtocol();
            }
            //txtCaseNumber.Focus();
            cbCSI.Focus();
            txtCaseSIPart.Text = cbCSI.Text;
        }

        private void GetProtocol()
        {
            using (CourtRegistersDBEntities db = new CourtRegistersDBEntities())
            {

                tblRegisterProtocol oProtocol = db.tblRegisterProtocols.FirstOrDefault(bid => bid.ID == nID);
                txtRemark.Text = oProtocol.Remarks;
                txtCaseFirstPart.Text = oProtocol.CaseNumber.Substring(0, 2);
                txtCaseYearPart.Text = oProtocol.CaseNumber.Substring(2, 2);
                txtCaseSIPart.Text = oProtocol.CaseNumber.Substring(4, 3);
                txtCaseCodePart.Text = oProtocol.CaseNumber.Substring(7, 2);
                txtCaseNumberPart.Text = oProtocol.CaseNumber.Substring(9, 5);

                dateTimePicker1.Value = oProtocol.PostingDate;
                cbCSI.SelectedValue = oProtocol.IdCSI;
                //chbCanceled.Checked = oProtocol.Canceled;
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

        private void cbCSI_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (CourtRegistersDBEntities db = new CourtRegistersDBEntities())
            {
                int nIdCSI = cbCSI.SelectedValue.ToString().ToInt();
                lblCSIName.Text = db.tblCSIs.FirstOrDefault(p => p.IdCSI == nIdCSI).CSIName;
            }
            txtCaseSIPart.Text = cbCSI.Text;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateSave())
            {
                MessageBox.Show("Моля Въведете Задължителните полета");
                return;
            }
            if (SaveProtocol())
            {
                this.Close();
            }

        }

        private bool SaveProtocol()
        {
            bool success = false;
            using (ProtocolsRepository repository = new ProtocolsRepository())
            {
                try
                {

                    //var IdReg = db.Insert_RegProtocols_SP(nID
                    //                       , GetCaseNumber()
                    //                       , (int)cbCSI.SelectedValue
                    //                       , txtRemark.Text
                    //                       , dateTimePicker1.Value);

                    var protocol = new tblRegisterProtocol()
                    {
                        ID = nID,
                        CaseNumber = GetCaseNumber(),
                        IdCSI = (int)cbCSI.SelectedValue,
                        Remarks = txtRemark.Text,
                        PostingDate = dateTimePicker1.Value,
                        //Canceled = chbCanceled.Checked
                    };

                    success = repository.Save(ref protocol);
                    MessageBox.Show("Записът Успешен! Входящ № " + protocol.IncomeNumber, "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
                        if (err.InnerException.Message.Contains("IX_tblRegisterProtocols_IdCSI_CaseNumber"))
                        {
                            MessageBox.Show("Записът съществува", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                            MessageBox.Show(err.InnerException.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            return success;
        }

        private bool ValidateSave()
        {
            return ValidateCaseNumber();
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
            if (SaveProtocol())
            {
                frmProtocol frmProtocol = new frmProtocol(0);
                frmProtocol.ShowDialog();
                this.Close();
            }
        }

        private bool ValidateCaseNumber()
        {
            if (txtCaseFirstPart.Text == string.Empty ||
               txtCaseYearPart.Text == string.Empty ||
               txtCaseSIPart.Text == string.Empty ||
               txtCaseCodePart.Text == string.Empty ||
               txtCaseNumberPart.Text == string.Empty)
                return false;

            if (cbCSI.Text != txtCaseSIPart.Text)
            {
                return false;
            }

            return true;
        }

        private string GetCaseNumber()
        {
            string caseNumber = string.Format("{0}{1}{2}{3}{4}", txtCaseFirstPart.Text,
                                                                 txtCaseYearPart.Text,
                                                                 txtCaseSIPart.Text,
                                                                 txtCaseCodePart.Text,
                                                                 txtCaseNumberPart.Text);
            return caseNumber;
        }
    }
}

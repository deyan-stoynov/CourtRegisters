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
    public partial class frmBidder : EditForm
    {
        public frmBidder(int aID)
        {
            nID = aID;
            InitializeComponent();
        }

        private int nID;

        private void frmBidders_Load(object sender, EventArgs e)
        {
            BindCSI();
            if (nID != 0)
            {
                GetBidder();
            }
            else
            {
                GetExcistingBidders();
            }
            cbCases.Focus();
        }

        private void GetExcistingBidders()
        {
            using (CourtRegistersDBEntities db = new CourtRegistersDBEntities())
            {
                var oBidders = (from eBidder in db.tblRegisterBidders
                                select eBidder.BidderName).Distinct().Take(500);

                if (oBidders == null)
                    return;
                AutoCompleteStringCollection source = new AutoCompleteStringCollection();
                source.AddRange(oBidders.ToArray());

                txtBidderName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtBidderName.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtBidderName.AutoCompleteCustomSource = source;
            }
        }

        private void GetBidder()
        {
            using (CourtRegistersDBEntities db = new CourtRegistersDBEntities())
            {
                tblRegisterBidder oBidder = db.tblRegisterBidders.FirstOrDefault(bid => bid.ID == nID);
                txtBidderAddress.Text = oBidder.BidderAddress;
                txtBidderName.Text = oBidder.BidderName;
                cbCases.Text = oBidder.CaseNumber.ToString();
                dateTimePicker1.Value = oBidder.PostingDate;
                cbCSI.SelectedValue = oBidder.IdCSI;
            }
        }

        private void BindCSI()
        {
            using (CSIRepository rep = new CSIRepository())
            {
                cbCSI.DisplayMember = "CSINumber";
                cbCSI.ValueMember = "IdCSI";
                cbCSI.DataSource = rep.GetAllActive();
            }
        }

        private void cbCSINumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (CourtRegistersDBEntities db = new CourtRegistersDBEntities())
            {
                int nIdCSI = cbCSI.SelectedValue.ToString().ToInt();
                lblCSIName.Text = db.tblCSIs.FirstOrDefault(p => p.IdCSI == nIdCSI).CSIName;
                txtBidderName.Focus();
                var date = DateTime.Now.AddMonths(-1);
                var data = db.tblRegisterProtocols.Where(it => it.IdCSI == nIdCSI && it.PostingDate > date)
                     .Select(it => new SelectItem { Id = it.CaseNumber, Name = it.CaseNumber })
                     .ToList();
                cbCases.DataSource = data;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateSave())
            {
                MessageBox.Show("Моля Въведете Задължителните полета");
                return;
            }
            if (SaveBidder())
            {
                this.Close();
            }
        }

        private bool SaveBidder()
        {
            bool success = false;
            using (BiddersRepository repository = new BiddersRepository())
            {
                try
                {
                    //var IdReg = db.Insert_RegBidder_SP(nID
                    //                       , cbCases.Text
                    //                       , (int)cbCSI.SelectedValue
                    //                       , txtBidderName.Text
                    //                       , txtBidderAddress.Text
                    //                       , dateTimePicker1.Value);
                    var bidder = new tblRegisterBidder()
                    {
                        ID = nID,
                        CaseNumber = cbCases.Text,
                        IdCSI = (int)cbCSI.SelectedValue,
                        BidderName = txtBidderName.Text,
                        BidderAddress = txtBidderAddress.Text,
                        PostingDate = dateTimePicker1.Value
                    };

                    success = repository.Save(ref bidder);

                    MessageBox.Show("Записът Успешен! Входящ № " + bidder.IncomeNumber, "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
            if (txtBidderName.Text.Trim() == string.Empty)
                return false;
            if (cbCases.Text.Trim() == string.Empty)
                return false;
            if (txtBidderAddress.Text.Trim() == string.Empty)
                return false;
            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBidderName_Leave(object sender, EventArgs e)
        {
            if (nID != 0)
                return;
            if (txtBidderName.Text != string.Empty)
            {
                using (CourtRegistersDBEntities db = new CourtRegistersDBEntities())
                {
                    tblRegisterBidder oBidder = (from eBidder in db.tblRegisterBidders
                                                 where eBidder.BidderName == txtBidderName.Text
                                                 select eBidder).FirstOrDefault();
                    if (oBidder != null)
                    {
                        txtBidderAddress.Text = oBidder.BidderAddress;
                    }
                }
            }
        }

        private void btnSaveAndNew_Click(object sender, EventArgs e)
        {
            if (!ValidateSave())
            {
                MessageBox.Show("Моля Въведете Задължителните полета");
                return;
            }
            if (SaveBidder())
            {
                frmBidder frmBidder = new frmBidder(0);
                frmBidder.ShowDialog();
                this.Close();
            }
        }
    }
}

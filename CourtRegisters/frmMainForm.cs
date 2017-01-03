using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.EntityClient;
using System.Data.SqlClient;

namespace CourtRegisters
{
    public partial class frmMainForm : BaseForm
    {
        public frmMainForm()
        {
            InitializeComponent();
        }

        private void иToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void разпределениеНаПомещениятаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSaleLocation frmSaleLocation = new frmSaleLocation(0);
            frmSaleLocation.ShowDialog();
            frmSaleLocation.Dispose();
        }

        private void постъпилитеНаддавателниПредложенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBidder frmBidder = new frmBidder(0);
            frmBidder.ShowDialog();
            frmBidder.Dispose();
        }

        private void протоколитеЗаДеняНаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProtocol frmProtocol = new frmProtocol(0);
            frmProtocol.ShowDialog();
            frmProtocol.Dispose();
        }

        private void всичкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAllBidders frmAllBidders = new frmAllBidders();
            frmAllBidders.ShowDialog();
            frmAllBidders.Dispose();
        }

        private void всичкиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAllSaleLocation frmAllSaleLocation = new frmAllSaleLocation();
            frmAllSaleLocation.ShowDialog();
            frmAllSaleLocation.Dispose();
        }

        private void всичкиПротоколиЗаДеняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAllProtocols frmAllProt = new frmAllProtocols();
            frmAllProt.ShowDialog();
            frmAllProt.Dispose();
        }

        private void frmMainForm_Load(object sender, EventArgs e)
        {
            if (ConfigurationManager.ConnectionStrings["CourtRegistersDBEntities"] == null)
            {
                MessageBox.Show("Липсва кофигурационния файл \"CourtRegisters.exe.config\"", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
            if (DateTime.Now > new DateTime(2017, 12, 31))
            {
                MessageBox.Show("Лицензът Ви е изтекъл!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }

            if (!SecurityManager.ValidateDb(ConfigurationManager.AppSettings["SaleLocation"].Trim()))
            {
                MessageBox.Show("Базата не отговаря на съда!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                msMenu.Enabled = false;
                this.ControlBox = true;
            }
        }

        private void наддавателиПоДатаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBiddersByDate frmBiddersByDate = new frmBiddersByDate();
            frmBiddersByDate.ShowDialog();
            frmBiddersByDate.Dispose();
        }

        private void frmMainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.Shift && e.KeyCode == Keys.A)
            {
                frmAdminPanel frmAdmin = new frmAdminPanel();
                frmAdmin.ShowDialog();
                frmAdmin.Dispose();
            }
        }

        private void всичкиЧСИToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmAllCSI frmCSI = new frmAllCSI())
            {
                frmCSI.ShowDialog();
            }
        }
    }
}

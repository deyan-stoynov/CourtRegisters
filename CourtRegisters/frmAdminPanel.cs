using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using CourtRegisters.Repository;

namespace CourtRegisters
{
    public partial class frmAdminPanel : Form
    {
        public frmAdminPanel()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text.Trim() == "1234")
            {
                panelGenFile.Visible = true;
                panelPassword.Visible = false;
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (txtCourt.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Въведи Код");
                return;
            }

            if (SecurityManager.GenFile(txtCourt.Text.Trim()))
                MessageBox.Show("Файлът е генериран!");

            else
                MessageBox.Show("Файлът не е генериран!");

            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CourtRegisters
{
    public class EditForm : BaseForm
    {

        protected override bool ProcessCmdKey(ref System.Windows.Forms.Message msg, System.Windows.Forms.Keys keyData)
        {
            if (keyData == System.Windows.Forms.Keys.Enter)
            {
                if (!(this.ActiveControl is Button))
                {
                    var nextCtrl = GetNextControl(this.ActiveControl, true);
                    SelectNextControl(this.ActiveControl, true, true, true, true);
                    if (nextCtrl is Button)
                        return true;
                }
            }


            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}

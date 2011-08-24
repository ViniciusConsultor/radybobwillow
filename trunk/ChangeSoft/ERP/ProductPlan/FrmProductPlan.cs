using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Com.ChangeSoft.ERP.CodeRef;

namespace Com.ChangeSoft.ERP.ProductPlan
{
    public partial class FrmProductPlan : Com.ChangeSoft.Common.BaseForm
    {
        public FrmProductPlan()
        {
            InitializeComponent();
        }

        public override void Language_Change()
        {
            throw new NotImplementedException();
        }

        private void btnCode_Click(object sender, EventArgs e)
        {
            TestCode frm = new TestCode();
            frm.ShowDialog(this);
        }
    }
}

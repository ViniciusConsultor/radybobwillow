using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Com.GainWinSoft.ERP.CodeRef;
using WeifenLuo.WinFormsUI.Docking;
using Com.GainWinSoft.Common;

namespace Com.GainWinSoft.ERP.ProductPlan
{
    public partial class FrmProductPlan : Com.GainWinSoft.Common.BaseContent
    {
        public FrmProductPlan(DockPanel _parent)
            : base(_parent)
        {
            InitializeComponent();
        }



        private void btnCode_Click(object sender, EventArgs e)
        {

            
       
           // TestCode frm = new TestCode(lst);

            CodeRefClsDetail cf = new CodeRefClsDetail("63");
            cf.AddValueControl(txtCode);

            cf.ShowDialog(this.baseform.dockPanel);

        }
    }
}

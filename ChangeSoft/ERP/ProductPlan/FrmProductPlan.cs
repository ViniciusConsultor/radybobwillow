using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Com.ChangeSoft.ERP.CodeRef;
using WeifenLuo.WinFormsUI.Docking;

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
             //Point p = this.PointToClient(btnCode.PointToScreen(Point.Empty));
             Point p1 = btnCode.PointToScreen(Point.Empty);
             Rectangle r = new Rectangle(new Point(p1.X,p1.Y+btnCode.Height), frm.Size);
            
             frm.Show(this.dockPanel,r);
            
            
            if (!String.IsNullOrEmpty(frm.strReturn))
            {
                this.txtCode.Text = frm.strReturn;
            }
        }
    }
}

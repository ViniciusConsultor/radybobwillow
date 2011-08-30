using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Com.ChangeSoft.ERP.CodeRef;
using WeifenLuo.WinFormsUI.Docking;
using Com.ChangeSoft.Common;

namespace Com.ChangeSoft.ERP.ProductPlan
{
    public partial class FrmProductPlan : Com.ChangeSoft.Common.BaseContent
    {
        public FrmProductPlan(BaseForm _baseform):base(_baseform)
        {
            InitializeComponent();
        }



        private void btnCode_Click(object sender, EventArgs e)
        {

            List<Control> lst = new List<Control>();
            lst.Add(this.txtCode);
            TestCode frm = new TestCode(lst);
            //Point p = this.PointToClient(btnCode.PointToScreen(Point.Empty));
            Point p1 = btnCode.PointToScreen(Point.Empty);
            Rectangle r = new Rectangle(new Point(p1.X, p1.Y + btnCode.Height), frm.Size);

            frm.Show(this.baseform.dockPanel, r);

        }
    }
}

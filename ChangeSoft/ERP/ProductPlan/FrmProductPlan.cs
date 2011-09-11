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

            List<Control> lst = new List<Control>();
            lst.Add(this.txtCode);
            TestCode frm = new TestCode(lst);
            //Point p = this.PointToClient(btnCode.PointToScreen(Point.Empty));
            Point p1 = btnCode.PointToScreen(Point.Empty);
            Rectangle r = new Rectangle(new Point(p1.X, p1.Y), frm.Size);

            frm.ShowDialog(this.baseform.dockPanel);

        }
    }
}

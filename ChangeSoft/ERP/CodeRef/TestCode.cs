using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using Com.ChangeSoft.ERP.CodeRef.Action;
using Com.ChangeSoft.Common;
using Com.ChangeSoft.ERP.Entity;

namespace Com.ChangeSoft.ERP.CodeRef
{
    public partial class TestCode : DockContent
    {
        public String strReturn;
        private List<Control> _lst;
        public TestCode(List<Control> lst)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            this._lst = lst;
            strReturn = "";

            LoadData();
        }

        private void LoadData()
        {
            IAction_TestCode af = ComponentLocator.Instance().Resolve<IAction_TestCode>();
            IList<MFunctioncatalog> flist = af.GetFunctionDataList();

            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Name");

            foreach (MFunctioncatalog mfvo in flist)
            {
                DataRow dr = dt.NewRow();
                dr[0] = mfvo.Id.Catalogid;
                dr[1] = mfvo.Catalogname;
                dt.Rows.Add(dr);
            }

            this.dgvCode.DataSource = dt;
        }

        private void dgvCode_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgvr = this.dgvCode.CurrentRow;
            MessageBox.Show(dgvr.Cells[0].Value.ToString());

            this.strReturn = dgvr.Cells[0].Value.ToString();
            this._lst[0].Text = dgvr.Cells[0].Value.ToString();
            this._lst[0].Focus();
            this.Close();
            this.Dispose();
        }
    }
}

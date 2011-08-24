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
    public partial class TestCode : Form
    {
        public String strReturn;
        public TestCode()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            strReturn = "";

            LoadData();
        }

        private void LoadData()
        {
            IAction_TestCode af = ComponentLocator.Instance().Resolve<IAction_TestCode>();
            IList<MFunctioncatalog> flist = af.GetFunctionDataList();

            this.dgvCode.DataSource = flist;
        }
    }
}

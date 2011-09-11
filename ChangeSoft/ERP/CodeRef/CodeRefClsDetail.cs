using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Com.GainWinSoft.ERP.CodeRef.Action;
using Com.GainWinSoft.Common;
using System.Resources;

namespace Com.GainWinSoft.ERP.CodeRef
{
    public partial class CodeRefClsDetail : Com.GainWinSoft.Common.BaseCodeForm
    {


        private string clsCd;
        public CodeRefClsDetail(string _clsCd)
        {
            this.clsCd = _clsCd;
            InitializeComponent();
        }

        private void CodeRefClsDetail_Load(object sender, EventArgs e)
        {
            IAction_CodeRefClsDetail ac = ComponentLocator.Instance().Resolve<IAction_CodeRefClsDetail>();
            DataSet ds = ac.GetClsDetailDataSet(clsCd);
            this.dataGridView1.DataSource = ds;
            this.dataGridView1.DataMember = "CLSDETAIL";
            SetColumnsAlias();
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgvr = this.dataGridView1.CurrentRow;

            this.SetValue(dgvr.Cells["IClsDetailCd"].Value.ToString());
            this.SetName(dgvr.Cells["IClsDetailDesc"].Value.ToString());

            this.SetFocus();
            this.Close();
            this.Dispose();
        }

        private void SetColumnsAlias()
        {
            ResourceManager rm = new ResourceManager(typeof(CodeRefClsDetail));
            foreach (DataGridViewColumn col in this.dataGridView1.Columns)
            {
                col.HeaderText = rm.GetString(col.Name);
            }

            this.dataGridView1.Columns["iLanguageCd"].Visible = false;
            this.dataGridView1.Columns["iInqItem"].Visible = false;
        }

    }
}

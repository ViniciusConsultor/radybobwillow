using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Resources;
using Com.GainWinSoft.ERP.CodeRef.Action;
using Com.GainWinSoft.Common;

namespace Com.GainWinSoft.ERP.CodeRef
{
    public partial class CodeRefTradeForMaterial : Com.GainWinSoft.Common.BaseCodeForm
    {
        private string[] columnlist = { "ICompanyCd", "IDlCd", "IDlArgDesc", "IDlDesc", "IDlDescKana", "IDlType", "IDlTypeName" };
        private ResourceManager rm = new ResourceManager(typeof(CodeRefTradeForMaterial));

        private string companyCd;
        public CodeRefTradeForMaterial(string companyCd)
        {
            this.companyCd = companyCd;
            InitializeComponent();
        }

        #region 事件
        private void CodeRefTradeForMaterial_Load(object sender, EventArgs e)
        {
            Init_GridView();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DoSearch();

        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.txtDLCd.Text = "";
            this.txtDLDesc.Text = "";
            Init_GridView();
            this.txtDLCd.Focus();
        }



        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgvr = this.dataGridView1.CurrentRow;

            this.SetValue(dgvr.Cells["IDlCd"].Value.ToString());
            this.SetName(dgvr.Cells["IDlDesc"].Value.ToString());

            //this.SetFocus();
            this.Close();
            this.Dispose();
        }
        #endregion
        #region 内部方法
        private void DoSearch()
        {
            IAction_CodeRefTradeForMaterial ac = ComponentLocator.Instance().Resolve<IAction_CodeRefTradeForMaterial>();
            DataSet ds = ac.GetTradeForMaterialDataSet(companyCd, this.txtDLCd.Text, this.txtDLDesc.Text);

            if (ds.Tables["CCodeRefTradeForMaterial"].Rows.Count > 0)
            {
                this.dataGridView1.DataSource = ds;
                this.dataGridView1.DataMember = "CCodeRefTradeForMaterial";
                SetColumnsAlias();
            }
            else
            {
                Init_GridView();
            }
        }
        private void SetColumnsAlias()
        {

            for (int i = 0; i < this.dataGridView1.Columns.Count; i++)
            {
                this.dataGridView1.Columns[i].Visible = false;
            }

            for (int i = 0; i < columnlist.Length; i++)
            {
                this.dataGridView1.Columns[columnlist[i]].Visible = true;
                this.dataGridView1.Columns[columnlist[i]].DisplayIndex = i;
                this.dataGridView1.Columns[columnlist[i]].HeaderText = rm.GetString(columnlist[i]);
            }

        }


        private void Init_GridView()
        {
            DataTable dt = new DataTable();

            foreach (string key in columnlist)
            {
                DataColumn col = new DataColumn();
                col.ColumnName = key;
                dt.Columns.Add(col);
            }

            this.dataGridView1.DataSource = dt;

            foreach (string key in columnlist)
            {
                this.dataGridView1.Columns[key].HeaderText = rm.GetString(key);

            }


        }
        #endregion

    }
}

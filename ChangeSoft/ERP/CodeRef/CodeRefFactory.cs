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
    public partial class CodeRefFactory : Com.GainWinSoft.Common.BaseCodeForm
    {
        private string[] columnlist = { "IFacCd", "ICountryCd", "IFacArgDesc", "IFacDesc", "IFacDescKana", "IAddress1", "IAddress2", "IAddress3" };
        private string companyCd;
        private ResourceManager rm = new ResourceManager(typeof(CodeRefFactory));

        public CodeRefFactory(string companyCd)
        {
            this.companyCd = companyCd;
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.doSearch();
        }

        private void doSearch()
        {
            IAction_CodeRefFactory ac = ComponentLocator.Instance().Resolve<IAction_CodeRefFactory>();
            DataSet ds = ac.GetFactoryDataSet(companyCd, this.txtFacCd.Text, this.txtFacDesc.Text);
            if (ds.Tables["CCodeRefFactory"].Rows.Count > 0)
            {
                this.dataGridView1.DataSource = ds;
                this.dataGridView1.DataMember = "CCodeRefFactory";
                SetColumnsAlias();
            }
            else
            {
                Init_GridView();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgvr = this.dataGridView1.CurrentRow;

            this.SetValue(dgvr.Cells["IFacCd"].Value.ToString());
            this.SetName(dgvr.Cells["IFacArgDesc"].Value.ToString());

            //this.SetFocus();
            this.Close();
            this.Dispose();
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
                this.dataGridView1.Columns[columnlist[i]].HeaderText = rm.GetString(this.dataGridView1.Columns[columnlist[i]].Name);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.txtFacCd.Text = "";
            this.txtFacDesc.Text = "";
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

        private void CodeRefFactory_Load(object sender, EventArgs e)
        {

            //Init_GridView();
            this.doSearch();

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Resources;
using Com.GainWinSoft.Common;
using Com.GainWinSoft.ERP.CodeRef.Action;

namespace Com.GainWinSoft.ERP.CodeRef
{
    public partial class CodeRefPerson : Com.GainWinSoft.Common.BaseCodeForm
    {
        private string[] columnlist = {"ISectionCd", "ISectionNm", "IPersonCd", "IPersonDesc", "IPersonDescKana" };
        private ResourceManager rm = new ResourceManager(typeof(CodeRefPerson));

        private string companyCd="";


        public CodeRefPerson(string companyCd)
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
            IAction_CodeRefPerson ac = ComponentLocator.Instance().Resolve<IAction_CodeRefPerson>();
            string sectionCd = this.tddlSection.Selectedvalue.Trim();
            string personCd = this.atxtPersonCd.Text.Trim() ;
            string personNm = this.txtPersonNm.Text.Trim();

            DataSet ds = ac.GetPersonDataSet(companyCd,sectionCd,personCd,personNm);
            if (ds.Tables["CTPersonMsNoAR"].Rows.Count > 0)
            {
                this.dataGridView1.DataSource = ds;
                this.dataGridView1.DataMember = "CTPersonMsNoAR";
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

            this.SetValue(dgvr.Cells["IPersonCd"].Value.ToString());
            this.SetName(dgvr.Cells["IPersonDesc"].Value.ToString());

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
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.tddlSection.SelectedIndex = 0;
            this.atxtPersonCd.Text = "";
            this.txtPersonNm.Text = "";
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

            this.dataGridView1.DataSource=dt;

            foreach (string key in columnlist)
            {
                this.dataGridView1.Columns[key].HeaderText = rm.GetString(key);
                
            }


        }

        private void CodeRefPerson_Load(object sender, EventArgs e)
        {
            Init_GridView();
        }
    }
}

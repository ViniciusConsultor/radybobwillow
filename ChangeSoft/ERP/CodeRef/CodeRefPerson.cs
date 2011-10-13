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
        /// <summary>
        /// GridView显示列
        /// </summary>
        private string[] columnlist = {"ISectionCd", "ISectionNm", "IPersonCd", "IPersonDesc" };
        private ResourceManager rm = new ResourceManager(typeof(CodeRefPerson));

        private string companyCd="";

        /// <summary>
        /// 构造
        /// </summary>
        /// <param name="companyCd"></param>
        public CodeRefPerson(string companyCd)
        {
            this.companyCd = companyCd;
            InitializeComponent();

        }
        #region 事件处理
        /// <summary>
        /// 查询画面load初始化gridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CodeRefPerson_Load(object sender, EventArgs e)
        {
            Init_GridView();
        }

        /// <summary>
        /// 查询按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.doSearch();
        }

        /// <summary>
        /// GridView双击
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgvr = this.dataGridView1.CurrentRow;

            this.SetValue(dgvr.Cells["IPersonCd"].Value.ToString());
            this.SetName(dgvr.Cells["IPersonDesc"].Value.ToString());

            //this.SetFocus();
            this.Close();
            this.Dispose();
        }

        /// <summary>
        /// 清空按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.tddlSection.SelectedIndex = 0;
            this.atxtPersonCd.Text = "";
            this.txtPersonNm.Text = "";
            Init_GridView();
        }

        #endregion

        #region 内部方法

        /// <summary>
        /// 执行查询,根据画面的查询条件
        /// </summary>
        private void doSearch()
        {
            IAction_CodeRefPerson ac = ComponentLocator.Instance().Resolve<IAction_CodeRefPerson>();
            string sectionCd = this.tddlSection.Selectedvalue.Trim();
            string personCd = this.atxtPersonCd.Text.Trim();
            string personNm = this.txtPersonNm.Text.Trim();

            DataSet ds = ac.GetPersonDataSet(companyCd, sectionCd, personCd, personNm);
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

        /// <summary>
        /// 设置GridVeiw的列名
        /// </summary>
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

        /// <summary>
        /// GridView初始化
        /// </summary>
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
        #endregion
    }
}

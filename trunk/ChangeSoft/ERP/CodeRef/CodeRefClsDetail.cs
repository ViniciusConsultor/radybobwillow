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

        private string[] columnlist = { "IClsCd", "IClsDetailCd", "IClsDetailDesc", "IClsNameDesc", "IInqItem", "ILanguageCd" };
        private string clsCd;

        private ResourceManager rm = new ResourceManager(typeof(CodeRefClsDetail));
        /// <summary>
        /// 构造体
        /// </summary>
        /// <param name="_clsCd"></param>
        public CodeRefClsDetail(string _clsCd)
        {
            this.clsCd = _clsCd;
            InitializeComponent();
        }

        #region 事件
        /// <summary>
        /// 画面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CodeRefClsDetail_Load(object sender, EventArgs e)
        {
            IAction_CodeRefClsDetail ac = ComponentLocator.Instance().Resolve<IAction_CodeRefClsDetail>();
            DataSet ds = ac.GetClsDetailDataSet(clsCd);
            if (ds.Tables["CClsDetailNoAR"].Rows.Count > 0)
            {
                this.dataGridView1.DataSource = ds;
                this.dataGridView1.DataMember = "CClsDetailNoAR";
                SetColumnsAlias();
            }
            else
            {
                Init_GridView();
            }



        }

        /// <summary>
        /// GridView双击
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgvr = this.dataGridView1.CurrentRow;

            this.SetValue(dgvr.Cells["IClsDetailCd"].Value.ToString());
            this.SetName(dgvr.Cells["IClsDetailDesc"].Value.ToString());

            //this.SetFocus();
            this.Close();
            this.Dispose();
        }

        #endregion

        #region 内部方法


        /// <summary>
        /// 设置列名
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

            this.dataGridView1.DataSource = dt;

            foreach (string key in columnlist)
            {
                this.dataGridView1.Columns[key].HeaderText = rm.GetString(key);

            }
        }

        #endregion
    }
}

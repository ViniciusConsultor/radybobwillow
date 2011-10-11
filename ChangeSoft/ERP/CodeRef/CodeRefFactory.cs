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

        public CodeRefFactory(string companyCd)
        {
            this.companyCd = companyCd;
            InitializeComponent();
        }

        private void CodeRefFactory_Load(object sender, EventArgs e)
        {
            this.doSearch();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.doSearch();
        }

        private void doSearch()
        {
            IAction_CodeRefFactory ac = ComponentLocator.Instance().Resolve<IAction_CodeRefFactory>();
            DataSet ds = ac.GetFactoryDataSet(companyCd, this.txtFacCd.Text, this.txtFacDesc.Text);
            this.dataGridView1.DataSource = ds;
            this.dataGridView1.DataMember = "CCodeRefFactory";
            SetColumnsAlias();
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
            ResourceManager rm = new ResourceManager(typeof(CodeRefFactory));
            foreach (DataGridViewColumn col in this.dataGridView1.Columns)
            {
                col.HeaderText = rm.GetString(col.Name);
            }

            for (int i = 0; i < this.dataGridView1.Columns.Count; i++)
            {
                this.dataGridView1.Columns[i].Visible = false;
            }

            if (this.dataGridView1.RowCount > 0)
            {
                for (int i = 0; i < columnlist.Length; i++)
                {
                    this.dataGridView1.Columns[columnlist[i]].Visible = true;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.txtFacCd.Text = "";
            this.txtFacDesc.Text = "";
        }
    }
}

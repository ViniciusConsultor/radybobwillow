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

        private string companyCd;
        public CodeRefTradeForMaterial(string companyCd)
        {
            this.companyCd = companyCd;
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            IAction_CodeRefTradeForMaterial ac = ComponentLocator.Instance().Resolve<IAction_CodeRefTradeForMaterial>();
            DataSet ds = ac.GetTradeForMaterialDataSet(companyCd,this.txtDLCd.Text,this.txtDLDesc.Text);
            this.dataGridView1.DataSource = ds;
            this.dataGridView1.DataMember = "CCodeRefTradeForMaterial";
            SetColumnsAlias();
        }


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgvr = this.dataGridView1.CurrentRow;

            this.SetValue(dgvr.Cells["IDlCd"].Value.ToString());
            this.SetName(dgvr.Cells["IDlDesc"].Value.ToString());

            this.SetFocus();
            this.Close();
            this.Dispose();
        }

        private void SetColumnsAlias()
        {
            ResourceManager rm = new ResourceManager(typeof(CodeRefTradeForMaterial));
            foreach (DataGridViewColumn col in this.dataGridView1.Columns)
            {
                col.HeaderText = rm.GetString(col.Name);
            }

            this.dataGridView1.Columns["ICompanyCd"].Visible = false;
            this.dataGridView1.Columns["IDlType"].Visible = false;


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.txtDLCd.Text = "";
            this.txtDLDesc.Text = "";
        }

    }
}

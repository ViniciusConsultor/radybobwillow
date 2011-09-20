using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using Com.GainWinSoft.Common.Vo;

namespace Com.GainWinSoft.ERP
{
    public partial class FirstForm : Com.GainWinSoft.Common.BaseContent
    {

        private string functioncatalog;
        private IList<FunctionAllVo> functionlist;

        public IList<FunctionAllVo> Functionlist
        {
            get { return functionlist; }
            set { functionlist = value; }
        }
        public FirstForm(DockPanel _parentdockpanel)
            : base(_parentdockpanel)
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            string path = "FMaterial";
            string title = "物料管理";
            DockPanel parentpanel = this.baseform.Parentdockpanel;

            MenuTransfer m = new MenuTransfer(path, title, parentpanel);
            m.Parse();


        }

        private void FirstForm_Load(object sender, EventArgs e)
        {

            this.linkMaterial.Text = "物料管理";
            this.linkQuotationEntry.Text = "报价单输入";
            

        }


        public string Functioncatalog
        {
            get { return functioncatalog; }
            set { functioncatalog = value; }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            string path = "FQuotationEntry";
            string title = "报价单输入";
            DockPanel parentpanel = this.baseform.Parentdockpanel;

            MenuTransfer m = new MenuTransfer(path, title, parentpanel);
            m.Parse();



        }

        public void SetPanelVisible()
        {
            if ("1".Equals(this.functioncatalog))
            {
                this.tlpFuncCatalog1.Visible = true;
                this.tlpFuncCatalog1.Dock = DockStyle.Fill;
                this.tlpFuncCatalog2.Visible = false;
            }
            if ("2".Equals(this.functioncatalog))
            {
                this.tlpFuncCatalog1.Visible = false;
                this.tlpFuncCatalog2.Visible = true;
                this.tlpFuncCatalog2.Dock = DockStyle.Fill;
            }

        }
    }
}

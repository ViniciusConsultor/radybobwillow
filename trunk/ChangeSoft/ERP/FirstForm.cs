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

        private string functioncatalogindex;
        private IList<FunctionAllVo> functionlist;


        public FirstForm(DockPanel _parentdockpanel)
            : base(_parentdockpanel)
        {
            InitializeComponent();
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel l = (LinkLabel)sender;

            string path = l.Tag.ToString();
            string title = l.Text;
            DockPanel parentpanel = this.baseform.Parentdockpanel;

            MenuTransfer m = new MenuTransfer(path, title, parentpanel);
            m.Parse();


        }

        private void FirstForm_Load(object sender, EventArgs e)
        {

//            this.linkMaterial.Text = "物料管理";
//            this.linkQuotationEntry.Text = "报价单输入";

            //遍历图片和LinkLabel
            SetControl(XPWorkflow);
           


        }

        private void SetControl(Control container)
        {



            foreach (Control c in container.Controls)
            {

                if (c.GetType() == typeof(TableLayoutPanel))
                {
                    SetControl(c);
                }
                else
                {
                    if (c.GetType() == typeof(PictureBox))
                    {
                        if (c.Tag!=null && !"".Equals(c.Tag.ToString()))
                        {
                            Image icon = (Image)Properties.Resources.ResourceManager.GetObject(c.Tag.ToString());
                            if (icon == null)
                            {
                                icon = (Image)Properties.Resources.ResourceManager.GetObject("DefaultProgram");
                            }
                            ((PictureBox)c).Image = icon;

                        }
                    }
                    if (c.GetType() == typeof(LinkLabel))
                    {
                        if (c.Tag!=null && !"".Equals(c.Tag.ToString()))
                        {
                            LinkLabel l = (LinkLabel)c;
                            l.Text = GetFunctionName(l.Tag.ToString());
                            l.LinkClicked+=new LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
                        }
                    }
                }
            }
        }

        private string GetFunctionName(string p)
        {
            int index = Convert.ToInt32(Functioncatalogindex);
            string functionname="";
            foreach (FunctionAllVo fvo in this.functionlist)
            {
                foreach (FunctionVo function in fvo.Functionlist)
                {
                    if (p.Equals(function.Functionpath))
                    {
                        functionname = function.Functionname;
                        break;
                    }
                }
            }


            return functionname;
        }


        public string Functioncatalogindex
        {
            get { return functioncatalogindex; }
            set { functioncatalogindex = value; }
        }

        public IList<FunctionAllVo> Functionlist
        {
            get { return functionlist; }
            set { functionlist = value; }
        }



        public void SetPanelVisible()
        {
            if ("0".Equals(this.functioncatalogindex))
            {
                this.tlpFuncCatalog1.Visible = true;
                this.tlpFuncCatalog1.Dock = DockStyle.Fill;
                this.tlpFuncCatalog2.Visible = false;
            }
            if ("1".Equals(this.functioncatalogindex))
            {
                this.tlpFuncCatalog1.Visible = false;
                this.tlpFuncCatalog2.Visible = true;
                this.tlpFuncCatalog2.Dock = DockStyle.Fill;
            }

        }
    }
}

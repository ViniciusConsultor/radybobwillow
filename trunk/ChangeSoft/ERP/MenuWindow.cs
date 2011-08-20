using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Com.ChangeSoft.ERP.Company;
using WeifenLuo.WinFormsUI.Docking;
using Com.ChangeSoft.ERP.ProductPlan;
using Com.ChangeSoft.Common;


namespace Com.ChangeSoft.ERP
{
    public partial class MenuWindow : BaseForm

    {
        private DockPanel dockpanel;
        public MenuWindow(DockPanel dk)
        {
            this.dockpanel = dk;
            InitializeComponent();
        }
        public DockContent FindDocument(string text)
        {
            if (dockpanel.DocumentStyle == DocumentStyle.SystemMdi)
            {
                foreach (Form form in MdiChildren)
                {
                    if (form.Text == text)
                    {
                        return form as DockContent;
                    }
                }

                return null;
            }
            else
            {
                foreach (DockContent content in dockpanel.Documents)
                {
                    if (content.DockHandler.TabText == text)
                    {
                        return content;
                    }
                }

                return null;
            }
        }

        public DockContent ShowContent(string caption, Type formType)
        {
            DockContent frm = FindDocument(caption);
            //if (frm == null)
            //{
            //    frm = ChildWinManagement.LoadMdiForm(Portal.gc.MainDialog, formType) as DockContent;
            //}

            frm.Show(this.dockpanel);
            frm.BringToFront();
            return frm;
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (this.treeView1.SelectedNode == null)
            {
                return;
            }
            if (this.treeView1.SelectedNode.Index == 0)
            {
                DockContent frm = FindDocument("企业数据维护");
                if (frm == null)
                {
                    FrmCompany frmcom = new FrmCompany();
                    frmcom.Show(this.dockpanel);
                }
                else
                {
                    frm.Show(this.dockpanel);
                    frm.BringToFront();
                }
            }
            if (this.treeView1.SelectedNode.Index == 1)
            {
                DockContent frm = FindDocument("生产计划");
                if (frm == null)
                {
                    FrmProductPlan frmproductplan = new FrmProductPlan();
                    frmproductplan.Show(this.dockpanel);
                }
                else
                {
                    frm.Show(this.dockpanel);
                    frm.BringToFront();
                }

            }
        }



        public override void Language_Change()
        {
  
            
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}

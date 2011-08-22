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
using Com.ChangeSoft.ERP.FormVo;
using Guifreaks.NavigationBar;


namespace Com.ChangeSoft.ERP
{
    public partial class MenuWindow : BaseForm

    {
        private DockPanel dockpanel;
        IList<FunctionVo> functionlist;
        public MenuWindow(DockPanel dk,IList<FunctionVo> _flist)
        {
            this.dockpanel = dk;
            this.functionlist = _flist;
            InitializeComponent();
            InitNaviBar();
            naviBar.ActiveBand = naviBar.Bands[0];
        }

        public void InitNaviBar()
        {
            IList<TreeView> treeviewlist = new List<TreeView>();
            foreach (FunctionVo fvo in functionlist)
            {
                int i = 0;
                NaviBand band = new NaviBand();
                //TreeView treeView1 = new System.Windows.Forms.TreeView();
                //treeviewlist.Add(treeView1);

                band.Text = fvo.Catalogname;
                
                band.SmallImage = (Image)Properties.Resources.ResourceManager.GetObject(fvo.Catalogimage+"Small");
                band.LargeImage = (Image)Properties.Resources.ResourceManager.GetObject(fvo.Catalogimage+"Big");
                band.Tag = fvo.Catalogid;
                InitTreeView(band);

                naviBar.Bands.Add(band);
                i++;
            }
        }

        private void InitTreeView(NaviBand band)
        {

            TreeView treeView1 = new TreeView();

            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("节点0");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("节点1");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("节点2");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("节点3");

            treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            treeView1.FullRowSelect = true;
            treeView1.Indent = 50;
            treeView1.ItemHeight = 50;
            treeView1.Location = new System.Drawing.Point(0, 0);
            treeView1.Name = "treeView1";
            if ("1".Equals(band.Tag.ToString()))
            {
                treeNode1.Text = "FrmCompany0";
                treeNode1.Name = "FrmCompany0";
                treeNode1.Tag = "FrmCompany";
            }
            else
            {
                treeNode1.Text = "FrmProductPlan0";
                treeNode1.Name = "FrmProductPlan0";
                treeNode1.Tag = "FrmProductPlan";
            }

            treeNode2.Name = "节点1";
            treeNode2.Text = "节点1";
            treeNode3.Name = "节点2";
            treeNode3.Text = "节点2";
            treeNode4.Name = "节点3";
            treeNode4.Text = "节点3";
            treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            treeView1.ShowRootLines = false;
            treeView1.Size = new System.Drawing.Size(196, 271);
            treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);

            band.ClientArea.Controls.Add(treeView1);


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
            
            if (!e.Node.IsSelected)
            {
                return;
            }
            if ("FrmCompany".Equals(e.Node.Tag))
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
            if ("FrmProductPlan".Equals(e.Node.Tag))
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

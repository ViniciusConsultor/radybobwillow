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
    public partial class MenuWindow : DockContent

    {
        private DockPanel dockpanel;
        IList<FunctionAllVo> functionalllist;
        public MenuWindow(DockPanel dk,IList<FunctionAllVo> _flist)
        {
            this.dockpanel = dk;
            this.functionalllist = _flist;
            InitializeComponent();
            InitNaviBar();
            naviBar.ActiveBand = naviBar.Bands[0];
        }

        public void InitNaviBar()
        {
            IList<TreeView> treeviewlist = new List<TreeView>();
            foreach (FunctionAllVo fvo in functionalllist)
            {
                int i = 0;
                NaviBand band = new NaviBand();
                //TreeView treeView1 = new System.Windows.Forms.TreeView();
                //treeviewlist.Add(treeView1);

                band.Text = fvo.Catalogname;
                
                band.SmallImage = (Image)Properties.Resources.ResourceManager.GetObject(fvo.Catalogimage+"Small");
                band.LargeImage = (Image)Properties.Resources.ResourceManager.GetObject(fvo.Catalogimage+"Big");
                band.Tag = fvo.Catalogid;
                InitTreeView(band,fvo.Functionlist);

                naviBar.Bands.Add(band);
                i++;
            }
        }

        private void InitTreeView(NaviBand band,IList<FunctionVo> functionlist)
        {

            TreeView treeView1 = new TreeView();
            treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            treeView1.FullRowSelect = true;
            treeView1.Indent = 50;
            treeView1.ItemHeight = 50;
            treeView1.Location = new System.Drawing.Point(0, 0);
            treeView1.Name = band.Text;
            treeView1.ShowRootLines = true;
            treeView1.ShowLines = false;
            treeView1.Size = new System.Drawing.Size(196, 271);
            ImageList imagelist = new ImageList();
            imagelist.ImageSize = new Size(48,48);

            treeView1.ImageList = imagelist;
            treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);


            foreach (FunctionVo vo in functionlist)
            {
                TreeNode treeNode1 = new TreeNode(vo.Functionname);
                treeNode1.Tag = vo.Functionpath;
                treeNode1.Name = vo.Functionname;
                treeNode1.Text = vo.Functionname;
                treeView1.ImageList.Images.Add(vo.Functionimage,(Image)Properties.Resources.ResourceManager.GetObject(vo.Functionimage));
                treeNode1.ImageKey = vo.Functionimage;
                treeNode1.SelectedImageKey = vo.Functionimage;
                treeView1.Nodes.Add(treeNode1);


            }

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


            //BaseForm td = (BaseForm)ComponentLocator.Instance().Resolve(e.Node.Tag.ToString(), typeof(BaseForm));

            //td.Show(this.dockpanel);
            //td.BringToFront();

            if ("FCompany".Equals(e.Node.Tag.ToString()))
            {
                DockContent frm = FindDocument(e.Node.Text);
                if (frm == null)
                {
                    BaseForm baseform = new BaseForm();
                    baseform.TopLevel = false;
                    baseform.Text = e.Node.Text;
                    baseform.Show(this.dockpanel);
                    FrmCompany frmcompany = new FrmCompany(baseform);
                    frmcompany.Show(baseform.dockPanel, DockState.Document);
                    frmcompany.BringToFront();

                }
                else
                {
                    frm.Show(this.dockpanel);
                    frm.BringToFront();
                }
            }
            if ("FQuotationEntry".Equals(e.Node.Tag.ToString()))
            {
                DockContent frm = FindDocument(e.Node.Text);
                if (frm == null)
                {
                    BaseForm baseform = new BaseForm();
                    baseform.TopLevel = false;
                    baseform.Text = e.Node.Text; 
                    baseform.Show(this.dockpanel);
                    FrmProductPlan frmproductplan = new FrmProductPlan(baseform);

                    frmproductplan.Show(baseform.dockPanel, DockState.Document);
                }
                else
                {
                    frm.Show(this.dockpanel);
                    frm.BringToFront();
                }

            }
        }



        public void Language_Change()
        {
  
            
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}

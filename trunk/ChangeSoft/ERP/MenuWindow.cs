using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Com.GainWinSoft.ERP.Company;
using WeifenLuo.WinFormsUI.Docking;
using Com.GainWinSoft.ERP.ProductPlan;
using Com.GainWinSoft.Common;
using Guifreaks.NavigationBar;
using Com.GainWinSoft.ERP.Material;
using Com.GainWinSoft.ERP.Factory;
using System.Resources;
using Com.GainWinSoft.Common.Vo;
using log4net;


namespace Com.GainWinSoft.ERP
{
    public partial class MenuWindow : DockContent

    {
        private static readonly ILog log = LogManager.GetLogger(typeof(MenuWindow));
        private static ResourceManager rm = new System.Resources.ResourceManager(typeof(MenuWindow));

        private DockPanel dockpanel;
        IList<FunctionAllVo> functionalllist;
        public MenuWindow(DockPanel dk,IList<FunctionAllVo> _flist)
        {
            this.dockpanel = dk;
            this.functionalllist = _flist;
            InitializeComponent();
        }

        public void InitNaviBar()
        {
            IList<TreeView> treeviewlist = new List<TreeView>();
            int i = 0;
            foreach (FunctionAllVo fvo in functionalllist)
            {
                NaviBand band = new NaviBand();
                //TreeView treeView1 = new System.Windows.Forms.TreeView();
                //treeviewlist.Add(treeView1);

                band.Text = fvo.Catalogname;
                
                band.SmallImage = (Image)Properties.Resources.ResourceManager.GetObject(fvo.Catalogimage+"16");
                band.LargeImage = (Image)Properties.Resources.ResourceManager.GetObject(fvo.Catalogimage+"24");
               
                band.Tag = i;
                //band.Click += new EventHandler(band_Click);
                InitTreeView(band,fvo.Functionlist);

                naviBar.Bands.Add(band);
                i++;
            }
            naviBar.ActiveBandChanging += new NaviBandEventHandler(naviBar_ActiveBandChanged);

        }

        void naviBar_ActiveBandChanged(object sender, NaviBandEventArgs e)
        {

            log.Info(e.NewActiveBand.Tag.ToString());
            
            string title = rm.GetString("FirstPage");
            DockContent frm = this.FindDocument(title);
            if (frm == null)
            {
                FirstForm firstform = new FirstForm(this.dockpanel);
                firstform.DockTitle = title;
                firstform.Functioncatalogindex = e.NewActiveBand.Tag.ToString();
                firstform.Functionlist = this.functionalllist;
                firstform.ShowContentAtFirst(false);
                firstform.SetPanelVisible();
            }
            else
            {
                frm.Show(this.dockpanel);
                frm.BringToFront();
                FirstForm firstform = ((FirstForm)((BaseForm)(frm.Pane.Contents[0])).dockPanel.Panes[1].Contents[0]);
                firstform.Functioncatalogindex = e.NewActiveBand.Tag.ToString();
                firstform.Functionlist = this.functionalllist;
               firstform.SetPanelVisible();
            }

        }

        private void InitTreeView(NaviBand band,IList<FunctionVo> functionlist)
        {

            TreeView treeView1 = new TreeView();
            treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            treeView1.FullRowSelect = true;
            treeView1.Indent = 10;
            treeView1.ItemHeight = 50;
            treeView1.Location = new System.Drawing.Point(0, 0);
            treeView1.Name = band.Text;
            treeView1.ShowRootLines = false;
            treeView1.ShowLines = false;
            treeView1.Size = new System.Drawing.Size(196, 200);
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
                Image icon = (Image)Properties.Resources.ResourceManager.GetObject(vo.Functionimage);
                if (icon == null)
                {
                    icon = (Image)Properties.Resources.ResourceManager.GetObject("DefaultProgram");
                }
                treeView1.ImageList.Images.Add(vo.Functionimage,icon);
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
            string path = e.Node.Tag.ToString();
            string title = e.Node.Text;
            DockPanel parentpanel = this.dockpanel;

            MenuTransfer m = new MenuTransfer(path, title, parentpanel);
            m.Parse();
        }





        public void Language_Change()
        {
  
            
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void MenuWindow_Load(object sender, EventArgs e)
        {
            InitNaviBar();
            naviBar.VisibleLargeButtons = 3;
            naviBar.SuspendLayout();
            naviBar.ActiveBand = naviBar.Bands[0];

        }
    }
}

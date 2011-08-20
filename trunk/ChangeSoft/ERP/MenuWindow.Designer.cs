namespace Com.ChangeSoft.ERP
{
    partial class MenuWindow
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuWindow));
            this.naviBand3 = new Guifreaks.NavigationBar.NaviBand(this.components);
            this.naviBand2 = new Guifreaks.NavigationBar.NaviBand(this.components);
            this.naviBand1 = new Guifreaks.NavigationBar.NaviBand(this.components);
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.naviBar1 = new Guifreaks.NavigationBar.NaviBar(this.components);
            this.naviBand3.SuspendLayout();
            this.naviBand2.SuspendLayout();
            this.naviBand1.ClientArea.SuspendLayout();
            this.naviBand1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.naviBar1)).BeginInit();
            this.naviBar1.SuspendLayout();
            this.SuspendLayout();
            // 
            // naviBand3
            // 
            // 
            // naviBand3.ClientArea
            // 
            resources.ApplyResources(this.naviBand3.ClientArea, "naviBand3.ClientArea");
            this.naviBand3.ClientArea.Name = "ClientArea";
            resources.ApplyResources(this.naviBand3, "naviBand3");
            this.naviBand3.Name = "naviBand3";
            // 
            // naviBand2
            // 
            // 
            // naviBand2.ClientArea
            // 
            resources.ApplyResources(this.naviBand2.ClientArea, "naviBand2.ClientArea");
            this.naviBand2.ClientArea.Name = "ClientArea";
            resources.ApplyResources(this.naviBand2, "naviBand2");
            this.naviBand2.Name = "naviBand2";
            // 
            // naviBand1
            // 
            // 
            // naviBand1.ClientArea
            // 
            this.naviBand1.ClientArea.Controls.Add(this.treeView1);
            resources.ApplyResources(this.naviBand1.ClientArea, "naviBand1.ClientArea");
            this.naviBand1.ClientArea.Name = "ClientArea";
            resources.ApplyResources(this.naviBand1, "naviBand1");
            this.naviBand1.Name = "naviBand1";
            // 
            // treeView1
            // 
            resources.ApplyResources(this.treeView1, "treeView1");
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.ItemHeight = 40;
            this.treeView1.Name = "treeView1";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            ((System.Windows.Forms.TreeNode)(resources.GetObject("treeView1.Nodes"))),
            ((System.Windows.Forms.TreeNode)(resources.GetObject("treeView1.Nodes1"))),
            ((System.Windows.Forms.TreeNode)(resources.GetObject("treeView1.Nodes2"))),
            ((System.Windows.Forms.TreeNode)(resources.GetObject("treeView1.Nodes3")))});
            this.treeView1.ShowLines = false;
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "bookmark.png");
            this.imageList1.Images.SetKeyName(1, "colorize.png");
            this.imageList1.Images.SetKeyName(2, "contents.png");
            this.imageList1.Images.SetKeyName(3, "history.png");
            this.imageList1.Images.SetKeyName(4, "klipper.png");
            this.imageList1.Images.SetKeyName(5, "wizard.png");
            // 
            // naviBar1
            // 
            this.naviBar1.ActiveBand = this.naviBand1;
            this.naviBar1.Controls.Add(this.naviBand1);
            this.naviBar1.Controls.Add(this.naviBand3);
            this.naviBar1.Controls.Add(this.naviBand2);
            resources.ApplyResources(this.naviBar1, "naviBar1");
            this.naviBar1.Name = "naviBar1";
            this.naviBar1.ShowCollapseButton = false;
            // 
            // MenuWindow
            // 
            resources.ApplyResources(this, "$this");
            this.CloseButton = false;
            this.CloseButtonVisible = false;
            this.Controls.Add(this.naviBar1);
            this.HideOnClose = true;
            this.KeyPreview = true;
            this.Name = "MenuWindow";
            this.ShowHint = WeifenLuo.WinFormsUI.Docking.DockState.DockLeft;
            this.naviBand3.ResumeLayout(false);
            this.naviBand2.ResumeLayout(false);
            this.naviBand1.ClientArea.ResumeLayout(false);
            this.naviBand1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.naviBar1)).EndInit();
            this.naviBar1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guifreaks.NavigationBar.NaviBar naviBar1;
        private Guifreaks.NavigationBar.NaviBand naviBand1;
        private Guifreaks.NavigationBar.NaviBand naviBand2;
        private Guifreaks.NavigationBar.NaviBand naviBand3;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TreeView treeView1;
    }
}

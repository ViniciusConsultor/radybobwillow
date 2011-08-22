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
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.naviBar = new Guifreaks.NavigationBar.NaviBar(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.naviBar)).BeginInit();
            this.SuspendLayout();
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
            // naviBar
            // 
            this.naviBar.ActiveBand = null;
            resources.ApplyResources(this.naviBar, "naviBar");
            this.naviBar.Name = "naviBar";
            this.naviBar.ShowCollapseButton = false;
            // 
            // MenuWindow
            // 
            resources.ApplyResources(this, "$this");
            this.CloseButton = false;
            this.CloseButtonVisible = false;
            this.Controls.Add(this.naviBar);
            this.HideOnClose = true;
            this.KeyPreview = true;
            this.Name = "MenuWindow";
            this.ShowHint = WeifenLuo.WinFormsUI.Docking.DockState.DockLeft;
            ((System.ComponentModel.ISupportInitialize)(this.naviBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guifreaks.NavigationBar.NaviBar naviBar;
        private System.Windows.Forms.ImageList imageList1;
    }
}

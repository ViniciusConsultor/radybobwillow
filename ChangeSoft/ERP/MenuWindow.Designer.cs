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
            this.naviBar = new Guifreaks.NavigationBar.NaviBar(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.naviBar)).BeginInit();
            this.SuspendLayout();
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
            this.DockAreas = ((WeifenLuo.WinFormsUI.Docking.DockAreas)((WeifenLuo.WinFormsUI.Docking.DockAreas.DockLeft | WeifenLuo.WinFormsUI.Docking.DockAreas.DockRight)));
            this.HideOnClose = true;
            this.KeyPreview = true;
            this.Name = "MenuWindow";
            this.ShowHint = WeifenLuo.WinFormsUI.Docking.DockState.DockLeft;
            ((System.ComponentModel.ISupportInitialize)(this.naviBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guifreaks.NavigationBar.NaviBar naviBar;
    }
}

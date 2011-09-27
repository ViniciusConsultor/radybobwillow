namespace Com.GainWinSoft.ERP.Material
{
    partial class FrmMaterialEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMaterialEdit));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.xplblMode = new xpLabel.xpLabel();
            this.commonToolStrip = new Com.GainWinSoft.Common.Control.CommonToolStrip.CommonToolStrip();
            this.tlpG1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnFactoryHelper = new System.Windows.Forms.Button();
            this.txtFactoryCd = new System.Windows.Forms.TextBox();
            this.lblFactoryNm = new System.Windows.Forms.Label();
            this.caplblFactory = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tlpG1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.xplblMode, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.commonToolStrip, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tlpG1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // xplblMode
            // 
            this.xplblMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.xplblMode.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.xplblMode.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(150)))), ((int)(((byte)(21)))));
            this.xplblMode.BackColorScheme = xpLabel.BackColorSchemeType.Office2003Orange;
            resources.ApplyResources(this.xplblMode, "xplblMode");
            this.xplblMode.Name = "xplblMode";
            this.xplblMode.ShowShadow = false;
            this.xplblMode.TextAlign = xpLabel.TextAlignStyle.TAlignMiddleMiddle;
            // 
            // commonToolStrip
            // 
            this.commonToolStrip.AddEnabled = true;
            this.commonToolStrip.AddVisible = false;
            resources.ApplyResources(this.commonToolStrip, "commonToolStrip");
            this.commonToolStrip.CopyEnabled = true;
            this.commonToolStrip.CopyVisible = false;
            this.commonToolStrip.CsvEnabled = true;
            this.commonToolStrip.CsvVisible = false;
            this.commonToolStrip.DeleteEnabled = true;
            this.commonToolStrip.DeleteVisible = false;
            this.commonToolStrip.Displaytext = true;
            this.commonToolStrip.ExitEnabled = true;
            this.commonToolStrip.ExitVisible = true;
            this.commonToolStrip.GobackEnabled = true;
            this.commonToolStrip.GobackVisible = true;
            this.commonToolStrip.HelpEnabled = true;
            this.commonToolStrip.HelpVisible = true;
            this.commonToolStrip.Line1Visible = false;
            this.commonToolStrip.Line2Visible = false;
            this.commonToolStrip.Line3Visible = true;
            this.commonToolStrip.Line4Visible = true;
            this.commonToolStrip.Name = "commonToolStrip";
            this.commonToolStrip.OkEnabled = true;
            this.commonToolStrip.OkVisible = true;
            this.commonToolStrip.ReportEnabled = true;
            this.commonToolStrip.ReportVisible = false;
            this.commonToolStrip.SaveEnabled = true;
            this.commonToolStrip.SaveVisible = true;
            this.commonToolStrip.UpdateEnabled = true;
            this.commonToolStrip.UpdateVisible = false;
            // 
            // tlpG1
            // 
            resources.ApplyResources(this.tlpG1, "tlpG1");
            this.tlpG1.Controls.Add(this.btnFactoryHelper, 3, 0);
            this.tlpG1.Controls.Add(this.txtFactoryCd, 2, 0);
            this.tlpG1.Controls.Add(this.lblFactoryNm, 4, 0);
            this.tlpG1.Controls.Add(this.caplblFactory, 0, 0);
            this.tlpG1.Controls.Add(this.label1, 1, 0);
            this.tlpG1.Name = "tlpG1";
            // 
            // btnFactoryHelper
            // 
            resources.ApplyResources(this.btnFactoryHelper, "btnFactoryHelper");
            this.btnFactoryHelper.Name = "btnFactoryHelper";
            this.btnFactoryHelper.TabStop = false;
            this.btnFactoryHelper.UseVisualStyleBackColor = true;
            // 
            // txtFactoryCd
            // 
            resources.ApplyResources(this.txtFactoryCd, "txtFactoryCd");
            this.txtFactoryCd.Name = "txtFactoryCd";
            // 
            // lblFactoryNm
            // 
            resources.ApplyResources(this.lblFactoryNm, "lblFactoryNm");
            this.lblFactoryNm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFactoryNm.Name = "lblFactoryNm";
            // 
            // caplblFactory
            // 
            resources.ApplyResources(this.caplblFactory, "caplblFactory");
            this.caplblFactory.Name = "caplblFactory";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.tabPage1.Controls.Add(this.tableLayoutPanel2);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.UseWaitCursor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseWaitCursor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            resources.ApplyResources(this.tabPage3, "tabPage3");
            this.tabPage3.Name = "tabPage3";
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.UseWaitCursor = true;
            // 
            // FrmMaterialEdit
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmMaterialEdit";
            this.Load += new System.EventHandler(this.FrmMaterialEdit_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tlpG1.ResumeLayout(false);
            this.tlpG1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private xpLabel.xpLabel xplblMode;
        private Com.GainWinSoft.Common.Control.CommonToolStrip.CommonToolStrip commonToolStrip;
        private System.Windows.Forms.TableLayoutPanel tlpG1;
        private System.Windows.Forms.Label caplblFactory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFactoryNm;
        private System.Windows.Forms.TextBox txtFactoryCd;
        private System.Windows.Forms.Button btnFactoryHelper;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}

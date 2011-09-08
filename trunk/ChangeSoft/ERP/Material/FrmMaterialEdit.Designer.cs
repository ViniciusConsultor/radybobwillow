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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMaterialEdit));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.conditionRadioButton1 = new Com.GainWinSoft.Common.Control.ConditionRadioButton.ConditionRadioButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.conditionRadioButton1, 0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // conditionRadioButton1
            // 
            this.conditionRadioButton1.Checkedname = "";
            this.conditionRadioButton1.Checkedvalue = "";
            this.conditionRadioButton1.Conditionname = "Language";
            this.conditionRadioButton1.Defaultselectedindex = 0;
            resources.ApplyResources(this.conditionRadioButton1, "conditionRadioButton1");
            this.conditionRadioButton1.Name = "conditionRadioButton1";
            this.conditionRadioButton1.RadioChanged += new Com.GainWinSoft.Common.Control.ConditionRadioButton.ConditionRadioButton.OnCheckedChangeEventHandler(this.conditionRadioButton1_RadioChanged);
            // 
            // FrmMaterialEdit
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmMaterialEdit";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Com.GainWinSoft.Common.Control.ConditionRadioButton.ConditionRadioButton conditionRadioButton1;
        private System.Windows.Forms.Button button1;
    }
}

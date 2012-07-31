namespace Com.GainWinSoft.ERP.CodeRef
{
    partial class CodeRefPerson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CodeRefPerson));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tddlSection = new Com.GainWinSoft.ERP.TableDropDownList.TableDropDownList();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.atxtPersonCd = new AMS.TextBox.AlphanumericTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPersonNm = new System.Windows.Forms.TextBox();
            this.btnInquiry = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.tddlSection, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.atxtPersonCd, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtPersonNm, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnInquiry, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnClear, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // tddlSection
            // 
            this.tddlSection.Autoaddblankitem = true;
            this.tddlSection.Defaultselectedindex = 0;
            resources.ApplyResources(this.tddlSection, "tddlSection");
            this.tddlSection.LanguageColumn = null;
            this.tddlSection.LanguageFlg = false;
            this.tddlSection.Name = "tddlSection";
            this.tddlSection.NameColumn = "I_SECTION_ARG_DESC";
            this.tddlSection.SelectedIndex = -1;
            this.tddlSection.Selectedname = null;
            this.tddlSection.Selectedvalue = null;
            this.tddlSection.TableNm = "T_SECTION_MS";
            this.tddlSection.ValueColumn = "I_SECTION_CD";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // atxtPersonCd
            // 
            resources.ApplyResources(this.atxtPersonCd, "atxtPersonCd");
            this.atxtPersonCd.Flags = 0;
            this.atxtPersonCd.InvalidChars = new char[] {
        '%',
        '\'',
        '*',
        '\"',
        '+',
        '?',
        '>',
        '<',
        ':',
        '\\'};
            this.atxtPersonCd.Name = "atxtPersonCd";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // txtPersonNm
            // 
            resources.ApplyResources(this.txtPersonNm, "txtPersonNm");
            this.txtPersonNm.Name = "txtPersonNm";
            // 
            // btnInquiry
            // 
            resources.ApplyResources(this.btnInquiry, "btnInquiry");
            this.btnInquiry.Name = "btnInquiry";
            this.btnInquiry.UseVisualStyleBackColor = true;
            this.btnInquiry.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClear
            // 
            resources.ApplyResources(this.btnClear, "btnClear");
            this.btnClear.Name = "btnClear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridView1, 5);
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // CodeRefPerson
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CodeRefPerson";
            this.Load += new System.EventHandler(this.CodeRefPerson_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Com.GainWinSoft.ERP.TableDropDownList.TableDropDownList tddlSection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private AMS.TextBox.AlphanumericTextBox atxtPersonCd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPersonNm;
        private System.Windows.Forms.Button btnInquiry;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

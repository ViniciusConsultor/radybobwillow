namespace Com.GainWinSoft.ERP.CodeRef
{
    partial class TestCode
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
            this.tblBase = new System.Windows.Forms.TableLayoutPanel();
            this.dgvCode = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tblBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCode)).BeginInit();
            this.SuspendLayout();
            // 
            // tblBase
            // 
            this.tblBase.ColumnCount = 2;
            this.tblBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblBase.Controls.Add(this.dgvCode, 0, 2);
            this.tblBase.Controls.Add(this.textBox1, 0, 0);
            this.tblBase.Controls.Add(this.button1, 1, 0);
            this.tblBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblBase.Location = new System.Drawing.Point(0, 0);
            this.tblBase.Name = "tblBase";
            this.tblBase.RowCount = 3;
            this.tblBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tblBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tblBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblBase.Size = new System.Drawing.Size(294, 277);
            this.tblBase.TabIndex = 0;
            // 
            // dgvCode
            // 
            this.dgvCode.AllowUserToAddRows = false;
            this.dgvCode.AllowUserToDeleteRows = false;
            this.dgvCode.AllowUserToResizeColumns = false;
            this.dgvCode.AllowUserToResizeRows = false;
            this.dgvCode.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCode.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dgvCode.BackgroundColor = System.Drawing.Color.White;
            this.dgvCode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblBase.SetColumnSpan(this.dgvCode, 2);
            this.dgvCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCode.Location = new System.Drawing.Point(3, 63);
            this.dgvCode.Name = "dgvCode";
            this.dgvCode.ReadOnly = true;
            this.dgvCode.RowTemplate.Height = 21;
            this.dgvCode.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCode.Size = new System.Drawing.Size(288, 211);
            this.dgvCode.TabIndex = 0;
            this.dgvCode.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCode_CellDoubleClick);
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 21);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(150, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // TestCode
            // 
            this.AllowEndUserDocking = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 277);
            this.Controls.Add(this.tblBase);
            this.DockAreas = WeifenLuo.WinFormsUI.Docking.DockAreas.Float;
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "TestCode";
            this.Text = "Form1";
            this.tblBase.ResumeLayout(false);
            this.tblBase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblBase;
        private System.Windows.Forms.DataGridView dgvCode;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}


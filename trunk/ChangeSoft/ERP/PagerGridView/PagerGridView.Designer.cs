namespace Com.GainWinSoft.Common.Control.PagerGridView
{
    partial class PagerGridView
    {
        /// <summary>
        /// 必要なデザイナ変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナで生成されたコード

        /// <summary>
        /// デザイナ サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディタで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PagerGridView));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.lblCurrentPageFirst = new System.Windows.Forms.Label();
            this.lblCurrentPageLast = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotalRecords = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ColumnsSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PrintListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.btnFirst, 9, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnPrevious, 10, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblStatus, 11, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnNext, 12, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnLast, 13, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblCurrentPageFirst, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblCurrentPageLast, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label6, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblTotalRecords, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.label8, 7, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // btnFirst
            // 
            resources.ApplyResources(this.btnFirst, "btnFirst");
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrevious
            // 
            resources.ApplyResources(this.btnPrevious, "btnPrevious");
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.lblStatus, "lblStatus");
            this.lblStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblStatus.Name = "lblStatus";
            // 
            // btnNext
            // 
            resources.ApplyResources(this.btnNext, "btnNext");
            this.btnNext.Name = "btnNext";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            resources.ApplyResources(this.btnLast, "btnLast");
            this.btnLast.Name = "btnLast";
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // lblCurrentPageFirst
            // 
            resources.ApplyResources(this.lblCurrentPageFirst, "lblCurrentPageFirst");
            this.lblCurrentPageFirst.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblCurrentPageFirst.Name = "lblCurrentPageFirst";
            // 
            // lblCurrentPageLast
            // 
            resources.ApplyResources(this.lblCurrentPageLast, "lblCurrentPageLast");
            this.lblCurrentPageLast.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblCurrentPageLast.Name = "lblCurrentPageLast";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Name = "label6";
            // 
            // lblTotalRecords
            // 
            resources.ApplyResources(this.lblTotalRecords, "lblTotalRecords");
            this.lblTotalRecords.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTotalRecords.Name = "lblTotalRecords";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Name = "label8";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ColumnsSettingToolStripMenuItem,
            this.PrintListToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // ColumnsSettingToolStripMenuItem
            // 
            this.ColumnsSettingToolStripMenuItem.Name = "ColumnsSettingToolStripMenuItem";
            resources.ApplyResources(this.ColumnsSettingToolStripMenuItem, "ColumnsSettingToolStripMenuItem");
            this.ColumnsSettingToolStripMenuItem.Click += new System.EventHandler(this.ColumnsSettingToolStripMenuItem_Click);
            // 
            // PrintListToolStripMenuItem
            // 
            this.PrintListToolStripMenuItem.Name = "PrintListToolStripMenuItem";
            resources.ApplyResources(this.PrintListToolStripMenuItem, "PrintListToolStripMenuItem");
            // 
            // PagerGridView
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PagerGridView";
            this.Load += new System.EventHandler(this.PagerGridView_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblCurrentPageFirst;
        private System.Windows.Forms.Label lblCurrentPageLast;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTotalRecords;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ColumnsSettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PrintListToolStripMenuItem;

    }
}

namespace Com.GainWinSoft.ERP.RootManager
{
    partial class FrmRootManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tlpBase = new System.Windows.Forms.TableLayoutPanel();
            this.commonToolStrip1 = new Com.GainWinSoft.Common.Control.CommonToolStrip.CommonToolStrip();
            this.tlpGrp = new System.Windows.Forms.TableLayoutPanel();
            this.tlpBase.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpBase
            // 
            this.tlpBase.ColumnCount = 1;
            this.tlpBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpBase.Controls.Add(this.commonToolStrip1, 0, 0);
            this.tlpBase.Controls.Add(this.tlpGrp, 0, 1);
            this.tlpBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBase.Location = new System.Drawing.Point(0, 0);
            this.tlpBase.Margin = new System.Windows.Forms.Padding(0);
            this.tlpBase.Name = "tlpBase";
            this.tlpBase.RowCount = 2;
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpBase.Size = new System.Drawing.Size(792, 573);
            this.tlpBase.TabIndex = 0;
            // 
            // commonToolStrip1
            // 
            this.commonToolStrip1.AddEnabled = true;
            this.commonToolStrip1.AddVisible = true;
            this.commonToolStrip1.AutoSize = true;
            this.commonToolStrip1.CleargroupEnabled = true;
            this.commonToolStrip1.CleargroupVisible = true;
            this.commonToolStrip1.CopyEnabled = true;
            this.commonToolStrip1.CopyVisible = true;
            this.commonToolStrip1.CsvEnabled = true;
            this.commonToolStrip1.CsvVisible = true;
            this.commonToolStrip1.DeleteEnabled = true;
            this.commonToolStrip1.DeleteVisible = true;
            this.commonToolStrip1.Displaytext = true;
            this.commonToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commonToolStrip1.ExitEnabled = true;
            this.commonToolStrip1.ExitVisible = true;
            this.commonToolStrip1.GobackEnabled = true;
            this.commonToolStrip1.GobackVisible = true;
            this.commonToolStrip1.HelpEnabled = true;
            this.commonToolStrip1.HelpVisible = true;
            this.commonToolStrip1.Line1Visible = true;
            this.commonToolStrip1.Line2Visible = true;
            this.commonToolStrip1.Line3Visible = true;
            this.commonToolStrip1.Line4Visible = true;
            this.commonToolStrip1.Location = new System.Drawing.Point(3, 3);
            this.commonToolStrip1.Name = "commonToolStrip1";
            this.commonToolStrip1.OkEnabled = true;
            this.commonToolStrip1.OkVisible = true;
            this.commonToolStrip1.ReportEnabled = true;
            this.commonToolStrip1.ReportVisible = true;
            this.commonToolStrip1.SaveEnabled = true;
            this.commonToolStrip1.SaveVisible = true;
            this.commonToolStrip1.Size = new System.Drawing.Size(786, 49);
            this.commonToolStrip1.TabIndex = 0;
            this.commonToolStrip1.UpdateEnabled = true;
            this.commonToolStrip1.UpdateVisible = true;
            // 
            // tlpGrp
            // 
            this.tlpGrp.ColumnCount = 1;
            this.tlpGrp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tlpGrp.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpGrp.Location = new System.Drawing.Point(0, 58);
            this.tlpGrp.Name = "tlpGrp";
            this.tlpGrp.RowCount = 3;
            this.tlpGrp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 127F));
            this.tlpGrp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 188F));
            this.tlpGrp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.tlpGrp.Size = new System.Drawing.Size(789, 513);
            this.tlpGrp.TabIndex = 1;
            // 
            // FrmRootManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.tlpBase);
            this.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Name = "FrmRootManager";
            this.Text = "Root管理";
            this.tlpBase.ResumeLayout(false);
            this.tlpBase.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpBase;
        private Com.GainWinSoft.Common.Control.CommonToolStrip.CommonToolStrip commonToolStrip1;
        private System.Windows.Forms.TableLayoutPanel tlpGrp;
    }
}
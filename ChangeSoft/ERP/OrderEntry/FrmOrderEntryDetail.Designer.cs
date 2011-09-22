namespace OrderEntry
{
    partial class FrmOrderEntryDetail
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
            this.lblPanelBase = new System.Windows.Forms.TableLayoutPanel();
            this.xpLabel1 = new xpLabel.xpLabel();
            this.tblPanelGrp = new System.Windows.Forms.TableLayoutPanel();
            this.lblPanelBase.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPanelBase
            // 
            this.lblPanelBase.ColumnCount = 1;
            this.lblPanelBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.lblPanelBase.Controls.Add(this.xpLabel1, 0, 0);
            this.lblPanelBase.Controls.Add(this.tblPanelGrp, 0, 1);
            this.lblPanelBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPanelBase.Location = new System.Drawing.Point(0, 0);
            this.lblPanelBase.Margin = new System.Windows.Forms.Padding(0);
            this.lblPanelBase.Name = "lblPanelBase";
            this.lblPanelBase.RowCount = 2;
            this.lblPanelBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.lblPanelBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 508F));
            this.lblPanelBase.Size = new System.Drawing.Size(792, 573);
            this.lblPanelBase.TabIndex = 0;
            // 
            // xpLabel1
            // 
            this.xpLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(191)))), ((int)(((byte)(236)))));
            this.xpLabel1.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(191)))), ((int)(((byte)(236)))));
            this.xpLabel1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(102)))), ((int)(((byte)(187)))));
            this.xpLabel1.BackColorScheme = xpLabel.BackColorSchemeType.Office2003Blue;
            this.xpLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xpLabel1.Location = new System.Drawing.Point(3, 3);
            this.xpLabel1.Name = "xpLabel1";
            this.xpLabel1.ShowShadow = false;
            this.xpLabel1.Size = new System.Drawing.Size(786, 20);
            this.xpLabel1.TabIndex = 0;
            this.xpLabel1.Text = "xpLabel1";
            this.xpLabel1.TextAlign = xpLabel.TextAlignStyle.TAlignLeftMiddle;
            // 
            // tblPanelGrp
            // 
            this.tblPanelGrp.ColumnCount = 1;
            this.tblPanelGrp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPanelGrp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPanelGrp.Location = new System.Drawing.Point(0, 26);
            this.tblPanelGrp.Margin = new System.Windows.Forms.Padding(0);
            this.tblPanelGrp.Name = "tblPanelGrp";
            this.tblPanelGrp.RowCount = 4;
            this.tblPanelGrp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tblPanelGrp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPanelGrp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tblPanelGrp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 306F));
            this.tblPanelGrp.Size = new System.Drawing.Size(792, 547);
            this.tblPanelGrp.TabIndex = 1;
            // 
            // FrmOrderEntryDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.lblPanelBase);
            this.Name = "FrmOrderEntryDetail";
            this.Text = "订单详细";
            this.lblPanelBase.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel lblPanelBase;
        private xpLabel.xpLabel xpLabel1;
        private System.Windows.Forms.TableLayoutPanel tblPanelGrp;
    }
}
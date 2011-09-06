﻿namespace Com.ChangeSoft.ERP.Factory
{
	partial class FrmFactory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFactory));
            this.tpBase = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnFactory = new System.Windows.Forms.Button();
            this.txtFactory = new System.Windows.Forms.TextBox();
            this.lblStar2 = new System.Windows.Forms.Label();
            this.lblFactory = new System.Windows.Forms.Label();
            this.lblCompanyNM = new System.Windows.Forms.Label();
            this.lblCompany = new System.Windows.Forms.Label();
            this.lblStar1 = new System.Windows.Forms.Label();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.btnCompany = new System.Windows.Forms.Button();
            this.tpMode = new System.Windows.Forms.TableLayoutPanel();
            this.rbAdd = new System.Windows.Forms.RadioButton();
            this.rbUpd = new System.Windows.Forms.RadioButton();
            this.rbDel = new System.Windows.Forms.RadioButton();
            this.commonToolStrip1 = new Com.ChangeSoft.Common.Control.CommonToolStrip.CommonToolStrip();
            this.tpBase.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tpMode.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpBase
            // 
            resources.ApplyResources(this.tpBase, "tpBase");
            this.tpBase.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tpBase.Name = "tpBase";
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.commonToolStrip1, 0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.btnFactory, 9, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtFactory, 8, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblStar2, 7, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblFactory, 6, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblCompanyNM, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblCompany, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblStar1, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtCompany, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnCompany, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.tpMode, 2, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // btnFactory
            // 
            resources.ApplyResources(this.btnFactory, "btnFactory");
            this.btnFactory.Name = "btnFactory";
            this.btnFactory.UseVisualStyleBackColor = true;
            // 
            // txtFactory
            // 
            resources.ApplyResources(this.txtFactory, "txtFactory");
            this.txtFactory.Name = "txtFactory";
            // 
            // lblStar2
            // 
            resources.ApplyResources(this.lblStar2, "lblStar2");
            this.lblStar2.ForeColor = System.Drawing.Color.Red;
            this.lblStar2.Name = "lblStar2";
            // 
            // lblFactory
            // 
            resources.ApplyResources(this.lblFactory, "lblFactory");
            this.lblFactory.Name = "lblFactory";
            // 
            // lblCompanyNM
            // 
            resources.ApplyResources(this.lblCompanyNM, "lblCompanyNM");
            this.tableLayoutPanel2.SetColumnSpan(this.lblCompanyNM, 6);
            this.lblCompanyNM.Name = "lblCompanyNM";
            // 
            // lblCompany
            // 
            resources.ApplyResources(this.lblCompany, "lblCompany");
            this.lblCompany.Name = "lblCompany";
            // 
            // lblStar1
            // 
            resources.ApplyResources(this.lblStar1, "lblStar1");
            this.lblStar1.ForeColor = System.Drawing.Color.Red;
            this.lblStar1.Name = "lblStar1";
            // 
            // txtCompany
            // 
            resources.ApplyResources(this.txtCompany, "txtCompany");
            this.txtCompany.Name = "txtCompany";
            // 
            // btnCompany
            // 
            resources.ApplyResources(this.btnCompany, "btnCompany");
            this.btnCompany.Name = "btnCompany";
            this.btnCompany.UseVisualStyleBackColor = true;
            // 
            // tpMode
            // 
            resources.ApplyResources(this.tpMode, "tpMode");
            this.tableLayoutPanel2.SetColumnSpan(this.tpMode, 3);
            this.tpMode.Controls.Add(this.rbAdd, 0, 0);
            this.tpMode.Controls.Add(this.rbUpd, 1, 0);
            this.tpMode.Controls.Add(this.rbDel, 2, 0);
            this.tpMode.Name = "tpMode";
            // 
            // rbAdd
            // 
            resources.ApplyResources(this.rbAdd, "rbAdd");
            this.rbAdd.Name = "rbAdd";
            this.rbAdd.TabStop = true;
            this.rbAdd.UseVisualStyleBackColor = true;
            // 
            // rbUpd
            // 
            resources.ApplyResources(this.rbUpd, "rbUpd");
            this.rbUpd.Name = "rbUpd";
            this.rbUpd.TabStop = true;
            this.rbUpd.UseVisualStyleBackColor = true;
            // 
            // rbDel
            // 
            resources.ApplyResources(this.rbDel, "rbDel");
            this.rbDel.Name = "rbDel";
            this.rbDel.TabStop = true;
            this.rbDel.UseVisualStyleBackColor = true;
            // 
            // commonToolStrip1
            // 
            this.commonToolStrip1.AddEnabled = true;
            this.commonToolStrip1.AddVisible = true;
            resources.ApplyResources(this.commonToolStrip1, "commonToolStrip1");
            this.commonToolStrip1.CopyEnabled = true;
            this.commonToolStrip1.CopyVisible = true;
            this.commonToolStrip1.CsvEnabled = true;
            this.commonToolStrip1.CsvVisible = true;
            this.commonToolStrip1.DeleteEnabled = true;
            this.commonToolStrip1.DeleteVisible = true;
            this.commonToolStrip1.Displaytext = false;
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
            this.commonToolStrip1.Name = "commonToolStrip1";
            this.commonToolStrip1.OkEnabled = true;
            this.commonToolStrip1.OkVisible = true;
            this.commonToolStrip1.ReportEnabled = true;
            this.commonToolStrip1.ReportVisible = true;
            this.commonToolStrip1.SaveEnabled = true;
            this.commonToolStrip1.SaveVisible = true;
            this.commonToolStrip1.UpdateEnabled = true;
            this.commonToolStrip1.UpdateVisible = true;
            // 
            // FrmFactory
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tpBase);
            this.Name = "FrmFactory";
            this.tpBase.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tpMode.ResumeLayout(false);
            this.tpMode.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

        private System.Windows.Forms.TableLayoutPanel tpBase;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Label lblStar1;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.Button btnCompany;
        private System.Windows.Forms.Label lblCompanyNM;
        private System.Windows.Forms.TableLayoutPanel tpMode;
        private System.Windows.Forms.RadioButton rbAdd;
        private System.Windows.Forms.RadioButton rbUpd;
        private System.Windows.Forms.RadioButton rbDel;
        private System.Windows.Forms.Label lblFactory;
        private System.Windows.Forms.Label lblStar2;
        private System.Windows.Forms.TextBox txtFactory;
        private System.Windows.Forms.Button btnFactory;
        private Com.ChangeSoft.Common.Control.CommonToolStrip.CommonToolStrip commonToolStrip1;
	}
}
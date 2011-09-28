namespace Com.GainWinSoft.ERP.ExchangeRate
{
    partial class FrmExchangeRate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExchangeRate));
            this.tblPanelBase = new System.Windows.Forms.TableLayoutPanel();
            this.tblPanelGrp = new System.Windows.Forms.TableLayoutPanel();
            this.tblPanelG1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblCurrKbn = new System.Windows.Forms.Label();
            this.lblCompanyNM = new System.Windows.Forms.Label();
            this.btnCompany = new System.Windows.Forms.Button();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.lblStar1 = new System.Windows.Forms.Label();
            this.lblCompany = new System.Windows.Forms.Label();
            this.lblRateKbn = new System.Windows.Forms.Label();
            this.tblPanelBtn = new System.Windows.Forms.TableLayoutPanel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.clsddl_9A = new ClsDetailCodeRefDropDownList.ClsDetailCodeRefDropDownList();
            this.tddlCurr = new Com.GainWinSoft.ERP.TableDropDownList.TableDropDownList();
            this.tblPanelG3 = new System.Windows.Forms.TableLayoutPanel();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.lblStar2 = new System.Windows.Forms.Label();
            this.lblStar3 = new System.Windows.Forms.Label();
            this.lblStar5 = new System.Windows.Forms.Label();
            this.lblStar4 = new System.Windows.Forms.Label();
            this.lblStar6 = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.lblCalcMode = new System.Windows.Forms.Label();
            this.lblValidDate = new System.Windows.Forms.Label();
            this.lblCurrKbn1 = new System.Windows.Forms.Label();
            this.lblRateKbn1 = new System.Windows.Forms.Label();
            this.cndCurrKbn_G3 = new Com.GainWinSoft.Common.Control.ConditionDropDownList.ConditionDropDownList();
            this.clsddl_9A_G3 = new ClsDetailCodeRefDropDownList.ClsDetailCodeRefDropDownList();
            this.cndCalcMode = new Com.GainWinSoft.Common.Control.ConditionDropDownList.ConditionDropDownList();
            this.xdtpEffEedDate = new Com.GainWinSoft.Common.Control.XDateTimePicker.XDateTimePicker();
            this.commonToolStrip1 = new Com.GainWinSoft.Common.Control.CommonToolStrip.CommonToolStrip();
            this.tblPanelG2 = new System.Windows.Forms.TableLayoutPanel();
            this.pgvRateMs = new Com.GainWinSoft.Common.Control.PagerGridView.PagerGridView();
            this.tblPanelBase.SuspendLayout();
            this.tblPanelGrp.SuspendLayout();
            this.tblPanelG1.SuspendLayout();
            this.tblPanelBtn.SuspendLayout();
            this.tblPanelG3.SuspendLayout();
            this.tblPanelG2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblPanelBase
            // 
            this.tblPanelBase.AccessibleDescription = null;
            this.tblPanelBase.AccessibleName = null;
            resources.ApplyResources(this.tblPanelBase, "tblPanelBase");
            this.tblPanelBase.BackgroundImage = null;
            this.tblPanelBase.Controls.Add(this.tblPanelGrp, 0, 0);
            this.tblPanelBase.Font = null;
            this.tblPanelBase.Name = "tblPanelBase";
            // 
            // tblPanelGrp
            // 
            this.tblPanelGrp.AccessibleDescription = null;
            this.tblPanelGrp.AccessibleName = null;
            resources.ApplyResources(this.tblPanelGrp, "tblPanelGrp");
            this.tblPanelGrp.BackgroundImage = null;
            this.tblPanelGrp.Controls.Add(this.tblPanelG1, 0, 1);
            this.tblPanelGrp.Controls.Add(this.tblPanelG3, 0, 3);
            this.tblPanelGrp.Controls.Add(this.commonToolStrip1, 0, 0);
            this.tblPanelGrp.Controls.Add(this.tblPanelG2, 0, 2);
            this.tblPanelGrp.Font = null;
            this.tblPanelGrp.Name = "tblPanelGrp";
            // 
            // tblPanelG1
            // 
            this.tblPanelG1.AccessibleDescription = null;
            this.tblPanelG1.AccessibleName = null;
            resources.ApplyResources(this.tblPanelG1, "tblPanelG1");
            this.tblPanelG1.BackgroundImage = null;
            this.tblPanelG1.Controls.Add(this.lblCurrKbn, 0, 2);
            this.tblPanelG1.Controls.Add(this.lblCompanyNM, 4, 0);
            this.tblPanelG1.Controls.Add(this.btnCompany, 3, 0);
            this.tblPanelG1.Controls.Add(this.txtCompany, 2, 0);
            this.tblPanelG1.Controls.Add(this.lblStar1, 1, 0);
            this.tblPanelG1.Controls.Add(this.lblCompany, 0, 0);
            this.tblPanelG1.Controls.Add(this.lblRateKbn, 0, 1);
            this.tblPanelG1.Controls.Add(this.tblPanelBtn, 5, 3);
            this.tblPanelG1.Controls.Add(this.clsddl_9A, 2, 1);
            this.tblPanelG1.Controls.Add(this.tddlCurr, 2, 2);
            this.tblPanelG1.Font = null;
            this.tblPanelG1.Name = "tblPanelG1";
            // 
            // lblCurrKbn
            // 
            this.lblCurrKbn.AccessibleDescription = null;
            this.lblCurrKbn.AccessibleName = null;
            resources.ApplyResources(this.lblCurrKbn, "lblCurrKbn");
            this.lblCurrKbn.Font = null;
            this.lblCurrKbn.Name = "lblCurrKbn";
            // 
            // lblCompanyNM
            // 
            this.lblCompanyNM.AccessibleDescription = null;
            this.lblCompanyNM.AccessibleName = null;
            resources.ApplyResources(this.lblCompanyNM, "lblCompanyNM");
            this.lblCompanyNM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCompanyNM.Font = null;
            this.lblCompanyNM.Name = "lblCompanyNM";
            // 
            // btnCompany
            // 
            this.btnCompany.AccessibleDescription = null;
            this.btnCompany.AccessibleName = null;
            resources.ApplyResources(this.btnCompany, "btnCompany");
            this.btnCompany.BackgroundImage = null;
            this.btnCompany.Font = null;
            this.btnCompany.Name = "btnCompany";
            this.btnCompany.UseVisualStyleBackColor = true;
            // 
            // txtCompany
            // 
            this.txtCompany.AccessibleDescription = null;
            this.txtCompany.AccessibleName = null;
            resources.ApplyResources(this.txtCompany, "txtCompany");
            this.txtCompany.BackgroundImage = null;
            this.txtCompany.Font = null;
            this.txtCompany.Name = "txtCompany";
            // 
            // lblStar1
            // 
            this.lblStar1.AccessibleDescription = null;
            this.lblStar1.AccessibleName = null;
            resources.ApplyResources(this.lblStar1, "lblStar1");
            this.lblStar1.Font = null;
            this.lblStar1.ForeColor = System.Drawing.Color.Red;
            this.lblStar1.Name = "lblStar1";
            // 
            // lblCompany
            // 
            this.lblCompany.AccessibleDescription = null;
            this.lblCompany.AccessibleName = null;
            resources.ApplyResources(this.lblCompany, "lblCompany");
            this.lblCompany.Font = null;
            this.lblCompany.Name = "lblCompany";
            // 
            // lblRateKbn
            // 
            this.lblRateKbn.AccessibleDescription = null;
            this.lblRateKbn.AccessibleName = null;
            resources.ApplyResources(this.lblRateKbn, "lblRateKbn");
            this.lblRateKbn.Font = null;
            this.lblRateKbn.Name = "lblRateKbn";
            // 
            // tblPanelBtn
            // 
            this.tblPanelBtn.AccessibleDescription = null;
            this.tblPanelBtn.AccessibleName = null;
            resources.ApplyResources(this.tblPanelBtn, "tblPanelBtn");
            this.tblPanelBtn.BackgroundImage = null;
            this.tblPanelBtn.Controls.Add(this.btnSearch, 2, 0);
            this.tblPanelBtn.Controls.Add(this.btnClear, 1, 0);
            this.tblPanelBtn.Font = null;
            this.tblPanelBtn.Name = "tblPanelBtn";
            // 
            // btnSearch
            // 
            this.btnSearch.AccessibleDescription = null;
            this.btnSearch.AccessibleName = null;
            resources.ApplyResources(this.btnSearch, "btnSearch");
            this.btnSearch.BackgroundImage = null;
            this.btnSearch.Font = null;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClear
            // 
            this.btnClear.AccessibleDescription = null;
            this.btnClear.AccessibleName = null;
            resources.ApplyResources(this.btnClear, "btnClear");
            this.btnClear.BackgroundImage = null;
            this.btnClear.Font = null;
            this.btnClear.Name = "btnClear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // clsddl_9A
            // 
            this.clsddl_9A.AccessibleDescription = null;
            this.clsddl_9A.AccessibleName = null;
            resources.ApplyResources(this.clsddl_9A, "clsddl_9A");
            this.clsddl_9A.Autoaddblankitem = true;
            this.clsddl_9A.BackgroundImage = null;
            this.clsddl_9A.ClsCd = "9A";
            this.clsddl_9A.Defaultselectedindex = 0;
            this.clsddl_9A.Font = null;
            this.clsddl_9A.Name = "clsddl_9A";
            this.clsddl_9A.Selectedindex = -1;
            this.clsddl_9A.Selectedname = null;
            this.clsddl_9A.Selectedvalue = null;
            this.clsddl_9A.ShowNameDesc = false;
            // 
            // tddlCurr
            // 
            this.tddlCurr.AccessibleDescription = null;
            this.tddlCurr.AccessibleName = null;
            resources.ApplyResources(this.tddlCurr, "tddlCurr");
            this.tddlCurr.Autoaddblankitem = true;
            this.tddlCurr.BackgroundImage = null;
            this.tddlCurr.Defaultselectedindex = 0;
            this.tddlCurr.Font = null;
            this.tddlCurr.LanguageColumn = null;
            this.tddlCurr.LanguageFlg = false;
            this.tddlCurr.Name = "tddlCurr";
            this.tddlCurr.NameColumn = "I_CURR_DESC";
            this.tddlCurr.SelectedIndex = -1;
            this.tddlCurr.Selectedname = null;
            this.tddlCurr.Selectedvalue = null;
            this.tddlCurr.TableNm = "T_CURR_MS";
            this.tddlCurr.ValueColumn = "I_CURR_CD";
            // 
            // tblPanelG3
            // 
            this.tblPanelG3.AccessibleDescription = null;
            this.tblPanelG3.AccessibleName = null;
            resources.ApplyResources(this.tblPanelG3, "tblPanelG3");
            this.tblPanelG3.BackgroundImage = null;
            this.tblPanelG3.Controls.Add(this.txtRate, 6, 3);
            this.tblPanelG3.Controls.Add(this.lblStar2, 1, 0);
            this.tblPanelG3.Controls.Add(this.lblStar3, 1, 1);
            this.tblPanelG3.Controls.Add(this.lblStar5, 1, 3);
            this.tblPanelG3.Controls.Add(this.lblStar4, 1, 2);
            this.tblPanelG3.Controls.Add(this.lblStar6, 5, 3);
            this.tblPanelG3.Controls.Add(this.lblRate, 4, 3);
            this.tblPanelG3.Controls.Add(this.lblCalcMode, 0, 3);
            this.tblPanelG3.Controls.Add(this.lblValidDate, 0, 2);
            this.tblPanelG3.Controls.Add(this.lblCurrKbn1, 0, 1);
            this.tblPanelG3.Controls.Add(this.lblRateKbn1, 0, 0);
            this.tblPanelG3.Controls.Add(this.cndCurrKbn_G3, 2, 1);
            this.tblPanelG3.Controls.Add(this.clsddl_9A_G3, 2, 0);
            this.tblPanelG3.Controls.Add(this.cndCalcMode, 2, 3);
            this.tblPanelG3.Controls.Add(this.xdtpEffEedDate, 2, 2);
            this.tblPanelG3.Font = null;
            this.tblPanelG3.Name = "tblPanelG3";
            // 
            // txtRate
            // 
            this.txtRate.AccessibleDescription = null;
            this.txtRate.AccessibleName = null;
            resources.ApplyResources(this.txtRate, "txtRate");
            this.txtRate.BackgroundImage = null;
            this.txtRate.Font = null;
            this.txtRate.Name = "txtRate";
            // 
            // lblStar2
            // 
            this.lblStar2.AccessibleDescription = null;
            this.lblStar2.AccessibleName = null;
            resources.ApplyResources(this.lblStar2, "lblStar2");
            this.lblStar2.Font = null;
            this.lblStar2.ForeColor = System.Drawing.Color.Red;
            this.lblStar2.Name = "lblStar2";
            // 
            // lblStar3
            // 
            this.lblStar3.AccessibleDescription = null;
            this.lblStar3.AccessibleName = null;
            resources.ApplyResources(this.lblStar3, "lblStar3");
            this.lblStar3.Font = null;
            this.lblStar3.ForeColor = System.Drawing.Color.Red;
            this.lblStar3.Name = "lblStar3";
            // 
            // lblStar5
            // 
            this.lblStar5.AccessibleDescription = null;
            this.lblStar5.AccessibleName = null;
            resources.ApplyResources(this.lblStar5, "lblStar5");
            this.lblStar5.Font = null;
            this.lblStar5.ForeColor = System.Drawing.Color.Red;
            this.lblStar5.Name = "lblStar5";
            // 
            // lblStar4
            // 
            this.lblStar4.AccessibleDescription = null;
            this.lblStar4.AccessibleName = null;
            resources.ApplyResources(this.lblStar4, "lblStar4");
            this.lblStar4.Font = null;
            this.lblStar4.ForeColor = System.Drawing.Color.Red;
            this.lblStar4.Name = "lblStar4";
            // 
            // lblStar6
            // 
            this.lblStar6.AccessibleDescription = null;
            this.lblStar6.AccessibleName = null;
            resources.ApplyResources(this.lblStar6, "lblStar6");
            this.lblStar6.Font = null;
            this.lblStar6.ForeColor = System.Drawing.Color.Red;
            this.lblStar6.Name = "lblStar6";
            // 
            // lblRate
            // 
            this.lblRate.AccessibleDescription = null;
            this.lblRate.AccessibleName = null;
            resources.ApplyResources(this.lblRate, "lblRate");
            this.lblRate.Font = null;
            this.lblRate.Name = "lblRate";
            // 
            // lblCalcMode
            // 
            this.lblCalcMode.AccessibleDescription = null;
            this.lblCalcMode.AccessibleName = null;
            resources.ApplyResources(this.lblCalcMode, "lblCalcMode");
            this.lblCalcMode.Font = null;
            this.lblCalcMode.Name = "lblCalcMode";
            // 
            // lblValidDate
            // 
            this.lblValidDate.AccessibleDescription = null;
            this.lblValidDate.AccessibleName = null;
            resources.ApplyResources(this.lblValidDate, "lblValidDate");
            this.lblValidDate.Font = null;
            this.lblValidDate.Name = "lblValidDate";
            // 
            // lblCurrKbn1
            // 
            this.lblCurrKbn1.AccessibleDescription = null;
            this.lblCurrKbn1.AccessibleName = null;
            resources.ApplyResources(this.lblCurrKbn1, "lblCurrKbn1");
            this.lblCurrKbn1.Font = null;
            this.lblCurrKbn1.Name = "lblCurrKbn1";
            // 
            // lblRateKbn1
            // 
            this.lblRateKbn1.AccessibleDescription = null;
            this.lblRateKbn1.AccessibleName = null;
            resources.ApplyResources(this.lblRateKbn1, "lblRateKbn1");
            this.lblRateKbn1.Font = null;
            this.lblRateKbn1.Name = "lblRateKbn1";
            // 
            // cndCurrKbn_G3
            // 
            this.cndCurrKbn_G3.AccessibleDescription = null;
            this.cndCurrKbn_G3.AccessibleName = null;
            resources.ApplyResources(this.cndCurrKbn_G3, "cndCurrKbn_G3");
            this.cndCurrKbn_G3.Autoaddblankitem = true;
            this.cndCurrKbn_G3.BackgroundImage = null;
            this.cndCurrKbn_G3.Conditionname = "ExchangeCurr";
            this.cndCurrKbn_G3.Defaultselectedindex = 0;
            this.cndCurrKbn_G3.Font = null;
            this.cndCurrKbn_G3.Name = "cndCurrKbn_G3";
            this.cndCurrKbn_G3.Selectedindex = -1;
            this.cndCurrKbn_G3.Selectedname = null;
            this.cndCurrKbn_G3.Selectedvalue = null;
            // 
            // clsddl_9A_G3
            // 
            this.clsddl_9A_G3.AccessibleDescription = null;
            this.clsddl_9A_G3.AccessibleName = null;
            resources.ApplyResources(this.clsddl_9A_G3, "clsddl_9A_G3");
            this.clsddl_9A_G3.Autoaddblankitem = true;
            this.clsddl_9A_G3.BackgroundImage = null;
            this.clsddl_9A_G3.ClsCd = "9A";
            this.clsddl_9A_G3.Defaultselectedindex = 0;
            this.clsddl_9A_G3.Font = null;
            this.clsddl_9A_G3.Name = "clsddl_9A_G3";
            this.clsddl_9A_G3.Selectedindex = -1;
            this.clsddl_9A_G3.Selectedname = null;
            this.clsddl_9A_G3.Selectedvalue = null;
            this.clsddl_9A_G3.ShowNameDesc = false;
            // 
            // cndCalcMode
            // 
            this.cndCalcMode.AccessibleDescription = null;
            this.cndCalcMode.AccessibleName = null;
            resources.ApplyResources(this.cndCalcMode, "cndCalcMode");
            this.cndCalcMode.Autoaddblankitem = true;
            this.cndCalcMode.BackgroundImage = null;
            this.cndCalcMode.Conditionname = "CalcMode";
            this.cndCalcMode.Defaultselectedindex = 0;
            this.cndCalcMode.Font = null;
            this.cndCalcMode.Name = "cndCalcMode";
            this.cndCalcMode.Selectedindex = -1;
            this.cndCalcMode.Selectedname = null;
            this.cndCalcMode.Selectedvalue = null;
            // 
            // xdtpEffEedDate
            // 
            this.xdtpEffEedDate.AccessibleDescription = null;
            this.xdtpEffEedDate.AccessibleName = null;
            resources.ApplyResources(this.xdtpEffEedDate, "xdtpEffEedDate");
            this.xdtpEffEedDate.BackgroundImage = null;
            this.tblPanelG3.SetColumnSpan(this.xdtpEffEedDate, 2);
            this.xdtpEffEedDate.Font = null;
            this.xdtpEffEedDate.Name = "xdtpEffEedDate";
            this.xdtpEffEedDate.Value = new System.DateTime(2011, 9, 27, 16, 41, 7, 156);
            // 
            // commonToolStrip1
            // 
            this.commonToolStrip1.AccessibleDescription = null;
            this.commonToolStrip1.AccessibleName = null;
            this.commonToolStrip1.AddEnabled = true;
            this.commonToolStrip1.AddVisible = true;
            resources.ApplyResources(this.commonToolStrip1, "commonToolStrip1");
            this.commonToolStrip1.BackgroundImage = null;
            this.commonToolStrip1.CopyEnabled = true;
            this.commonToolStrip1.CopyVisible = true;
            this.commonToolStrip1.CsvEnabled = true;
            this.commonToolStrip1.CsvVisible = true;
            this.commonToolStrip1.DeleteEnabled = true;
            this.commonToolStrip1.DeleteVisible = true;
            this.commonToolStrip1.Displaytext = false;
            this.commonToolStrip1.ExitEnabled = true;
            this.commonToolStrip1.ExitVisible = true;
            this.commonToolStrip1.Font = null;
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
            // tblPanelG2
            // 
            this.tblPanelG2.AccessibleDescription = null;
            this.tblPanelG2.AccessibleName = null;
            resources.ApplyResources(this.tblPanelG2, "tblPanelG2");
            this.tblPanelG2.BackgroundImage = null;
            this.tblPanelG2.Controls.Add(this.pgvRateMs, 0, 0);
            this.tblPanelG2.Font = null;
            this.tblPanelG2.Name = "tblPanelG2";
            // 
            // pgvRateMs
            // 
            this.pgvRateMs.AccessibleDescription = null;
            this.pgvRateMs.AccessibleName = null;
            resources.ApplyResources(this.pgvRateMs, "pgvRateMs");
            this.pgvRateMs.BackgroundImage = null;
            this.pgvRateMs.Columninfolist = null;
            this.pgvRateMs.DataMember = "";
            this.pgvRateMs.DataSource = null;
            this.pgvRateMs.Font = null;
            this.pgvRateMs.Name = "pgvRateMs";
            this.pgvRateMs.Pagerhelper = null;
            // 
            // FrmExchangeRate
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = null;
            this.Controls.Add(this.tblPanelBase);
            this.Icon = null;
            this.Name = "FrmExchangeRate";
            this.ToolTipText = null;
            this.Load += new System.EventHandler(this.FrmExchangeRate_Load);
            this.tblPanelBase.ResumeLayout(false);
            this.tblPanelGrp.ResumeLayout(false);
            this.tblPanelGrp.PerformLayout();
            this.tblPanelG1.ResumeLayout(false);
            this.tblPanelG1.PerformLayout();
            this.tblPanelBtn.ResumeLayout(false);
            this.tblPanelG3.ResumeLayout(false);
            this.tblPanelG3.PerformLayout();
            this.tblPanelG2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblPanelBase;
        private System.Windows.Forms.TableLayoutPanel tblPanelGrp;
        private System.Windows.Forms.TableLayoutPanel tblPanelG1;
        private System.Windows.Forms.Label lblStar1;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.Button btnCompany;
        private System.Windows.Forms.Label lblCompanyNM;
        private System.Windows.Forms.Label lblRateKbn;
        private System.Windows.Forms.Label lblCurrKbn;
        private System.Windows.Forms.TableLayoutPanel tblPanelG3;
        private System.Windows.Forms.Label lblCalcMode;
        private System.Windows.Forms.Label lblValidDate;
        private System.Windows.Forms.Label lblCurrKbn1;
        private System.Windows.Forms.Label lblRateKbn1;
        private System.Windows.Forms.Label lblStar6;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Label lblStar4;
        private System.Windows.Forms.Label lblStar2;
        private System.Windows.Forms.Label lblStar3;
        private System.Windows.Forms.Label lblStar5;
        private System.Windows.Forms.TableLayoutPanel tblPanelBtn;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSearch;
        private ClsDetailCodeRefDropDownList.ClsDetailCodeRefDropDownList clsddl_9A;
        private Com.GainWinSoft.Common.Control.ConditionDropDownList.ConditionDropDownList cndCurrKbn_G3;
        private ClsDetailCodeRefDropDownList.ClsDetailCodeRefDropDownList clsddl_9A_G3;
        private Com.GainWinSoft.Common.Control.ConditionDropDownList.ConditionDropDownList cndCalcMode;
        private Com.GainWinSoft.Common.Control.CommonToolStrip.CommonToolStrip commonToolStrip1;
        private System.Windows.Forms.TableLayoutPanel tblPanelG2;
        private Com.GainWinSoft.Common.Control.PagerGridView.PagerGridView pgvRateMs;
        private Com.GainWinSoft.ERP.TableDropDownList.TableDropDownList tddlCurr;
        private System.Windows.Forms.TextBox txtRate;
        private Com.GainWinSoft.Common.Control.XDateTimePicker.XDateTimePicker xdtpEffEedDate;
    }
}
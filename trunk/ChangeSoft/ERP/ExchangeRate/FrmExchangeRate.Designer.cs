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
            this.tddlCurr_G3 = new Com.GainWinSoft.ERP.TableDropDownList.TableDropDownList();
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
            this.clsddl_9A_G3 = new ClsDetailCodeRefDropDownList.ClsDetailCodeRefDropDownList();
            this.cndCalcMode = new Com.GainWinSoft.Common.Control.ConditionDropDownList.ConditionDropDownList();
            this.xdtpEffEedDate = new Com.GainWinSoft.Common.Control.XDateTimePicker.XDateTimePicker();
            this.commonToolStrip1 = new Com.GainWinSoft.Common.Control.CommonToolStrip.CommonToolStrip();
            this.tblPanelG2 = new System.Windows.Forms.TableLayoutPanel();
            this.pgvRateMs = new Com.GainWinSoft.Common.Control.PagerGridView.PagerGridView();
            this.validationProvider1 = new Noogen.Validation.ValidationProvider(this.components);
            this.ntxtRate = new AMS.TextBox.NumericTextBox();
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
            resources.ApplyResources(this.tblPanelBase, "tblPanelBase");
            this.tblPanelBase.Controls.Add(this.tblPanelGrp, 0, 0);
            this.tblPanelBase.Name = "tblPanelBase";
            // 
            // tblPanelGrp
            // 
            resources.ApplyResources(this.tblPanelGrp, "tblPanelGrp");
            this.tblPanelGrp.Controls.Add(this.tblPanelG1, 0, 1);
            this.tblPanelGrp.Controls.Add(this.tblPanelG3, 0, 3);
            this.tblPanelGrp.Controls.Add(this.commonToolStrip1, 0, 0);
            this.tblPanelGrp.Controls.Add(this.tblPanelG2, 0, 2);
            this.tblPanelGrp.Name = "tblPanelGrp";
            // 
            // tblPanelG1
            // 
            resources.ApplyResources(this.tblPanelG1, "tblPanelG1");
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
            this.tblPanelG1.Name = "tblPanelG1";
            // 
            // lblCurrKbn
            // 
            resources.ApplyResources(this.lblCurrKbn, "lblCurrKbn");
            this.lblCurrKbn.Name = "lblCurrKbn";
            // 
            // lblCompanyNM
            // 
            resources.ApplyResources(this.lblCompanyNM, "lblCompanyNM");
            this.lblCompanyNM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCompanyNM.Name = "lblCompanyNM";
            // 
            // btnCompany
            // 
            resources.ApplyResources(this.btnCompany, "btnCompany");
            this.btnCompany.Name = "btnCompany";
            this.btnCompany.UseVisualStyleBackColor = true;
            // 
            // txtCompany
            // 
            resources.ApplyResources(this.txtCompany, "txtCompany");
            this.txtCompany.Name = "txtCompany";
            // 
            // lblStar1
            // 
            resources.ApplyResources(this.lblStar1, "lblStar1");
            this.lblStar1.ForeColor = System.Drawing.Color.Red;
            this.lblStar1.Name = "lblStar1";
            // 
            // lblCompany
            // 
            resources.ApplyResources(this.lblCompany, "lblCompany");
            this.lblCompany.Name = "lblCompany";
            // 
            // lblRateKbn
            // 
            resources.ApplyResources(this.lblRateKbn, "lblRateKbn");
            this.lblRateKbn.Name = "lblRateKbn";
            // 
            // tblPanelBtn
            // 
            resources.ApplyResources(this.tblPanelBtn, "tblPanelBtn");
            this.tblPanelBtn.Controls.Add(this.btnSearch, 2, 0);
            this.tblPanelBtn.Controls.Add(this.btnClear, 1, 0);
            this.tblPanelBtn.Name = "tblPanelBtn";
            // 
            // btnSearch
            // 
            resources.ApplyResources(this.btnSearch, "btnSearch");
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            resources.ApplyResources(this.btnClear, "btnClear");
            this.btnClear.Name = "btnClear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // clsddl_9A
            // 
            this.clsddl_9A.Autoaddblankitem = true;
            this.clsddl_9A.ClsCd = "9A";
            this.clsddl_9A.Defaultselectedindex = 0;
            resources.ApplyResources(this.clsddl_9A, "clsddl_9A");
            this.clsddl_9A.Name = "clsddl_9A";
            this.clsddl_9A.Selectedindex = -1;
            this.clsddl_9A.Selectedname = null;
            this.clsddl_9A.Selectedvalue = null;
            this.clsddl_9A.ShowNameDesc = false;
            // 
            // tddlCurr
            // 
            this.tddlCurr.Autoaddblankitem = true;
            this.tddlCurr.Defaultselectedindex = 0;
            resources.ApplyResources(this.tddlCurr, "tddlCurr");
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
            resources.ApplyResources(this.tblPanelG3, "tblPanelG3");
            this.tblPanelG3.Controls.Add(this.tddlCurr_G3, 2, 1);
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
            this.tblPanelG3.Controls.Add(this.clsddl_9A_G3, 2, 0);
            this.tblPanelG3.Controls.Add(this.cndCalcMode, 2, 3);
            this.tblPanelG3.Controls.Add(this.xdtpEffEedDate, 2, 2);
            this.tblPanelG3.Controls.Add(this.ntxtRate, 6, 3);
            this.tblPanelG3.Name = "tblPanelG3";
            // 
            // tddlCurr_G3
            // 
            this.tddlCurr_G3.Autoaddblankitem = true;
            this.tddlCurr_G3.Defaultselectedindex = 0;
            resources.ApplyResources(this.tddlCurr_G3, "tddlCurr_G3");
            this.tddlCurr_G3.LanguageColumn = null;
            this.tddlCurr_G3.LanguageFlg = false;
            this.tddlCurr_G3.Name = "tddlCurr_G3";
            this.tddlCurr_G3.NameColumn = "I_CURR_DESC";
            this.tddlCurr_G3.SelectedIndex = -1;
            this.tddlCurr_G3.Selectedname = null;
            this.tddlCurr_G3.Selectedvalue = null;
            this.tddlCurr_G3.TableNm = "T_CURR_MS";
            this.tddlCurr_G3.ValueColumn = "I_CURR_CD";
            // 
            // lblStar2
            // 
            resources.ApplyResources(this.lblStar2, "lblStar2");
            this.lblStar2.ForeColor = System.Drawing.Color.Red;
            this.lblStar2.Name = "lblStar2";
            // 
            // lblStar3
            // 
            resources.ApplyResources(this.lblStar3, "lblStar3");
            this.lblStar3.ForeColor = System.Drawing.Color.Red;
            this.lblStar3.Name = "lblStar3";
            // 
            // lblStar5
            // 
            resources.ApplyResources(this.lblStar5, "lblStar5");
            this.lblStar5.ForeColor = System.Drawing.Color.Red;
            this.lblStar5.Name = "lblStar5";
            // 
            // lblStar4
            // 
            resources.ApplyResources(this.lblStar4, "lblStar4");
            this.lblStar4.ForeColor = System.Drawing.Color.Red;
            this.lblStar4.Name = "lblStar4";
            // 
            // lblStar6
            // 
            resources.ApplyResources(this.lblStar6, "lblStar6");
            this.lblStar6.ForeColor = System.Drawing.Color.Red;
            this.lblStar6.Name = "lblStar6";
            // 
            // lblRate
            // 
            resources.ApplyResources(this.lblRate, "lblRate");
            this.lblRate.Name = "lblRate";
            // 
            // lblCalcMode
            // 
            resources.ApplyResources(this.lblCalcMode, "lblCalcMode");
            this.lblCalcMode.Name = "lblCalcMode";
            // 
            // lblValidDate
            // 
            resources.ApplyResources(this.lblValidDate, "lblValidDate");
            this.lblValidDate.Name = "lblValidDate";
            // 
            // lblCurrKbn1
            // 
            resources.ApplyResources(this.lblCurrKbn1, "lblCurrKbn1");
            this.lblCurrKbn1.Name = "lblCurrKbn1";
            // 
            // lblRateKbn1
            // 
            resources.ApplyResources(this.lblRateKbn1, "lblRateKbn1");
            this.lblRateKbn1.Name = "lblRateKbn1";
            // 
            // clsddl_9A_G3
            // 
            this.clsddl_9A_G3.Autoaddblankitem = true;
            this.clsddl_9A_G3.ClsCd = "9A";
            this.clsddl_9A_G3.Defaultselectedindex = 0;
            resources.ApplyResources(this.clsddl_9A_G3, "clsddl_9A_G3");
            this.clsddl_9A_G3.Name = "clsddl_9A_G3";
            this.clsddl_9A_G3.Selectedindex = -1;
            this.clsddl_9A_G3.Selectedname = null;
            this.clsddl_9A_G3.Selectedvalue = null;
            this.clsddl_9A_G3.ShowNameDesc = false;
            // 
            // cndCalcMode
            // 
            this.cndCalcMode.Autoaddblankitem = true;
            this.cndCalcMode.Conditionname = "CalcMode";
            this.cndCalcMode.Defaultselectedindex = 0;
            resources.ApplyResources(this.cndCalcMode, "cndCalcMode");
            this.cndCalcMode.Name = "cndCalcMode";
            this.cndCalcMode.Selectedindex = -1;
            this.cndCalcMode.Selectedname = null;
            this.cndCalcMode.Selectedvalue = null;
            // 
            // xdtpEffEedDate
            // 
            this.tblPanelG3.SetColumnSpan(this.xdtpEffEedDate, 2);
            resources.ApplyResources(this.xdtpEffEedDate, "xdtpEffEedDate");
            this.xdtpEffEedDate.Name = "xdtpEffEedDate";
            this.xdtpEffEedDate.Value = new System.DateTime(2011, 9, 27, 16, 41, 7, 156);
            // 
            // commonToolStrip1
            // 
            this.commonToolStrip1.AddEnabled = true;
            this.commonToolStrip1.AddVisible = true;
            resources.ApplyResources(this.commonToolStrip1, "commonToolStrip1");
            this.commonToolStrip1.CleargroupEnabled = true;
            this.commonToolStrip1.CleargroupVisible = true;
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
            // tblPanelG2
            // 
            resources.ApplyResources(this.tblPanelG2, "tblPanelG2");
            this.tblPanelG2.Controls.Add(this.pgvRateMs, 0, 0);
            this.tblPanelG2.Name = "tblPanelG2";
            // 
            // pgvRateMs
            // 
            this.pgvRateMs.Columninfolist = null;
            this.pgvRateMs.DataMember = "";
            this.pgvRateMs.DataSource = null;
            resources.ApplyResources(this.pgvRateMs, "pgvRateMs");
            this.pgvRateMs.Name = "pgvRateMs";
            this.pgvRateMs.Pagerhelper = null;
            // 
            // validationProvider1
            // 
            this.validationProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.BlinkIfDifferentError;
            resources.ApplyResources(this.validationProvider1, "validationProvider1");
            // 
            // ntxtRate
            // 
            this.ntxtRate.AllowNegative = true;
            this.ntxtRate.DigitsInGroup = 0;
            resources.ApplyResources(this.ntxtRate, "ntxtRate");
            this.ntxtRate.Flags = 0;
            this.ntxtRate.MaxDecimalPlaces = 4;
            this.ntxtRate.MaxWholeDigits = 9;
            this.ntxtRate.Name = "ntxtRate";
            this.ntxtRate.Prefix = "";
            this.ntxtRate.RangeMax = 1.7976931348623157E+308;
            this.ntxtRate.RangeMin = -1.7976931348623157E+308;
            // 
            // FrmExchangeRate
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblPanelBase);
            this.Name = "FrmExchangeRate";
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
        private ClsDetailCodeRefDropDownList.ClsDetailCodeRefDropDownList clsddl_9A_G3;
        private Com.GainWinSoft.Common.Control.ConditionDropDownList.ConditionDropDownList cndCalcMode;
        private Com.GainWinSoft.Common.Control.CommonToolStrip.CommonToolStrip commonToolStrip1;
        private System.Windows.Forms.TableLayoutPanel tblPanelG2;
        private Com.GainWinSoft.Common.Control.PagerGridView.PagerGridView pgvRateMs;
        private Com.GainWinSoft.ERP.TableDropDownList.TableDropDownList tddlCurr;
        private Com.GainWinSoft.Common.Control.XDateTimePicker.XDateTimePicker xdtpEffEedDate;
        private Noogen.Validation.ValidationProvider validationProvider1;
        private Com.GainWinSoft.ERP.TableDropDownList.TableDropDownList tddlCurr_G3;
        private AMS.TextBox.NumericTextBox ntxtRate;
    }
}
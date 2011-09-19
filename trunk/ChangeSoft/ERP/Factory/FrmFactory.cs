using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Com.GainWinSoft.Common;
using WeifenLuo.WinFormsUI.Docking;
using Com.GainWinSoft.Common.Vo;
using Noogen.Validation;

namespace Com.GainWinSoft.ERP.Factory
{
    public partial class FrmFactory : BaseContent
    {
        /// <summary>
        /// 画面操作模式
        /// </summary>
        private string strMode = "";
        /// <summary>
        /// 利用者情报
        /// </summary>
        private LoginUserInfoVo uservo;

        /// <summary>
        /// Check用Validation
        /// </summary>
        private ValidationProvider vdpRequireG1;
        private ValidationProvider vdpRequireG2;
        private ValidationProvider vdpExistG1;
        private ValidationProvider vdpExistG2;

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        public FrmFactory(DockPanel _parentdockpanel)
            : base(_parentdockpanel)
        {
            InitializeComponent();
        }

        #region 方法
        /// <summary>
        /// 画面加载初期化处理
        /// </summary>
        private void FrmFactory_Load(object sender, System.EventArgs e)
        {
            this.Initialize();
            this.Check_Init();
        }

        /// <summary>
        /// 初期化处理
        /// </summary>
        private void Initialize()
        {
            this.uservo = (LoginUserInfoVo)SessionUtils.GetSession(SessionUtils.COMMON_LOGIN_USER_INFO);
            if (string.IsNullOrEmpty(strMode))
            {
                this.strMode = Constant.MODE_ADD;
            }

            this.SetToolBar(this.strMode);
            this.SetLayout(this.strMode);
            this.removeAllClickEvent();
            this.addAllClickEvent();

            this.vdpRequireG1 = new ValidationProvider(this.components);
            this.vdpRequireG1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.BlinkIfDifferentError;
            this.vdpRequireG2 = new ValidationProvider(this.components);
            this.vdpRequireG2.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.BlinkIfDifferentError;
            this.vdpExistG1 = new ValidationProvider(this.components);
            this.vdpExistG1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.BlinkIfDifferentError;
            this.vdpExistG2 = new ValidationProvider(this.components);
            this.vdpExistG2.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.BlinkIfDifferentError;
        }

        /// <summary>
        /// 移除全部按钮的点击事件
        /// </summary>
        private void removeAllClickEvent()
        {
            this.commonToolStrip1.AddClick -= new EventHandler(commonToolStrip1_AddClick);
            this.commonToolStrip1.DeleteClick -= new EventHandler(commonToolStrip1_DeleteClick);
            this.commonToolStrip1.UpdateClick -= new EventHandler(commonToolStrip1_UpdateClick);
            this.commonToolStrip1.SaveClick -= new EventHandler(commonToolStrip1_SaveClick);
            this.commonToolStrip1.GobackClick -= new EventHandler(commonToolStrip1_GobackClick);
            this.commonToolStrip1.OkClick -= new EventHandler(commonToolStrip1_OkClick);
        }

        /// <summary>
        /// 添加全部按钮的点击事件
        /// </summary>
        private void addAllClickEvent()
        {
            this.commonToolStrip1.AddClick += new EventHandler(commonToolStrip1_AddClick);
            this.commonToolStrip1.DeleteClick += new EventHandler(commonToolStrip1_DeleteClick);
            this.commonToolStrip1.UpdateClick += new EventHandler(commonToolStrip1_UpdateClick);
            this.commonToolStrip1.SaveClick += new EventHandler(commonToolStrip1_SaveClick);
            this.commonToolStrip1.GobackClick += new EventHandler(commonToolStrip1_GobackClick);
            this.commonToolStrip1.OkClick += new EventHandler(commonToolStrip1_OkClick);
        }

        /// <summary>
        /// 确定按钮的点击事件
        /// </summary>
        private void commonToolStrip1_OkClick(object sender, EventArgs e)
        {
            if (!this.CheckCard())
            {
                return;
            }

            this.LoadData();
            this.SetLayoutG1G2();
        }

        /// <summary>
        /// 返回按钮的点击事件
        /// </summary>
        private void commonToolStrip1_GobackClick(object sender, EventArgs e)
        {
            this.SetLayoutG2G1();
        }

        /// <summary>
        /// 保存按钮的点击事件
        /// </summary>
        private void commonToolStrip1_SaveClick(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// 修改按钮的点击事件
        /// </summary>
        private void commonToolStrip1_UpdateClick(object sender, EventArgs e)
        {
            this.strMode = Constant.MODE_UPD;
            SetToolBar(this.strMode);
            SetLayout(this.strMode);
        }

        /// <summary>
        /// 删除按钮的点击事件
        /// </summary>
        private void commonToolStrip1_DeleteClick(object sender, EventArgs e)
        {
            this.strMode = Constant.MODE_DEL;
            SetToolBar(this.strMode);
            SetLayout(this.strMode);
        }

        /// <summary>
        /// 追加按钮的点击事件
        /// </summary>
        private void commonToolStrip1_AddClick(object sender, EventArgs e)
        {
            this.strMode = Constant.MODE_ADD;
            SetToolBar(this.strMode);
            SetLayout(this.strMode);
        }

        /// <summary>
        /// 工厂代码参照按钮的点击事件
        /// </summary>
        private void btnFactory_Click(object sender, EventArgs e)
        {
            CodeRef.CodeRefFactory cr = new CodeRef.CodeRefFactory(this.uservo.CompanyCondition.ICompanyCd);
            cr.AddValueControl(this.txtFactory);
            cr.ShowDialog(this);
        }
        #endregion

        #region 私有函数

        #region 工具栏控制相关
        /// <summary>
        /// 工具栏按钮显示控制
        /// <param name="strMode">画面模式</param>
        /// </summary>
        private void SetToolBar(string strMode)
        {
            InitToolBar();

            switch (strMode)
            {
                case Constant.MODE_ADD:
                    SetToolBarAdd();
                    break;
                case Constant.MODE_DEL:
                    SetToolBarDel();
                    break;
                case Constant.MODE_UPD:
                    SetToolBarUpd();
                    break;
            }
            this.commonToolStrip1.Update();
        }

        /// <summary>
        /// 工具栏按钮初期化
        /// </summary>
        private void InitToolBar()
        {
            #region 初期化
            this.commonToolStrip1.AddEnabled = true;
            this.commonToolStrip1.AddVisible = true;
            this.commonToolStrip1.DeleteEnabled = true;
            this.commonToolStrip1.DeleteVisible = true;
            this.commonToolStrip1.UpdateEnabled = true;
            this.commonToolStrip1.UpdateVisible = true;
            this.commonToolStrip1.SaveEnabled = false;
            this.commonToolStrip1.SaveVisible = false;
            this.commonToolStrip1.Line1Visible = false;

            this.commonToolStrip1.CopyEnabled = false;
            this.commonToolStrip1.CopyVisible = false;
            this.commonToolStrip1.Line2Visible = false;

            this.commonToolStrip1.ReportEnabled = false;
            this.commonToolStrip1.ReportVisible = false;
            this.commonToolStrip1.CsvEnabled = false;
            this.commonToolStrip1.CsvVisible = false;
            this.commonToolStrip1.Line3Visible = false;

            this.commonToolStrip1.GobackEnabled = false;
            this.commonToolStrip1.GobackVisible = false;
            this.commonToolStrip1.OkEnabled = false;
            this.commonToolStrip1.OkVisible = false;
            this.commonToolStrip1.ExitEnabled = false;
            this.commonToolStrip1.ExitVisible = false;
            this.commonToolStrip1.Line4Visible = false;

            this.commonToolStrip1.HelpEnabled = false;
            this.commonToolStrip1.HelpVisible = false;
            #endregion
        }

        /// <summary>
        /// 追加模式工具栏按钮控制
        /// </summary>
        private void SetToolBarAdd()
        {
            this.commonToolStrip1.SaveEnabled = true;
            this.commonToolStrip1.SaveVisible = true;
            this.commonToolStrip1.Line1Visible = false;
        }

        /// <summary>
        /// 删除模式工具栏按钮控制
        /// </summary>
        private void SetToolBarDel()
        {
            this.commonToolStrip1.Line1Visible = true;
            this.commonToolStrip1.OkEnabled = true;
            this.commonToolStrip1.OkVisible = true;
        }

        /// <summary>
        /// 修正模式工具栏按钮控制
        /// </summary>
        private void SetToolBarUpd()
        {
            this.commonToolStrip1.Line1Visible = true;
            this.commonToolStrip1.OkEnabled = true;
            this.commonToolStrip1.OkVisible = true;
        }

        /// <summary>
        /// G1->G2工具栏按钮控制
        /// </summary>
        private void SetToolBarG1G2()
        {
            this.commonToolStrip1.SaveEnabled = true;
            this.commonToolStrip1.SaveVisible = true;
            this.commonToolStrip1.GobackEnabled = true;
            this.commonToolStrip1.GobackVisible = true;
            this.commonToolStrip1.OkEnabled = false;
            this.commonToolStrip1.OkVisible = false;
        }

        /// <summary>
        /// G2->G1工具栏按钮控制
        /// </summary>
        private void SetToolBarG2G1()
        {
            this.commonToolStrip1.SaveEnabled = false;
            this.commonToolStrip1.SaveVisible = false;
            this.commonToolStrip1.GobackEnabled = false;
            this.commonToolStrip1.GobackVisible = false;
            this.commonToolStrip1.OkEnabled = true;
            this.commonToolStrip1.OkVisible = true;
        }
        #endregion

        #region 画面控件显示相关
        /// <summary>
        /// 根据模式，控制画面上的显示项目
        /// <param name="strMode">画面模式</param>
        /// </summary>
        private void SetLayout(string strMode)
        {
            this.ClearG1();
            this.ClearG2();
            switch (strMode)
            {
                case Constant.MODE_ADD:
                    this.SetLayoutAdd();
                    break;
                case Constant.MODE_DEL:
                    this.SetLayoutDel();
                    break;
                case Constant.MODE_UPD:
                    this.SetLayoutUpd();
                    break;
            }
        }

        /// <summary>
        /// 清空G1部分画面项目的显示内容
        /// </summary>
        private void ClearG1()
        {
            #region G1项目
            this.txtCompany.Text = "";
            this.lblCompanyNM.Text = "";
            this.txtFactory.Text = "";
            #endregion
        }

        /// <summary>
        /// 清空G2部分画面项目的显示内容
        /// </summary>
        private void ClearG2()
        {
            #region G2项目
            this.txtAbbreviation.Text = "";
            this.txtName.Text = "";
            this.txtPinyin.Text = "";
            this.txtZipCD.Text = "";
            this.cbbCountry.SelectedIndex = 0;
            this.txtAddress1.Text = "";
            this.txtAddress2.Text = "";
            this.txtAddress3.Text = "";
            this.txtTel.Text = "";
            this.txtFax.Text = "";
            this.cbbLanguage.SelectedIndex = 0;
            this.cbbTimezone.SelectedIndex = 0;
            this.txtBase.Text = "";
            this.txtDepart.Text = "";
            this.lblDepartNM.Text = "";
            this.cbbChange.Selectedindex = 0;
            this.txtAutoPeriod.Text = "";
            this.txtStockPeriod.Text = "";
            this.txtArrange.Text = "";
            this.cbbSafe.Selectedindex = 0;
            this.cbbRate.Selectedindex = 0;
            this.cbbPlan.Selectedindex = 0;
            this.cbbCost.Selectedindex = 0;
            this.cbbDecide.Selectedindex = 0;
            #endregion
        }

        /// <summary>
        /// 追加模式，控制画面上的显示项目
        /// </summary>
        private void SetLayoutAdd()
        {
            this.lblMode.Text = "追加模式";
            this.tpG2.Enabled = true;
            //this.tpG2.Visible = true;
        }

        /// <summary>
        /// 删除模式，控制画面上的显示项目
        /// </summary>
        private void SetLayoutDel()
        {
            this.lblMode.Text = "删除模式";
            this.tpG2.Enabled = false;
            //this.tpG2.Visible = false;
        }

        /// <summary>
        /// 修改模式，控制画面上的显示项目
        /// </summary>
        private void SetLayoutUpd()
        {
            this.lblMode.Text = "修改模式";
            this.tpG2.Enabled = false;
            //this.tpG2.Visible = false;
        }

        /// <summary>
        /// G1->G2，控制画面上的显示项目
        /// </summary>
        private void SetLayoutG1G2()
        {
            this.tpG1.Enabled = false;
            this.tpG2.Enabled = true;
            //this.tpG2.Visible = true;
        }

        /// <summary>
        /// G2->G1，控制画面上的显示项目
        /// </summary>
        private void SetLayoutG2G1()
        {
            this.ClearG2();
            this.tpG1.Enabled = true;
            this.tpG2.Enabled = false;
            //this.tpG2.Visible = false;
        }
        #endregion

        #region 各种Check
        /// <summary>
        /// 各种Check用Validation初期化
        /// </summary>
        private void Check_Init()
        {
            ValidationRule ruleCompany = new ValidationRule();
            ruleCompany.IsRequired = true;
            ruleCompany.RequiredFieldErroMessage = MessageUtils.GetMessage("W0001", this.lblCompany.Text);
            this.vdpRequireG1.SetValidationRule(this.txtCompany, ruleCompany);

            ValidationRule ruleFactory = new ValidationRule();
            ruleFactory.IsRequired = true;
            ruleFactory.RequiredFieldErroMessage = MessageUtils.GetMessage("W0001", this.lblFactory.Text);
            this.vdpRequireG1.SetValidationRule(this.txtFactory, ruleFactory);
        }

        private Boolean CheckCard()
        {
            Boolean rtnValue = true;

            if (!this.vdpRequireG1.Validate())
            {
                IList<MessageVo> re = this.vdpRequireG1.ValidationMessages(true);
                this.DialogResult = DialogResult.Abort;
                rtnValue = false;
            }

            return rtnValue;
        }
        #endregion

        #region 各种数据抽出
        /// <summary>
        /// 根据画面输入条件，抽出数据
        /// </summary>
        private void LoadData()
        {
        }
        #endregion

        #endregion
    }
}
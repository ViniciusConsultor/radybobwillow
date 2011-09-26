using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Com.GainWinSoft.Common;
using Com.GainWinSoft.ERP.Entity.Dao;
using Com.GainWinSoft.Common.Control.PagerGridView;
using System.Data.SqlClient;
using Com.GainWinSoft.Common.Office2007Renderer;
using System.Resources;
using WeifenLuo.WinFormsUI.Docking;
using Noogen.Validation;
using log4net;
using Com.GainWinSoft.ERP.CodeRef;
using Com.GainWinSoft.Common.Vo;
using Com.GainWinSoft.ERP.Material.Action;
using Com.GainWinSoft.ERP.Material.FormVo;

namespace Com.GainWinSoft.ERP.Material
{
    public partial class FrmMaterialSearch : BaseContent
    {
        private ResourceManager rm = new System.Resources.ResourceManager(typeof(FrmMaterialSearch));
        private static readonly ILog log = LogManager.GetLogger(typeof(FrmMaterialSearch));
        private LoginUserInfoVo uservo;

        //当前所在组
        private int currentGroup = 1;
        //画面打开时默认的组
        private int firstGroup = 1;

        /// <summary>
        /// 
        /// </summary>
        private ValidationProvider vdpG1;
        private ValidationProvider vdpBusinessG2;
        private ValidationProvider vdpBusinessG3;




        #region 构造体

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_parentdockpanel"></param>
        public FrmMaterialSearch(DockPanel _parentdockpanel)
            : base(_parentdockpanel)
        {
            InitializeComponent();
        }
        #endregion


        #region 画面事件

        private void FrmMaterialSearch_Load(object sender, EventArgs e)
        {
            Initialize();
            Check_Init();

        }

  


        private void btnInquiry_Click(object sender, EventArgs e)
        {
            //check group1
            if (!this.CheckG2())
            {
                return;
            }
            else
            {
                this.ClearError();
            }
            this.FrmMaterialSearch_pagerGridView1.Focus();
            //Data_Inquiry();
            currentGroup++;
            SetCommonToolstrip();
            SetGroupLayout();
        }


        private void FrmMaterialSearch_pagerGridView1_SelectionChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(this.FrmMaterialSearch_pagerGridView1.SelectedRowIndex.ToString()+":"+this.FrmMaterialSearch_pagerGridView1.SelecteRows.ToString());
        }
        #endregion

        #region 辅助按钮类

        /// <summary>
        /// 客户辅助按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCustomerHelper_Click(object sender, EventArgs e)
        {
            CodeRef.CodeRefTradeForMaterial cr = new CodeRef.CodeRefTradeForMaterial(uservo.CompanyCondition.ICompanyCd);
            cr.AddValueControl(this.txtCustomerCd);
            cr.AddNameControl(this.lblCustomer);
            cr.ShowDialog(this);
            this.txtCustomerCd.Focus();
        }
        /// <summary>
        /// 物料分类辅助按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnItemTypeHelper_Click(object sender, EventArgs e)
        {
            CodeRef.CodeRefClsDetail cr = new CodeRef.CodeRefClsDetail("79");
            cr.AddValueControl(this.txtItemType);
            cr.AddNameControl(this.lblItemType);
            cr.ShowDialog(this);
            this.txtItemType.Focus();

        }
        /// <summary>
        /// 供应商辅助按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMakerHelper_Click(object sender, EventArgs e)
        {
            CodeRef.CodeRefClsDetail cr = new CodeRef.CodeRefClsDetail("72");
            cr.AddValueControl(this.txtMakerCd);
            cr.AddNameControl(this.lblMakerNm);
            cr.ShowDialog(this);
            this.txtMakerCd.Focus();
        }

        /// <summary>
        /// 工厂辅助按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFactoryHelper_Click(object sender, EventArgs e)
        {

            CodeRef.CodeRefFactory cr = new CodeRef.CodeRefFactory(uservo.CompanyCondition.ICompanyCd);
            cr.AddValueControl(this.txtFactoryCd);
            cr.AddNameControl(this.lblFactoryNm);
            cr.ShowDialog(this);
            this.txtFactoryCd.Focus();

        }

        #endregion

        #region check方法
        /// <summary>
        /// Check ValidationProvider初始化
        /// </summary>
        private void Check_Init()
        {
            this.vdpG1 = new ValidationProvider(this.components);
            this.vdpG1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.BlinkIfDifferentError;
            this.vdpBusinessG2 = new ValidationProvider(this.components);
            this.vdpBusinessG2.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.BlinkIfDifferentError;
            this.vdpBusinessG3 = new ValidationProvider(this.components);
            this.vdpBusinessG3.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.BlinkIfDifferentError;


            ValidationRule ruleFactory = new ValidationRule();
            ruleFactory.IsRequired = true;
            ruleFactory.RequiredFieldErroMessage = MessageUtils.GetMessage("W0001", this.caplblFactory.Text);
            this.vdpG1.SetValidationRule(this.txtFactoryCd, ruleFactory);


            ValidationRule ruleFactoryExist = new ValidationRule();
            ruleFactoryExist.IsCustomError = true;
            ruleFactoryExist.CustomValidationMethod += new CustomValidationEventHandler(ruleFactoryExist_CustomValidationMethod);
            ruleFactoryExist.CustomErrorMessage = MessageUtils.GetMessage("W0004", this.caplblFactory.Text);
            this.vdpG1.SetValidationRule(this.txtFactoryCd, ruleFactoryExist);

            ValidationRule ruleCustomerExist = new ValidationRule();
            ruleCustomerExist.IsCustomError = true;
            ruleCustomerExist.CustomValidationMethod += new CustomValidationEventHandler(ruleCustomerExist_CustomValidationMethod);
            ruleCustomerExist.CustomErrorMessage = MessageUtils.GetMessage("W0004", this.caplblCustomer.Text);
            this.vdpBusinessG2.SetValidationRule(this.txtCustomerCd, ruleCustomerExist);

            ValidationRule ruleItemTypeExist = new ValidationRule();
            ruleItemTypeExist.IsCustomError = true;
            ruleItemTypeExist.CustomValidationMethod += new CustomValidationEventHandler(ruleItemTypeExist_CustomValidationMethod);
            ruleItemTypeExist.CustomErrorMessage = MessageUtils.GetMessage("W0004", this.caplblItemType.Text);
            this.vdpBusinessG2.SetValidationRule(this.txtItemType, ruleItemTypeExist);

            ValidationRule ruleMakerExist = new ValidationRule();
            ruleMakerExist.IsCustomError = true;
            ruleMakerExist.CustomValidationMethod += new CustomValidationEventHandler(ruleMakerExist_CustomValidationMethod);
            ruleMakerExist.CustomErrorMessage = MessageUtils.GetMessage("W0004", this.caplblMaker.Text);
            this.vdpBusinessG2.SetValidationRule(this.txtMakerCd, ruleMakerExist);

            ValidationRule ruleInquiry = new ValidationRule();
            ruleInquiry.IsCustomError = true;
            ruleInquiry.CustomValidationMethod += new CustomValidationEventHandler(ruleInquiry_CustomValidationMethod);
            ruleInquiry.CustomErrorMessage = MessageUtils.GetMessage("W0005");
            this.vdpBusinessG3.SetValidationRule(this.FrmMaterialSearch_pagerGridView1, ruleInquiry);




        }

        void ruleInquiry_CustomValidationMethod(object sender, CustomValidationEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            CardVo cardvo = new CardVo();
            cardvo.IFacCd = this.txtFactoryCd.Text;
            cardvo.IDispItemCd = this.txtDispItemCd.Text;
            cardvo.IDispItemRev = this.txtDispItemRev.Text;
            cardvo.IDlCd = this.txtCustomerCd.Text;
            cardvo.IDrwNo = this.txtDrwNo.Text;
            cardvo.IItemCls = this.cbbItemCls.Selectedvalue;
            cardvo.IItemType = this.txtItemType.Text;
            cardvo.IMakerCd = this.txtMakerCd.Text;
            cardvo.IMntCls = this.cbbMntCls.Selectedvalue;
            cardvo.IModel = this.txtModel.Text;
            cardvo.IQryMtrl = this.txtQryMtrl.Text;
            cardvo.ISeiban = this.txtSeiban.Text;
            cardvo.ISpec = this.txtSpec.Text;


            IAction_MaterialSearch action = ComponentLocator.Instance().Resolve<IAction_MaterialSearch>();
            int count = action.GetPmMsDetail(this.FrmMaterialSearch_pagerGridView1, cardvo);
            if (count == 0)
            {
                e.IsValid = false;
            }
            else
            {
                e.IsValid = true;
            }
            this.Cursor = Cursors.Default;
        }
        /// <summary>
        /// 清除CheckError
        /// </summary>
        private void ClearError()
        {
            this.vdpG1.ValidationMessages(false);
            this.vdpBusinessG2.ValidationMessages(false);
            this.vdpBusinessG3.ValidationMessages(false);
            this.baseform.msgwindow.Hide();
        }



        /// <summary>
        /// Group1各种Check
        /// </summary>
        private Boolean CheckG1()
        {
            Boolean rtnValue = true;

            if (!this.vdpG1.Validate())
            {
                IList<MessageVo> re = this.vdpG1.ValidationMessages(true);
                this.DialogResult = DialogResult.Abort;
                this.baseform.msgwindow.Messagelist = re;
                this.baseform.msgwindow.ShowMessage();
                rtnValue = false;
            }

            return rtnValue;
        }

        /// <summary>
        /// Group2各种Check
        /// </summary>
        private Boolean CheckG2()
        {
            Boolean rtnValue = true;

            if (!this.vdpBusinessG2.Validate())
            {
                IList<MessageVo> re = this.vdpBusinessG2.ValidationMessages(true);
                this.DialogResult = DialogResult.Abort;
                this.baseform.msgwindow.Messagelist = re;
                this.baseform.msgwindow.ShowMessage();
                rtnValue = false;
            }

            if (!this.vdpBusinessG3.Validate())
            {
                IList<MessageVo> re = this.vdpBusinessG3.ValidationMessages(true);
                this.DialogResult = DialogResult.Abort;
                this.baseform.msgwindow.Messagelist = re;
                this.baseform.msgwindow.ShowMessage();
                rtnValue = false;
            }

            return rtnValue;
        }




        #endregion

        #region 工具栏事件
        private void commonToolStrip1_ExitClick(object sender, EventArgs e)
        {
            this.CloseContent();
        }


        private void commonToolStrip1_GobackClick(object sender, EventArgs e)
        {
            ClearError();
            if (currentGroup == 2)
            {
                ClearG2();
            }
            if (currentGroup == 3)
            {
                IAction_MaterialSearch action = ComponentLocator.Instance().Resolve<IAction_MaterialSearch>();
                action.Init_GridView(this.FrmMaterialSearch_pagerGridView1);
            }
            currentGroup--;
            this.SetCommonToolstrip();
            this.SetGroupLayout();

        }



        /// <summary>
        /// OK按钮按下的时候根据当前不同的组做不同的事
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void commonToolStrip1_OkClick(object sender, EventArgs e)
        {
            if (currentGroup == 1)
            {
                //check group1
                if (!this.CheckG1())
                {
                    return;
                }
                else
                {
                    this.ClearError();
                }

            }
            if (currentGroup == 2)
            {
                //check group1
                if (!this.CheckG2())
                {
                    return;
                }
                else
                {
                    this.ClearError();
                }

                //Data_Inquiry();
                this.FrmMaterialSearch_pagerGridView1.Focus();
            }

            currentGroup++;
            this.SetCommonToolstrip();
            this.SetGroupLayout();
        }

        /// <summary>
        /// 添加按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void commonToolStrip1_AddClick(object sender, EventArgs e)
        {
            TransferTo();
        }
        /// <summary>
        /// 删除按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void commonToolStrip1_DeleteClick(object sender, EventArgs e)
        {
            TransferTo();
        }
        /// <summary>
        /// 修改按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void commonToolStrip1_UpdateClick(object sender, EventArgs e)
        {
            int d = this.FrmMaterialSearch_pagerGridView1.SelectedRowIndex;
            log.Info("FrmMaterialSearch_pagerGridView1.SelectedRowIndex: " + d);
            TransferTo();
        }





        #endregion

        #region 画面状态
        /// <summary>
        /// 控制组的状态
        /// </summary>
        public void SetGroupLayout()
        {
            if (currentGroup == 1)
            {
                this.tlpG1.Enabled = true;
                this.tlpG2.Enabled = false;
                this.tlpG3.Enabled = false;

            }

            if (currentGroup == 2)
            {
                this.tlpG1.Enabled = false;
                this.tlpG2.Enabled = true;
                this.tlpG3.Enabled = false;

            }
            if (currentGroup == 3)
            {
                this.tlpG1.Enabled = false;
                this.tlpG2.Enabled = false;
                this.tlpG3.Enabled = true;

            }

        }
        /// <summary>
        /// 根据组迁移不同，控制CommonToolStrip的状态
        /// </summary>
        public void SetCommonToolstrip()
        {
            if (currentGroup == 1)
            {
                this.commonToolStrip1.AddEnabled = false;
                this.commonToolStrip1.UpdateEnabled = false;
                this.commonToolStrip1.DeleteEnabled = false;
                this.commonToolStrip1.GobackEnabled = false;
                this.commonToolStrip1.OkEnabled = true;

            }

            if (currentGroup == 2 && firstGroup == 1)
            {
                this.commonToolStrip1.AddEnabled = true;
                this.commonToolStrip1.UpdateEnabled = false;
                this.commonToolStrip1.DeleteEnabled = false;
                this.commonToolStrip1.GobackEnabled = true;
                this.commonToolStrip1.OkEnabled = true;

            }
            if (currentGroup == 2 && firstGroup == 2)
            {
                this.commonToolStrip1.AddEnabled = true;
                this.commonToolStrip1.GobackEnabled = false;
                this.commonToolStrip1.UpdateEnabled = false;
                this.commonToolStrip1.DeleteEnabled = false;
                this.commonToolStrip1.OkEnabled = true;
            }

            if (currentGroup == 3)
            {
                this.commonToolStrip1.AddEnabled = true;
                this.commonToolStrip1.UpdateEnabled = true;
                this.commonToolStrip1.DeleteEnabled = true;
                this.commonToolStrip1.GobackEnabled = true;
                this.commonToolStrip1.OkEnabled = false;
            }

        }


        #endregion

        #region 其他私有方法


        /// <summary>
        /// 画面初始化
        /// </summary>
        private void Initialize()
        {
            ToolStripManager.Renderer = new Office2007Renderer();

            this.btnFactoryHelper.Image = (Image)Com.GainWinSoft.Common.ResourcesUtils.GetResource("AssistantButtonDownArrow");
            this.btnCustomerHelper.Image = (Image)Com.GainWinSoft.Common.ResourcesUtils.GetResource("AssistantButtonDownArrow");
            this.btnMakerHelper.Image = (Image)Com.GainWinSoft.Common.ResourcesUtils.GetResource("AssistantButtonDownArrow");
            this.btnItemTypeHelper.Image = (Image)Com.GainWinSoft.Common.ResourcesUtils.GetResource("AssistantButtonDownArrow");
            this.cbbItemCls.Selectedindex = 0;
            this.cbbMntCls.Selectedindex = 0;

            IAction_MaterialSearch action = ComponentLocator.Instance().Resolve<IAction_MaterialSearch>();
            action.Init_GridView(this.FrmMaterialSearch_pagerGridView1);

            uservo = (LoginUserInfoVo)SessionUtils.GetSession(SessionUtils.COMMON_LOGIN_USER_INFO);

            if (uservo.Factory != null)
            {
                FactoryVo factoryvo = uservo.Factory;
                this.txtFactoryCd.Text = factoryvo.IFacCd;
                this.lblFactoryNm.Text = factoryvo.IFacDesc;
                this.tlpG1.Enabled = false;
                this.tlpG2.Enabled = true;
                this.tlpG3.Enabled = false;
                this.txtCustomerCd.Focus();
                this.firstGroup = 2;
                this.currentGroup = 2;
            }
            else
            {
                this.tlpG1.Enabled = true;
                this.txtFactoryCd.Focus();
                this.firstGroup = 1;
                this.currentGroup = 1;
            }
            SetCommonToolstrip();
            SetGroupLayout();
        }

        private void ClearG2()
        {
            this.txtCustomerCd.Text = "";
            this.lblCustomer.Text = "";
            this.cbbItemCls.Selectedindex = 0;
            this.txtItemType.Text = "";
            this.lblItemType.Text = "";
            this.txtDispItemCd.Text = "";
            this.txtDispItemRev.Text = "";
            this.txtMakerCd.Text = "";
            this.lblMakerNm.Text = "";
            this.txtModel.Text = "";
            this.txtQryMtrl.Text = "";
            this.txtSeiban.Text = "";
            this.txtSpec.Text = "";
            this.txtDrwNo.Text = "";
            this.cbbMntCls.Selectedindex = 0;
        }

        /// <summary>
        /// 画面跳转到编辑画面
        /// </summary>
        private void TransferTo()
        {

            FrmMaterialEdit frmMaterialEdit = new FrmMaterialEdit(this.baseform.Parentdockpanel, this.baseform);
            ResourceManager fr = new ResourceManager(typeof(FrmMaterialEdit));
            frmMaterialEdit.DockTitle = frmMaterialEdit.Text;
            frmMaterialEdit.ShowContent(false);

        }

        /// <summary>
        /// 获取查询数据
        /// </summary>
        private void Data_Inquiry()
        {
            //IList<MessageVo> re = new List<MessageVo>();
            //MessageVo v = new MessageVo();
            //v.MessageType = "Warning";
            //v.ResultMessage = "ddddddddddd";
            //re.Add(v);
            //this.baseform.msgwindow.Messagelist = re;
            //this.baseform.msgwindow.ShowMessage();
//            this.Cursor = Cursors.WaitCursor;
//            CardVo cardvo = new CardVo();
//            cardvo.IFacCd = this.txtFactoryCd.Text;
//            cardvo.IDispItemCd = this.txtDispItemCd.Text;
//            cardvo.IDispItemRev = this.txtDispItemRev.Text;
//            cardvo.IDlCd = this.txtCustomerCd.Text;
//            cardvo.IDrwNo = this.txtDrwNo.Text;
//            cardvo.IItemCls = this.cbbItemCls.Selectedvalue;
//            cardvo.IItemType = this.txtItemType.Text;
//            cardvo.IMakerCd = this.txtMakerCd.Text;
//            cardvo.IMntCls = this.cbbMntCls.Selectedvalue;
//            cardvo.IModel = this.txtModel.Text;
//            cardvo.IQryMtrl = this.txtQryMtrl.Text;
//            cardvo.ISeiban = this.txtSeiban.Text;
//            cardvo.ISpec = this.txtSpec.Text;
//
//
//            IAction_MaterialSearch action = ComponentLocator.Instance().Resolve<IAction_MaterialSearch>();
//            action.GetPmMsDetail(this.FrmMaterialSearch_pagerGridView1, cardvo);
//            this.FrmMaterialSearch_pagerGridView1.Focus();
//
//            this.Cursor = Cursors.Default;
        }
        #endregion

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearG2();
        }



    }
}

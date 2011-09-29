using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//
using Com.GainWinSoft.Common;
using WeifenLuo.WinFormsUI.Docking;
using Com.GainWinSoft.ERP.ExchangeRate.FormVo;
using Com.GainWinSoft.ERP.ExchangeRate.Action;
using Com.GainWinSoft.Common.Vo;
using log4net;
using System.Resources;
namespace Com.GainWinSoft.ERP.ExchangeRate

{
    public partial class FrmExchangeRate : BaseContent
    {
        private ResourceManager rm = new System.Resources.ResourceManager(typeof(FrmExchangeRate));
        private static readonly ILog log = LogManager.GetLogger(typeof(FrmExchangeRate));

        IAction_FrmExchangeRate action = ComponentLocator.Instance().Resolve<IAction_FrmExchangeRate>();

        #region 画面用变量--------
        /// <summary>
        /// 画面操作模式
        /// </summary>
        private string strMode = "";
        /// <summary>
        /// 利用者情报
        /// </summary>
        private LoginUserInfoVo uservo =  (LoginUserInfoVo)SessionUtils.GetSession(SessionUtils.COMMON_LOGIN_USER_INFO);

        /// <summary>
        /// 当前组
        /// </summary>
        private int currentGroup = 1;
        /// <summary>
        /// 第一组
        /// </summary>
        private int firstGroup = 1;

        /// <summary>
        /// intResult
        /// </summary>
        private Int32 frmIntResult= 0;
        #endregion



        /// <summary>
        /// Check用Validation
        /// </summary>
        //private ValidationProvider vdpRequireG1;
        //private ValidationProvider vdpRequireG2;
        //private ValidationProvider vdpExistG1;
        //private ValidationProvider vdpExistG2;

        public FrmExchangeRate(DockPanel _parentdockpanel)
            : base(_parentdockpanel)
        {
            InitializeComponent();
        }

        private void FrmExchangeRate_Load(object sender, EventArgs e)
        {
            this.Initialize();
            //this.Check_Init();

        }


        /// <summary>
        /// 移除全部按钮的点击事件
        /// </summary>
        private void removeAllClickEvent()
        {
            this.commonToolStrip1.SaveClick -= new EventHandler(commonToolStrip1_SaveClick);

            this.commonToolStrip1.GobackClick -= new EventHandler(commonToolStrip1_GobackClick);
            this.commonToolStrip1.OkClick -= new EventHandler(commonToolStrip1_OkClick);

            this.btnClear.Click -= new EventHandler(btnClear_Click);

            this.btnSearch.Click -= new EventHandler(btnSearch_Click);
        }

        /// <summary>
        /// 添加全部按钮的点击事件
        /// </summary>
        private void addAllClickEvent()
        {

            this.commonToolStrip1.SaveClick += new EventHandler(commonToolStrip1_SaveClick);

            this.commonToolStrip1.GobackClick += new EventHandler(commonToolStrip1_GobackClick);
            this.commonToolStrip1.OkClick += new EventHandler(commonToolStrip1_OkClick);

            this.btnClear.Click += new EventHandler(btnClear_Click);

            this.btnSearch.Click += new EventHandler(btnSearch_Click);
            this.commonToolStrip1.UpdateClick += new EventHandler(pgvRateMs_DoubleClick);
            this.pgvRateMs.DoubleClick += new EventHandler(pgvRateMs_DoubleClick);

            this.commonToolStrip1.AddClick += new EventHandler(commonToolStrip1_AddClick); 
           
        }

        #region 初期化处理 Initialize
        /// <summary>
        /// 初期化处理
        /// </summary>
        private void Initialize()
        {
            

            //if (string.IsNullOrEmpty(strMode))
            //{
            //    this.strMode = Constant.MODE_ADD;
            //}

            this.removeAllClickEvent();
            this.addAllClickEvent();
            
            //
            this.ClearG1();
            this.ClearG2();
            this.ClearG3();

            
            this.SetGroupLayout();
            this.SetCommonToolstrip();
             
        }
        #endregion

        #region 控制组的状态GroupTrans
        /// <summary>
        /// 控制组的状态
        /// </summary>
        public void SetGroupLayout()
        {
            //this.tblPanelGrp.Enabled = false;
            this.txtCompany.Enabled = false;
            this.btnCompany.Enabled = false;
            
                                                
            #region GroupTrans
            if (currentGroup == 1)
            {
                this.tblPanelG1.Enabled = true;
                this.txtCompany.Text = uservo.Companyid;
                this.lblCompanyNM.Text = uservo.CompanyCondition.ICompanyDesc;
                this.tblPanelG2.Enabled = false;
                this.tblPanelG3.Enabled = false;

            }

            if (currentGroup == 2)
            {
                this.tblPanelG1.Enabled = false;
                this.tblPanelG2.Enabled = true;
                this.tblPanelG3.Enabled = false;

            }
            if (currentGroup == 3)
            {
                this.tblPanelG1.Enabled = false;
                this.tblPanelG2.Enabled = false;
                this.tblPanelG3.Enabled = true;

            }
            #endregion
        }
        #endregion




        #region 查询按钮 btnInquiry_Click
        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.Data_Inquiry();

            currentGroup++;
            SetCommonToolstrip();
            SetGroupLayout();
        }
        #endregion







        #region   Data_Inquiry
        private Boolean Data_Inquiry()
        {
            Boolean bolResult = false;
            this.Cursor = Cursors.WaitCursor;

            FrmExRateCardVo  cardvo = new FrmExRateCardVo();
            
            cardvo.ICompanyCd = this.txtCompany.Text;
            cardvo.IDlCurrCd = this.tddlCurr.Selectedvalue;
            cardvo.IRateCls = clsddl_9A.Selectedvalue;
            
            Int32 intRes  =  action.GetRateMsDetail(pgvRateMs,cardvo);

            if (intRes > 0)
            {

                bolResult = true;
            }

            
            this.Cursor = Cursors.Default;

            return bolResult;
        }
        #endregion

        #region 控制CommonToolStrip的状态
        /// <summary>
        /// 根据组迁移不同，控制CommonToolStrip的状态
        /// </summary>
        public void SetCommonToolstrip()
        {
            SetCommonToolstripFalse();

            if (currentGroup == firstGroup)
            {
                this.commonToolStrip1.AddEnabled = true;
                this.commonToolStrip1.OkEnabled = true;

            }else if (currentGroup == 3)
            {

                this.commonToolStrip1.GobackEnabled = true;
                
                this.commonToolStrip1.SaveEnabled = true;

            }else if (currentGroup == 2)
            {

                this.commonToolStrip1.AddEnabled = true;
                this.commonToolStrip1.OkEnabled = true;
                this.commonToolStrip1.UpdateEnabled = true;
                this.commonToolStrip1.DeleteEnabled = true;
                this.commonToolStrip1.GobackEnabled = true;
            }

        }

        public void SetCommonToolstripFalse()
        {
            this.commonToolStrip1.CsvEnabled = false;
            this.commonToolStrip1.CopyEnabled = false;
            this.commonToolStrip1.GobackEnabled = false;
            this.commonToolStrip1.UpdateEnabled = false;
            this.commonToolStrip1.DeleteEnabled = false;
            this.commonToolStrip1.SaveEnabled = false;
            this.commonToolStrip1.ReportEnabled = false;
            this.commonToolStrip1.OkEnabled = false;
            this.commonToolStrip1.AddEnabled = false;
            this.commonToolStrip1.GobackEnabled = false;
        }

        #endregion


        #region       保存按钮的点击事件
        private FrmExRateCardVo setFrom2Vo()
        {
            char chaZero = '0';
            FrmExRateCardVo frmExRateCardVo = new FrmExRateCardVo();

            frmExRateCardVo.ICompanyCd = this.txtCompany.Text;//公司代码
            frmExRateCardVo.IDlCurrCd = this.tddlCurr_G3.Selectedvalue; //结算货币
            frmExRateCardVo.ICnvMethod = this.cndCalcMode.Selectedvalue;
            frmExRateCardVo.IEffEndDate = Convert.ToDecimal(this.xdtpEffEedDate.Value.Year.ToString()
                                + this.xdtpEffEedDate.Value.Month.ToString().PadLeft(2, chaZero)  
                                + this.xdtpEffEedDate.Value.Day.ToString());//有效日
            frmExRateCardVo.IRate =Convert.ToDecimal(txtRate.Text);
            frmExRateCardVo.IRateCls = this.clsddl_9A_G3.Selectedvalue;
            

            return frmExRateCardVo;

        }



        /// <summary>
        /// 保存按钮的点击事件
        /// </summary>
        private void commonToolStrip1_SaveClick(object sender, EventArgs e)
        {


            FrmExRateCardVo frmExRateCardVo = setFrom2Vo();
            frmExRateCardVo.IMode = strMode;
                     

            action.InsExchangeRateStp(frmExRateCardVo);


            currentGroup = 2;
            this.SetCommonToolstrip();
            this.SetGroupLayout();
            Data_Inquiry();
            this.ClearG3();
            
            
            /*
            //this.ClearError();
            //this.ClearError();
            //this.SetToolBar(this.strMode);
            //this.SetLayout(this.strMode);
              */

        }
          #endregion


        #region       修改按钮的点击事件
        /// <summary>
        /// 修改按钮的点击事件
        /// </summary>
        private void commonToolStrip1_UpdateClick(object sender, EventArgs e)
        {
            this.strMode = Common.Constant.MODE_UPD;

            pgvRateMs_DoubleClick(sender, e);


        }
        #endregion

        #region       退出按钮的点击事件
        private void commonToolStrip1_ExitClick(object sender, EventArgs e)
        {
            this.CloseContent();
        }
        #endregion

        #region    追加按钮按下
        private void commonToolStrip1_AddClick(object sender, EventArgs e)
        {
            this.strMode = Common.Constant.MODE_ADD; 
            
            currentGroup = 3;
            this.SetCommonToolstrip();
            this.SetGroupLayout();

        }
        #endregion

        #region GroupTrans
        /// <summary>
        /// Cancel按钮按下的时候根据当前不同的组做不同的事
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void commonToolStrip1_GobackClick(object sender, EventArgs e)
        {
         //   ClearError();
            if (currentGroup == 2)
            {
                ClearG2();
                  
            }
            if (currentGroup == 3)
            {

                ClearG3();

                //if (pgvRateMs.RowCount == 0)
                //{
                //    currentGroup = 1;
                //    this.SetCommonToolstrip();
                //    this.SetGroupLayout();
                //    return;
                //}
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
                ////check group1
                //if (!this.CheckG1())
                //{
                //    return;
                //}
                //else
                //{
                //    this.ClearError();
                //}
                if (!Data_Inquiry())
                {
                    return;
                }



            }
            if (currentGroup == 2)
            {
                ////check group1
                //if (!this.CheckG2())
                //{
                //    return;
                //}
                //else
                //{
                //    this.ClearError();
                //}

                //Data_Inquiry();
                //this.FrmMaterialSearch_pagerGridView1.Focus();


                if (pgvRateMs.SelectedRowIndex >= 0)
                {
                    SetDetail2Form();
                }
               
               
            }

            currentGroup++;
            this.SetCommonToolstrip();
            this.SetGroupLayout();
        }
        #endregion

        #region 清除Grp的检索条件
        private void ClearG2()
        {
            action.Init_GridView(this.pgvRateMs);

        }

        private void ClearG1()
        {
            this.clsddl_9A.Selectedvalue = "";
            this.tddlCurr.Selectedvalue = "";
                   
        }

        private void ClearG3()
        {            
            xdtpEffEedDate.SetDefaultValue("");
            clsddl_9A_G3.Selectedvalue = "";
            tddlCurr_G3.Selectedvalue = "";
            cndCalcMode.Selectedvalue = "";
            this.txtRate.Text = "";
        }

       

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearG1();
        }

        #endregion

        #region datagridview操作

        private void SetDetail2Form()
        {

            DataGridViewRow row = this.pgvRateMs.SelecteRows[0];
           
            //汇率区分
            this.clsddl_9A_G3.Selectedvalue = row.Cells["I_RATE_CLS"].Value.ToString();


            this.tddlCurr_G3.Selectedvalue = row.Cells["I_DL_CURR_CD"].Value.ToString();

                                        
            this.xdtpEffEedDate.Value = Convert.ToDateTime(row.Cells["I_EFF_END_DATE"].Value);
            
            this.cndCalcMode.Selectedvalue = row.Cells["I_CNV_METHOD"].Value.ToString();
            this.txtRate.Text = row.Cells["I_RATE"].Value.ToString();




        }

        private void pgvRateMs_DoubleClick(object sender, EventArgs e)
        {

            this.strMode = Common.Constant.MODE_UPD;

            currentGroup++;
            this.SetCommonToolstrip();
            this.SetGroupLayout();

            SetDetail2Form();
        }

        #endregion

    }
}

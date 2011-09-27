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

        /// <summary>
        /// 画面操作模式
        /// </summary>
        private string strMode = "";
        /// <summary>
        /// 利用者情报
        /// </summary>
        private LoginUserInfoVo uservo;

        /// <summary>
        /// 当前组
        /// </summary>
        private int currentGroup = 1;
        /// <summary>
        /// 第一组
        /// </summary>
        private int firstGroup = 1;


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

            //this.Check_Init();
            this.Initialize();
            //ToolStripManager.Renderer = new Office2007Renderer();

            this.commonToolStrip1.UpdateClick += new EventHandler(commonToolStrip1_UpdateClick);
            this.commonToolStrip1.SaveClick += new EventHandler(commonToolStrip1_SaveClick);
            this.btnSearch.Click += new EventHandler(btnSearch_Click);
        }


        /// <summary>
        /// 移除全部按钮的点击事件
        /// </summary>
        private void removeAllClickEvent()
        {
            //this.commonToolStrip1.AddClick -= new EventHandler(commonToolStrip1_AddClick);
            //this.commonToolStrip1.DeleteClick -= new EventHandler(commonToolStrip1_DeleteClick);
            //this.commonToolStrip1.UpdateClick -= new EventHandler(commonToolStrip1_UpdateClick);
            //this.commonToolStrip1.SaveClick -= new EventHandler(commonToolStrip1_SaveClick);
            //this.commonToolStrip1.GobackClick -= new EventHandler(commonToolStrip1_GobackClick);
            //this.commonToolStrip1.OkClick -= new EventHandler(commonToolStrip1_OkClick);
        }

        /// <summary>
        /// 添加全部按钮的点击事件
        /// </summary>
        private void addAllClickEvent()
        {
            //this.commonToolStrip1.AddClick += new EventHandler(commonToolStrip1_AddClick);
            //this.commonToolStrip1.DeleteClick += new EventHandler(commonToolStrip1_DeleteClick);
            //this.commonToolStrip1.UpdateClick += new EventHandler(commonToolStrip1_UpdateClick);
            //this.commonToolStrip1.SaveClick += new EventHandler(commonToolStrip1_SaveClick);
            //this.commonToolStrip1.GobackClick += new EventHandler(commonToolStrip1_GobackClick);
            //this.commonToolStrip1.OkClick += new EventHandler(commonToolStrip1_OkClick);
        }

        #region 初期化处理 Initialize
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

            //this.SetToolBar(this.strMode);
            //this.SetLayout(this.strMode);
            
            /* for test
            this.removeAllClickEvent();
            this.addAllClickEvent();

            this.SetGroupLayout();
            this.SetCommonToolstrip();
             * */
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
                this.tblPanelG2.Enabled = false;
                this.tblPanelG3.Enabled = false;

            }

            if (currentGroup == 2)
            {
                this.tblPanelG1.Enabled = false;
                this.tblPanelG2.Enabled = true;
                this.tblPanelG3.Enabled = true;

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
        }
        #endregion

        #region   Data_Inquiry
        private void Data_Inquiry()
        {
            /*
            //IList<MessageVo> re = new List<MessageVo>();
            //MessageVo v = new MessageVo();
            //v.MessageType = "Warning";
            //v.ResultMessage = "ddddddddddd";
            //re.Add(v);
            //this.baseform.msgwindow.Messagelist = re;
            //this.baseform.msgwindow.ShowMessage();
           
            CardVo cardvo = new CardVo();
            cardvo.IFacCd = this.txtFactoryCd.Text;

            IAction_MaterialSearch action = ComponentLocator.Instance().Resolve<IAction_MaterialSearch>();
            action.GetPmMsDetail(this.FrmMaterialSearch_pagerGridView1, cardvo);
            this.FrmMaterialSearch_pagerGridView1.Focus();
                */
            this.Cursor = Cursors.WaitCursor;

            IAction_FrmExchangeRate action = ComponentLocator.Instance().Resolve<IAction_FrmExchangeRate>();
            FrmExRateCardVo  cardvo = new FrmExRateCardVo();
            cardvo.ICompanyCd = this.txtCompany.Text;
            cardvo.IDlCurrCd = "";
            cardvo.IRateCls = clsddl_9A.Selectedvalue;

             Int32 intRes  =  action.GetRateMsDetail(pgvRateMs,cardvo);

            
            this.Cursor = Cursors.Default;
        }
        #endregion

        #region 控制CommonToolStrip的状态
        /// <summary>
        /// 根据组迁移不同，控制CommonToolStrip的状态
        /// </summary>
        public void SetCommonToolstrip()
        {
            if (currentGroup == firstGroup)
            {
                this.commonToolStrip1.GobackEnabled = false;
                this.commonToolStrip1.UpdateEnabled = false;
                this.commonToolStrip1.DeleteEnabled = false;
                this.commonToolStrip1.OkEnabled = true;
            }

            if (currentGroup == 3)
            {
                this.commonToolStrip1.UpdateEnabled = true;
                this.commonToolStrip1.DeleteEnabled = true;
                this.commonToolStrip1.GobackEnabled = true;
                this.commonToolStrip1.OkEnabled = false;
            }
            if (currentGroup == 2 && firstGroup == 1)
            {
                this.commonToolStrip1.UpdateEnabled = false;
                this.commonToolStrip1.DeleteEnabled = false;
                this.commonToolStrip1.GobackEnabled = true;
                this.commonToolStrip1.OkEnabled = true;

            }

        }
        #endregion




        /// <summary>
        /// 保存按钮的点击事件
        /// </summary>
        private void commonToolStrip1_SaveClick(object sender, EventArgs e)
        {
            //this.ClearError();
        }

        /// <summary>
        /// 修改按钮的点击事件
        /// </summary>
        private void commonToolStrip1_UpdateClick(object sender, EventArgs e)
        {
            this.strMode = Constant.MODE_UPD;
            //this.ClearError();
            //this.SetToolBar(this.strMode);
            //this.SetLayout(this.strMode);
            FrmExRateCardVo frmExRateCardVo = new FrmExRateCardVo();

            frmExRateCardVo.ICompanyCd = "00";//公司代码
            frmExRateCardVo.IDlCurrCd = "01"; //结算货币
            frmExRateCardVo.ICnvMethod = "M";//转换方式
            frmExRateCardVo.IEffEndDate = Convert.ToDecimal("20111231");//有效日
            frmExRateCardVo.IRate = (decimal)1.1;
            frmExRateCardVo.IRateCls = "01";
            frmExRateCardVo.IEntryDate = DateTime.Now;
            frmExRateCardVo.IUpdDate = DateTime.Now;
            frmExRateCardVo.IUpdTimestamp = DateTime.Now.ToShortDateString();
                     

            Action_FrmExchangeRate action = new Action_FrmExchangeRate();
            action.InsExchangeRateStp(frmExRateCardVo);

        }


    }
}

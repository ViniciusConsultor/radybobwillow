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
namespace Com.GainWinSoft.ERP.ExchangeRate

{
    public partial class FrmExchangeRate : BaseContent
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
            this.commonToolStrip1.UpdateClick -= new EventHandler(commonToolStrip1_UpdateClick);
            this.commonToolStrip1.SaveClick -= new EventHandler(commonToolStrip1_SaveClick);
        }


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

            frmExRateCardVo.ICompanyCd = "";//公司代码
            frmExRateCardVo.IDlCurrCd = ""; //结算货币
            frmExRateCardVo.ICnvMethod = "";//转换方式
            frmExRateCardVo.IEffEndDate = "20111231";//有效日
            frmExRateCardVo.IRate = (decimal)1.1;
            frmExRateCardVo.IRateCls = "01";

            Action_FrmExchangeRate action = new Action_FrmExchangeRate();
            action.InsExchangeRateStp(frmExRateCardVo);

        }
    }
}

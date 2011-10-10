using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Com.GainWinSoft.ERP.MasterCheck;
using Noogen.Validation;
using Com.GainWinSoft.ERP.Entity;
using Com.GainWinSoft.Common;
using System.Windows.Forms;
using Com.GainWinSoft.ERP.Material.FormVo;
using Com.GainWinSoft.ERP.Material.Action;

namespace Com.GainWinSoft.ERP.Material
{
    public partial class FrmMaterialSearch 
    {
        /// <summary>
        /// 工厂代码存在Check
        /// </summary>
        private void ruleFactoryExist_CustomValidationMethod(object sender, CustomValidationEventArgs e)
        {

            CheckFactory check = new CheckFactory();
            this.lblFactoryNm.Text = "";
            TFactoryMs vo = check.Check01Vo(this.atxtFactoryCd.Text);
            if (vo != null && !String.IsNullOrEmpty(vo.IFacCd))
            {
                e.IsValid = true;
                this.lblFactoryNm.Text = vo.IFacArgDesc;
            }
            else
            {
                e.IsValid = false;
            }
        }

        /// <summary>
        /// 客户Check
        /// </summary>
        private void ruleCustomerExist_CustomValidationMethod(object sender, CustomValidationEventArgs e)
        {
                        if(string.IsNullOrEmpty(this.atxtCustomerCd.Text)){
                            return;
                        }

            CheckTrade check = new CheckTrade();
            this.lblCustomer.Text = "";
            TTradeMs vo = check.Check01Vo(this.uservo.CompanyCondition.ICompanyCd,this.atxtCustomerCd.Text);
            if (vo != null && vo.Id!=null)
            {
                e.IsValid = true;
                this.lblItemType.Text = vo.IDlArgDesc;
            }
            else
            {
                e.IsValid = false;
            }
        }

        /// <summary>
        /// 物料分类Check  "79"
        /// </summary>
        private void ruleItemTypeExist_CustomValidationMethod(object sender, CustomValidationEventArgs e)
        {
            if (string.IsNullOrEmpty(this.atxtItemType.Text))
            {
                return;
            }
            CheckCls check = new CheckCls();
            this.lblItemType.Text = "";
            CClsDetailNoAR vo = check.Check01Vo(LangUtils.GetCurrentLanguage(), "79", this.atxtItemType.Text);
            if (vo != null && !String.IsNullOrEmpty(vo.IClsDetailCd))
            {
                e.IsValid = true;
                this.lblItemType.Text = vo.IClsDetailDesc;
            }
            else
            {
                e.IsValid = false;
            }

        }

        /// <summary>
        /// 制造商Check "72"
        /// </summary>
        private void ruleMakerExist_CustomValidationMethod(object sender, CustomValidationEventArgs e)
        {
            if (string.IsNullOrEmpty(this.atxtMakerCd.Text))
            {
                return;
            }
            CheckCls check = new CheckCls();
            this.lblMakerNm.Text = "";
            CClsDetailNoAR vo = check.Check01Vo(LangUtils.GetCurrentLanguage(), "72", this.atxtMakerCd.Text);
            if (vo != null && !String.IsNullOrEmpty(vo.IClsDetailCd))
            {
                e.IsValid = true;
                this.lblMakerNm.Text = vo.IClsDetailDesc;
            }
            else
            {
                e.IsValid = false;
            }

        }

        /// <summary>
        /// 查询按钮按下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ruleInquiry_CustomValidationMethod(object sender, CustomValidationEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            CardVo cardvo = new CardVo();
            cardvo.IFacCd = this.atxtFactoryCd.Text;
            cardvo.IDispItemCd = this.atxtDispItemCd.Text;
            cardvo.IDispItemRev = this.atxtDispItemRev.Text;
            cardvo.IDlCd = this.atxtCustomerCd.Text;
            cardvo.IDrwNo = this.txtDrwNo.Text;
            cardvo.IItemCls = this.clsddlItemCls.Selectedvalue;
            cardvo.IItemType = this.atxtItemType.Text;
            cardvo.IMakerCd = this.atxtMakerCd.Text;
            cardvo.IMntCls = this.clsddlMntCls.Selectedvalue;
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
    }
}

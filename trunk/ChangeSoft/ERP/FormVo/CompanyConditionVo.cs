using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Com.GainWinSoft.ERP.FormVo
{
    public class CompanyConditionVo
    {

        #region Private Members
        private string iCompanyCd;

        private string iCoGroupCd;
        private string iCountryCd;
        private string iLanguageCd;
        private string iConditionCd;
        private string iCompanyArgDesc;
        private string iCompanyDesc;
        private string iCompanyDescKana;
        private string iMailNo;
        private string iAddress1;
        private string iAddress2;
        private string iAddress3;
        private string iTel;
        private string iFaxNo;
        private decimal iSalesClosingDate;
        private decimal iPurClosingDate;
        private string iNativeCurrCd;
        private string iDateType;
        private string iMultiFacCls;
        private string iTotalMstSetCls;
        private string iMrpChkFlg;
        private string iNatCurrFrcCls;
        private string iUpRefCls;
        private string iLvCtrlCls;
        private string iDataSavePath;
        private string iLoginUser;
        private string iLoginPswd;
        private string iDataSavePathPs;
        private string iLoginUserPs;
        private string iLoginPswdPs;
        private string iSalesCtrlCls;
        private string iSalesEmpCls;
        private string iSalesUnrealizedCtrlCls;
        private string iPurCtrlCls;
        private string iPurEmpCls;
        private string iPurOwedCtrlCls;
        private string iReserve1;
        private string iReserve2;
        private string iReserve3;
        private string iInqItem;
        private string iFcUpCls;

        #endregion

        #region property

        public string ICompanyCd
        {
            get { return iCompanyCd; }
            set { iCompanyCd = value; }
        }

        public string ICoGroupCd
        {
            get { return iCoGroupCd; }
            set { iCoGroupCd = value; }
        }
  
        public string ICountryCd
        {
            get { return iCountryCd; }
            set { iCountryCd = value; }
        }
      
        public string ILanguageCd
        {
            get { return iLanguageCd; }
            set { iLanguageCd = value; }
        }
      
        public string IConditionCd
        {
            get { return iConditionCd; }
            set { iConditionCd = value; }
        }
       
        public string ICompanyArgDesc
        {
            get { return iCompanyArgDesc; }
            set { iCompanyArgDesc = value; }
        }
 
        public string ICompanyDesc
        {
            get { return iCompanyDesc; }
            set { iCompanyDesc = value; }
        }

        public string ICompanyDescKana
        {
            get { return iCompanyDescKana; }
            set { iCompanyDescKana = value; }
        }
  
        public string IMailNo
        {
            get { return iMailNo; }
            set { iMailNo = value; }
        }
    
        public string IAddress1
        {
            get { return iAddress1; }
            set { iAddress1 = value; }
        }


        public string IAddress2
        {
            get { return iAddress2; }
            set { iAddress2 = value; }
        }
        public string IAddress3
        {
            get { return iAddress3; }
            set { iAddress3 = value; }
        }

        public string ITel
        {
            get { return iTel; }
            set { iTel = value; }
        }

        public string IFaxNo
        {
            get { return iFaxNo; }
            set { iFaxNo = value; }
        }

        public decimal ISalesClosingDate
        {
            get { return iSalesClosingDate; }
            set { iSalesClosingDate = value; }
        }

        public decimal IPurClosingDate
        {
            get { return iPurClosingDate; }
            set { iPurClosingDate = value; }
        }


        public string INativeCurrCd
        {
            get { return iNativeCurrCd; }
            set { iNativeCurrCd = value; }
        }
        public string IDateType
        {
            get { return iDateType; }
            set { iDateType = value; }
        }

        public string IMultiFacCls
        {
            get { return iMultiFacCls; }
            set { iMultiFacCls = value; }
        }

        public string ITotalMstSetCls
        {
            get { return iTotalMstSetCls; }
            set { iTotalMstSetCls = value; }
        }

        public string IMrpChkFlg
        {
            get { return iMrpChkFlg; }
            set { iMrpChkFlg = value; }
        }

        public string INatCurrFrcCls
        {
            get { return iNatCurrFrcCls; }
            set { iNatCurrFrcCls = value; }
        }

        public string IUpRefCls
        {
            get { return iUpRefCls; }
            set { iUpRefCls = value; }
        }

        public string ILvCtrlCls
        {
            get { return iLvCtrlCls; }
            set { iLvCtrlCls = value; }
        }

        public string IFcUpCls
        {
            get { return iFcUpCls; }
            set { iFcUpCls = value; }
        }

        public string IDataSavePath
        {
            get { return iDataSavePath; }
            set { iDataSavePath = value; }
        }

        public string ILoginUser
        {
            get { return iLoginUser; }
            set { iLoginUser = value; }
        }

        public string ILoginPswd
        {
            get { return iLoginPswd; }
            set { iLoginPswd = value; }
        }

        public string IDataSavePathPs
        {
            get { return iDataSavePathPs; }
            set { iDataSavePathPs = value; }
        }

        public string ILoginUserPs
        {
            get { return iLoginUserPs; }
            set { iLoginUserPs = value; }
        }


        public string ILoginPswdPs
        {
            get { return iLoginPswdPs; }
            set { iLoginPswdPs = value; }
        }
        public string ISalesCtrlCls
        {
            get { return iSalesCtrlCls; }
            set { iSalesCtrlCls = value; }
        }


        public string ISalesEmpCls
        {
            get { return iSalesEmpCls; }
            set { iSalesEmpCls = value; }
        }
        public string ISalesUnrealizedCtrlCls
        {
            get { return iSalesUnrealizedCtrlCls; }
            set { iSalesUnrealizedCtrlCls = value; }
        }

        public string IPurCtrlCls
        {
            get { return iPurCtrlCls; }
            set { iPurCtrlCls = value; }
        }

        public string IPurEmpCls
        {
            get { return iPurEmpCls; }
            set { iPurEmpCls = value; }
        }

        public string IPurOwedCtrlCls
        {
            get { return iPurOwedCtrlCls; }
            set { iPurOwedCtrlCls = value; }
        }

        public string IReserve1
        {
            get { return iReserve1; }
            set { iReserve1 = value; }
        }

        public string IReserve2
        {
            get { return iReserve2; }
            set { iReserve2 = value; }
        }

        public string IReserve3
        {
            get { return iReserve3; }
            set { iReserve3 = value; }
        }

        public string IInqItem
        {
            get { return iInqItem; }
            set { iInqItem = value; }
        }

        #endregion




    }
}

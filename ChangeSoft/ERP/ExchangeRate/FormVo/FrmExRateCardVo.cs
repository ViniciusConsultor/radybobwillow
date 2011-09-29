using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Com.GainWinSoft.ERP.ExchangeRate.FormVo
{
    [Serializable]
    public class FrmExRateCardVo
    {

        private string iMode;      //公司代碼

        private string iCompanyCd;      //公司代碼
        private string iRateCls;        //匯率區分
        private string iDlCurrCd;       // 結算貨幣
        private decimal iEffEndDate;    //有效終了日

        private decimal iRate;          //匯率
        private string iCnvMethod;      //轉換方法
        private DateTime iEntryDate;    //登陸日
        private DateTime iUpdDate;      //更新日
        private string iUpdTimestamp;   //時間戳




        #region Public Properties

        public string IMode
        {
            get { return iMode; }
            set { iMode = value; }
        }


        public string ICompanyCd
        {
            get { return iCompanyCd; }
            set { iCompanyCd = value; }
        }

        public string IRateCls
        {
            get { return iRateCls; }
            set { iRateCls = value; }
        }

        public string IDlCurrCd
        {
            get { return iDlCurrCd; }
            set { iDlCurrCd = value; }
        }

        public decimal IEffEndDate
        {
            get { return iEffEndDate; }
            set { iEffEndDate = value; }
        }

        public decimal IRate
        {
            get { return iRate; }
            set { iRate = value; }
        }

        public string ICnvMethod
        {
            get { return iCnvMethod; }
            set { iCnvMethod = value; }
        }

        public System.DateTime IEntryDate
        {
            get { return iEntryDate; }
            set { iEntryDate = value; }
        }

        public System.DateTime IUpdDate
        {
            get { return iUpdDate; }
            set { iUpdDate = value; }
        }

        public string IUpdTimestamp
        {
            get { return iUpdTimestamp; }
            set { iUpdTimestamp = value; }
        }

        #endregion
    }
}

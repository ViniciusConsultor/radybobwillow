using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Com.GainWinSoft.ERP.ExchangeRate.FormVo
{
    [Serializable]
    public class FrmExRateCardVo
    {

        private string iCompanyCd;      //公司代碼
        private string iRateCls;        //匯率區分
        private string iDlCurrCd;       // 結算貨幣
        private decimal iEffEndDate;    //有效終了日

        private decimal iRate;          //匯率
        private string iCnvMethod;      //轉換方法
        private DateTime iEntryDate;    //登陸日
        private DateTime iUpdDate;      //更新日
        private string iUpdTimestamp;   //時間戳







    }
}

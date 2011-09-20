using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Com.GainWinSoft.ERP.ExchangeRate.FormVo
{
    [Serializable]
    public class FrmExRateDetailVo
    {
        private string iCompanyCd;      //公司代碼
        private string iRateCls;        //匯率區分
        private string iRateClsDesc;    //匯率區分名


        private string iDlCurrCd;       // 結算貨幣
        private decimal iEffEndDate;    //有效終了日

        private decimal iRate;          //匯率
        private string iCnvMethod;      //轉換方法
        private string iCnvMethodDesc;  //匯率區分名

        private string iEntryDate;      //登陸日
        private string iUpdDate;        //更新日
        private string iUpdTimestamp;   //時間戳


    }
}

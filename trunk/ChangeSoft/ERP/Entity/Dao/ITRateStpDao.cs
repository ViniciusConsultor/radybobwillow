using System;
using System.Collections.Generic;
namespace Com.GainWinSoft.ERP.Entity.Dao
{
    public interface ITRateStpDao
    {
        //IList<Com.GainWinSoft.ERP.Entity.TRateStp> GetDetail(string langId, string langColumn, string talbeNm, string valueColumn, string nameColumn);
        //IList<Com.GainWinSoft.ERP.Entity.CTableDropDownListNoAR> GetDetail(string talbeNm, string valueColumn, string nameColumn);

        Boolean InsTRateStp(TRateStp trateStpModel);

    }
}

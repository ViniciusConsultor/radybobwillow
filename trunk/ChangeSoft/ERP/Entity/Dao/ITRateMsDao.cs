using System;
using System.Collections.Generic;
namespace Com.GainWinSoft.ERP.Entity.Dao
{
    public interface ITRateMsDao
    {
        //IList<Com.GainWinSoft.ERP.Entity.TRateStp> GetDetail(string langId, string langColumn, string talbeNm, string valueColumn, string nameColumn);
        //IList<Com.GainWinSoft.ERP.Entity.CTableDropDownListNoAR> GetDetail(string talbeNm, string valueColumn, string nameColumn);

        //Com.GainWinSoft.ERP.Entity.TRateMs getFactoryByCd(string facCd);
        IList<Com.GainWinSoft.ERP.Entity.TRateMs> getTRateMs(string companyCd, string facCd, string facNm);

    }
}

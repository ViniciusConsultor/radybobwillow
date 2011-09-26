using System;
namespace Com.GainWinSoft.ERP.Entity.Dao
{
    public interface ITTradeMsDao
    {
        Com.GainWinSoft.ERP.Entity.TTradeMs getTradeByCd(string companyCd, string dlCd);
    }
}

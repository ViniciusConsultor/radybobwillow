using System;
namespace Com.GainWinSoft.ERP.Entity.Dao
{
    public interface ICTPmMsNoARDao
    {
        System.Collections.Generic.IList<Com.GainWinSoft.ERP.Entity.CTPmMsNoAR> GetPmMsDetail(Com.GainWinSoft.Common.SearchCondition condition, bool allFactory);
    }
}

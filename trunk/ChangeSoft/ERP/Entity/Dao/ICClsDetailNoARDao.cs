using System;
namespace Com.GainWinSoft.ERP.Entity.Dao
{
    public  interface ICClsDetailNoARDao
    {
        System.Collections.Generic.IList<Com.GainWinSoft.ERP.Entity.CClsDetailNoAR> GetClsDetail(string langId, string clsCd);
    }
}

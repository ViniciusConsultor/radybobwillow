using System;
namespace Com.GainWinSoft.ERP.Entity.Dao
{
    public  interface ICCatalogFunctionNoARDao
    {
        System.Collections.Generic.IList<Com.GainWinSoft.ERP.Entity.CCatalogFunctionNoAR> GetCatalogFunctionByUserId(string langid,string userid);
    }
}

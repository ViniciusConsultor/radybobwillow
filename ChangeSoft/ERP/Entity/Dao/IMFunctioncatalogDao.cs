using System;
namespace Com.GainWinSoft.ERP.Entity.Dao
{
    public interface IMFunctioncatalogDao
    {
        System.Collections.Generic.IList<Com.GainWinSoft.ERP.Entity.MFunctioncatalog> GetFunctionCatalogList(String langid);
    }
}

using System;
namespace Com.ChangeSoft.ERP.Entity.Dao
{
    public interface IMFunctioncatalogDao
    {
        System.Collections.Generic.IList<Com.ChangeSoft.ERP.Entity.MFunctioncatalog> GetFunctionCatalogList(String langid);
    }
}

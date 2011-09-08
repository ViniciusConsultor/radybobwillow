using System;
namespace Com.GainWinSoft.ERP.Entity.Dao
{
    public interface ICCatalogHasManyFunctionDao
    {
        System.Collections.Generic.IList<Com.GainWinSoft.ERP.Entity.CCatalogHasManyFunction> GetFunctionAllList(string langid);
    }
}

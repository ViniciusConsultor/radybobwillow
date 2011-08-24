using System;
namespace Com.ChangeSoft.ERP.Entity.Dao
{
    public interface ICFunctionAllDao
    {
        System.Collections.Generic.IList<Com.ChangeSoft.ERP.Entity.CFunctionAll> GetFunctionAllList(string langid);
    }
}

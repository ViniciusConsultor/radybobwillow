using System;
namespace Com.GainWinSoft.ERP.Entity.Dao
{
    public interface ICFunctionAllDao
    {
        System.Collections.Generic.IList<Com.GainWinSoft.ERP.Entity.CFunctionAll> GetFunctionAllList(string langid);
    }
}

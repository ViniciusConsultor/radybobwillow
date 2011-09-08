using System;
namespace Com.GainWinSoft.ERP.Entity.Dao
{
    public interface ICClsMsAllDao
    {
        System.Collections.Generic.IList<Com.GainWinSoft.ERP.Entity.CClsMsAll> GetClsMsAllList(string iClsCd, string iLanguageCd);
    }
}

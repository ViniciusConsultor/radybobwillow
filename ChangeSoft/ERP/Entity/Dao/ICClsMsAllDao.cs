using System;
namespace Com.ChangeSoft.ERP.Entity.Dao
{
    public interface ICClsMsAllDao
    {
        System.Collections.Generic.IList<Com.ChangeSoft.ERP.Entity.CClsMsAll> GetClsMsAllList(string iClsCd, string iLanguageCd);
    }
}

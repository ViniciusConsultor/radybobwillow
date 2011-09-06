using System;
namespace Com.ChangeSoft.ERP.Entity.Dao
{
    public interface ITDescMsDao
    {
        System.Collections.Generic.IList<Com.ChangeSoft.ERP.Entity.TDescMs> GetTDescMsList(string iClsCd, string iLanguageCd);
    }
}

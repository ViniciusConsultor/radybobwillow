using System;
namespace Com.ChangeSoft.ERP.Entity.Dao
{
    interface ITDescMsDao
    {
        System.Collections.Generic.IList<Com.ChangeSoft.ERP.Entity.TDescMs> GetTDescMsList(string iClsCd, string iLanguageCd);
    }
}

using System;
namespace Com.GainWinSoft.ERP.Entity.Dao
{
    public interface ITDescMsDao
    {
        System.Collections.Generic.IList<Com.GainWinSoft.ERP.Entity.TDescMs> GetTDescMsList(string iClsCd, string iLanguageCd);
    }
}

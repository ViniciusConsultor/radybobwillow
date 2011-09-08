using System;
namespace Com.GainWinSoft.ERP.Entity.Dao
{
    public interface ICClsDetailBelongToClsMsDao
    {
        System.Collections.Generic.IList<Com.GainWinSoft.ERP.Entity.CClsDetailBelongToClsMs> GetClsMsAllList(string iClsCd, string iLanguageCd);
    }
}

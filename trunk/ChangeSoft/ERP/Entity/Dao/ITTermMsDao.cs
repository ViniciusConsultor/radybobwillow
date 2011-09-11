using System;
namespace Com.GainWinSoft.ERP.Entity.Dao
{
    public interface ITTermMsDao
    {
        Com.GainWinSoft.ERP.Entity.TTermMs getTermbyUserId(string userid);
    }
}

using System;
namespace Com.GainWinSoft.ERP.Entity.Dao
{
    public interface ITPersonMsDao
    {
        Com.GainWinSoft.ERP.Entity.TPersonMs getPersonByUserId(string userId);
    }
}

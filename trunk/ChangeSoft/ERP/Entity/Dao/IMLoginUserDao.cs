using System;
namespace Com.GainWinSoft.ERP.Entity.Dao
{
    public interface IMLoginUserDao
    {
        Com.GainWinSoft.ERP.Entity.MLoginUser GetLoginUserInfo(string userid, string password);
    }
}

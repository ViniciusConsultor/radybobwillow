using System;
namespace Com.GainWinSoft.ERP.Action
{
    interface IAction_LoginForm
    {
        Com.GainWinSoft.Common.Vo.LoginUserInfoVo GetLoginUserList(string userid, string password);
    }
}

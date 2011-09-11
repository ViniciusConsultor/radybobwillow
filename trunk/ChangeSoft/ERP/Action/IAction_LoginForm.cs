using System;
namespace Com.GainWinSoft.ERP.Action
{
    interface IAction_LoginForm
    {
        Com.GainWinSoft.ERP.FormVo.LoginUserInfoVo GetLoginUserList(string userid, string password);
    }
}

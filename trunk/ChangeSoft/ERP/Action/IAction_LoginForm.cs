using System;
namespace Com.GainWinSoft.ERP.Action
{
    interface IAction_LoginForm
    {
        System.Collections.Generic.IList<Com.GainWinSoft.ERP.FormVo.LoginUserInfoVo> GetLoginUserList(string userid, string password);
    }
}

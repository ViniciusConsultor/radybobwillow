using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net;
using Com.GainWinSoft.Common;
using Com.GainWinSoft.ERP.Entity.Dao;
using System.Collections;
using Com.GainWinSoft.ERP.Entity;
using System.Threading;
using Com.GainWinSoft.Common.Vo;


namespace Com.GainWinSoft.ERP.Action
{
    public class Action_LoginForm : Com.GainWinSoft.Common.IBaseAction, Com.GainWinSoft.ERP.Action.IAction_LoginForm
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Action_MainForm));

        public LoginUserInfoVo GetLoginUserList(string userid,string password)
        {

           LoginUserInfoVo result =null;

            IMLoginUserDao ml = ComponentLocator.Instance().Resolve<IMLoginUserDao>();
            MLoginUser  loginuser= ml.GetLoginUserInfo(userid, password);
            if ((loginuser != null))
            {


                 result = new LoginUserInfoVo();
                 result.Companyid = loginuser.Companyid;
                 result.Deleteflag = loginuser.Deleteflag;
                 result.Lockflag = loginuser.Lockflag;
                 result.Mappingid = loginuser.Mappingid;
                 result.Namepinyin = loginuser.Namepinyin;
                 result.Password = loginuser.Password;
                 result.Temppasswordflag = loginuser.Temppasswordflag;
                 result.Userid = loginuser.Userid;
                 result.Username = loginuser.Username;
                 result.Usertype = loginuser.Usertype;

                
            }

            return result;

        }
    }
}

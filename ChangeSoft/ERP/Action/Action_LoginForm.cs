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
using Com.GainWinSoft.ERP.FormVo;


namespace Com.GainWinSoft.ERP.Action
{
    public class Action_LoginForm : Com.GainWinSoft.Common.IBaseAction, Com.GainWinSoft.ERP.Action.IAction_LoginForm
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Action_MainForm));

        public IList<LoginUserInfoVo> GetLoginUserList(string userid,string password)
        {

            IList<LoginUserInfoVo> result = new List<LoginUserInfoVo>();

            IMLoginUserDao ml = ComponentLocator.Instance().Resolve<IMLoginUserDao>();
            IList<MLoginUser>  loginuserlist = ml.GetLoginUserInfo(userid, password);
            if ((loginuserlist.Count != 0))
            {



                foreach (MLoginUser mloginuser in loginuserlist)
                {
                    LoginUserInfoVo lvo = new LoginUserInfoVo();
                    lvo.Companyid = mloginuser.Companyid;
                    lvo.Deleteflag = mloginuser.Deleteflag;
                    lvo.Lockflag = mloginuser.Lockflag;
                    lvo.Mappingid = mloginuser.Mappingid;
                    lvo.Namepinyin = mloginuser.Namepinyin;
                    lvo.Password = mloginuser.Password;
                    lvo.Rolefunctionlist = new List<FunctionVo>();
                    lvo.Roleuserlist = new List<RoleUserVo>();
                    lvo.Temppasswordflag = mloginuser.Temppasswordflag;
                    lvo.Userid = mloginuser.Userid;
                    lvo.Username = mloginuser.Username;
                    lvo.Usertype = mloginuser.Usertype;
                    result.Add(lvo);
                }
            }

            return result;

        }
    }
}

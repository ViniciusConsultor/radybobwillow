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

namespace Com.GainWinSoft.ERP.Factory.Action
{
    public class Action_Factory : Com.GainWinSoft.Common.IBaseAction, Com.GainWinSoft.ERP.Factory.Action.IAction_Factory
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Action_Factory));

        public TFactoryMs GetFactoryByCd(String facCd)
        {
            TFactoryMs facVo = new TFactoryMs();
            ITFactoryMsDao td = ComponentLocator.Instance().Resolve<ITFactoryMsDao>();
            facVo = td.getFactoryByCd(facCd);

            return facVo;
        }

        public Boolean SaveDataToStp(String strMode, TFactoryMs facVo)
        {
            Boolean rtnValue = true;
            LoginUserInfoVo uservo = (LoginUserInfoVo)SessionUtils.GetSession(SessionUtils.COMMON_LOGIN_USER_INFO);

            TFcConditionStp facStp = new TFcConditionStp();

            PropertiesCopier.CopyProperties(facVo, facStp);
            facStp.Id.IJournalNo = 10001;
            facStp.Id.ICompanyCd = facVo.ICompanyCd;
            facStp.IPrcsCls = CommonUtil.GET_I_PRCS_CLS(strMode);
            facStp.IUserId = uservo.Userid;
            facStp.IPrcsDate = DateTime.Now;
            facStp.IPrcsTime = DateTime.Now.ToShortTimeString();
            facStp.IUpdCls = "";

            return rtnValue;
        }
    }
}

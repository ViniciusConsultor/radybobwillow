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
            facStp.IUpdCls = "0";

            facStp.IConditionCd = "000001";
            //facStp.IDlCurrCd = card.C4_DL_CURR_CD;//取引通貨
            facStp.IDelWhInCd = "";
            facStp.IDelWhOutCd = "";
            facStp.IRjtWhCd = "";
            facStp.INonAllocLocation = "";
            facStp.IOsWhCd = "";
            facStp.IInspectonLocation = "";
            facStp.IPlanCycCls = CommonUtil.NullToSpace(facStp.IPlanCycCls);
            facStp.IWkTime = CommonUtil.NullToZero(facStp.IWkTime);
            facStp.IPoCreateCls = CommonUtil.NullToSpace(facStp.IPoCreateCls);
            facStp.ISalesCls = CommonUtil.NullToSpace(facStp.ISalesCls);
            facStp.IPoSlcCls = CommonUtil.NullToSpace(facStp.IPoSlcCls);
            facStp.IMrpCls = CommonUtil.NullToSpace(facStp.IMrpCls);
            facStp.ILinkFlg = CommonUtil.NullToSpace(facStp.ILinkFlg);
            facStp.IShipInvCls = CommonUtil.NullToSpace(facStp.IShipInvCls);
            facStp.IAcpInvCls = CommonUtil.NullToSpace(facStp.IAcpInvCls);
            facStp.IAmtRecalcCls = CommonUtil.NullToSpace(facStp.IAmtRecalcCls);
            facStp.IReserve1 = null;
            facStp.IReserve2 = null;
            facStp.IReserve3 = null;
            facStp.ISys1Cls = " ";
            facStp.ISys2Cls = " ";
            facStp.ISys3Cls = " ";
            facStp.IUsr1Cls = " ";
            facStp.IUsr2Cls = " ";
            facStp.IUsr3Cls = " ";
            facStp.IInqItem = null;
            //facStp.IObjectId = card.C4_OBJECT_ID;//オブジェクトＩＤ???
            //facStp.IEntryDate = ServerFunction.GetDateTime();//登録日
            //facStp.IUpdDate = ServerFunction.GetDateTime();//更新日
            facStp.IEntryDate = DateTime.Now;
            facStp.IUpdDate = DateTime.Now;
            //facStp.IPgId = PE002201PgInfo._PROGRAM_ID; ;//プログラムＩＤ
            //facStp.IUpdTimestamp = wk_upd_timestamp;//更新タイムスタンプ

            ITFcConditionStpDao td = ComponentLocator.Instance().Resolve<ITFcConditionStpDao>();
            rtnValue = td.Insert(facStp);
            rtnValue = true;

            return rtnValue;
        }
    }
}

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
    }
}

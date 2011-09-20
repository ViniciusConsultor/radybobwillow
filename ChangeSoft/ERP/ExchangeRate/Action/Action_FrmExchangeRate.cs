﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net;
using Com.GainWinSoft.Common;
using Com.GainWinSoft.ERP.Entity.Dao;
using System.Collections;
using Com.GainWinSoft.ERP.Entity;
using System.Threading;


namespace Com.GainWinSoft.ERP.ExchangeRate.Action
{
    public class Action_FrmExchangeRate : Com.GainWinSoft.ERP.ExchangeRate.Action.IAction_FrmExchangeRate, Com.GainWinSoft.Common.IBaseAction
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Action_FrmExchangeRate));

        public Boolean InsExchangeRateStp()
        {
            //Com.GainWinSoft.ERP.Entity.Dao.TestDao td = new Com.GainWinSoft.ERP.Entity.Dao.TestDao();
            //通过Windsor的组件容器，获取Dao的实例
            ITRateStpDao td = ComponentLocator.Instance().Resolve<ITRateStpDao>();
            ////调用Dao的方法
            //IList<MFunctioncatalog> re = td.GetFunctionCatalogList(""); 

            //Test td = new Test();
            Boolean re = td.InsTRateStp("strForm");

            log.Debug("result=" + re);
            
            return re;

        }
    }
}
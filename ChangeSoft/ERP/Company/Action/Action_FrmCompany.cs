using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net;
using Com.ChangeSoft.Common;
using Com.ChangeSoft.ERP.Entity.Dao;


namespace Com.ChangeSoft.ERP.Company.Action
{
    public class Action_FrmCompany : Com.ChangeSoft.ERP.Company.Action.IAction_FrmCompany,Com.ChangeSoft.Common.IBaseAction
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Action_FrmCompany));

        public int NewMethod()
        {
            //Com.ChangeSoft.ERP.Entity.Dao.TestDao td = new Com.ChangeSoft.ERP.Entity.Dao.TestDao();
            //通过Windsor的组件容器，获取Dao的实例
            ITestDao td = ComponentLocator.Instance().Resolve<ITestDao>();
            //调用Dao的方法
            int re = td.Count();
            
            log.Debug("result=" + re);
            return re;

        }
    }
}

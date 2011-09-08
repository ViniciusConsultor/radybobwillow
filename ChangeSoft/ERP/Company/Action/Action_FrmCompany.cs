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


namespace Com.GainWinSoft.ERP.Company.Action
{
    public class Action_FrmCompany : Com.GainWinSoft.ERP.Company.Action.IAction_FrmCompany,Com.GainWinSoft.Common.IBaseAction
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Action_FrmCompany));

        public int NewMethod()
        {
            //Com.GainWinSoft.ERP.Entity.Dao.TestDao td = new Com.GainWinSoft.ERP.Entity.Dao.TestDao();
            //通过Windsor的组件容器，获取Dao的实例
            ICFunctionAllDao td = ComponentLocator.Instance().Resolve<ICFunctionAllDao>();
            ////调用Dao的方法
            //IList<MFunctioncatalog> re = td.GetFunctionCatalogList(""); 

            //Test td = new Test();
            IList<CFunctionAll> re = td.GetFunctionAllList(Thread.CurrentThread.CurrentUICulture.Name);

            log.Debug("result=" + re);
            return re.Count;

        }
    }
}

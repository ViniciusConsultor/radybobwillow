using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net;
using Com.ChangeSoft.Common;
using Com.ChangeSoft.ERP.Entity.Dao;
using System.Collections;
using Com.ChangeSoft.ERP.Entity;
using System.Threading;

namespace Com.ChangeSoft.ERP.Factory.Action
{
    public class Action_Factory : Com.ChangeSoft.Common.IBaseAction, Com.ChangeSoft.ERP.Factory.Action.IAction_Factory
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Action_Factory));

        public IList<MFunctioncatalog> GetFunctionDataList()
        {
            IList<MFunctioncatalog> funcvolist = new List<MFunctioncatalog>();
            IMFunctioncatalogDao td = ComponentLocator.Instance().Resolve<IMFunctioncatalogDao>();
            IList<MFunctioncatalog> mfuncatalist = td.GetFunctionCatalogList(LangUtils.GetCurrentLanguage());
            //foreach (MFunctioncatalog mfvo in mfuncatalist)
            //{
            //    FunctionVo fvo = new FunctionVo();
            //    fvo.Langid = mfvo.Id.Langid;
            //    fvo.Catalogid = mfvo.Id.Catalogid;
            //    fvo.Catalogname = mfvo.Catalogname;
            //    fvo.Catalogimage = mfvo.Catalogimage;
            //    funcvolist.Add(fvo);
            //}

            return mfuncatalist;
        }
    }
}

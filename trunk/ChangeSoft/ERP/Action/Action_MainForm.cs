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
using Com.ChangeSoft.ERP.FormVo;


namespace Com.ChangeSoft.ERP.Action
{
    public class Action_MainForm : Com.ChangeSoft.Common.IBaseAction, Com.ChangeSoft.ERP.Action.IAction_MainForm
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Action_MainForm));

        public IList<FunctionVo> GetFunctionDataList()
        {



            IList<FunctionVo> funcvolist = new List<FunctionVo>();
            ////Com.ChangeSoft.ERP.Entity.Dao.TestDao td = new Com.ChangeSoft.ERP.Entity.Dao.TestDao();
            ////通过Windsor的组件容器，获取Dao的实例
            IMFunctioncatalogDao td = ComponentLocator.Instance().Resolve<IMFunctioncatalogDao>();
            //////调用Dao的方法
            ////IList<MFunctioncatalog> re = td.GetFunctionCatalogList(""); 

            ////Test td = new Test();
            IList<MFunctioncatalog> mfuncatalist = td.GetFunctionCatalogList(LangUtils.GetCurrentLanguage());
            foreach (MFunctioncatalog mfvo in mfuncatalist)
            {
                FunctionVo fvo = new FunctionVo();
                fvo.Langid = mfvo.Id.Langid;
                fvo.Catalogid = mfvo.Id.Catalogid;
                fvo.Catalogname = mfvo.Catalogname;
                fvo.Catalogimage = mfvo.Catalogimage;
                funcvolist.Add(fvo);
            }

            //log.Debug("result=" + re);
            return funcvolist;

        }
    }
}

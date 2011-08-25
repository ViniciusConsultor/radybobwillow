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

        public IList<FunctionAllVo> GetFunctionDataList()
        {



            IList<FunctionAllVo> functionallvolist = new List<FunctionAllVo>();
            ////Com.ChangeSoft.ERP.Entity.Dao.TestDao td = new Com.ChangeSoft.ERP.Entity.Dao.TestDao();
            ////通过Windsor的组件容器，获取Dao的实例
            ICFunctionAllDao td = ComponentLocator.Instance().Resolve<ICFunctionAllDao>();
            //////调用Dao的方法
            ////IList<MFunctioncatalog> re = td.GetFunctionCatalogList(""); 

            ////Test td = new Test();
            IList<CFunctionAll> mfuncatalist = td.GetFunctionAllList(LangUtils.GetCurrentLanguage());
            foreach (CFunctionAll mfvo in mfuncatalist)
            {
                FunctionAllVo functionallvo = new FunctionAllVo();
                functionallvo.Langid = mfvo.Id.Langid;
                functionallvo.Catalogid = mfvo.Id.Catalogid;
                functionallvo.Catalogname = mfvo.Catalogname;
                functionallvo.Catalogimage = mfvo.Catalogimage;
                IList<FunctionVo> funcvolist = new List<FunctionVo>();
                foreach (MFunction f in mfvo.Functionlist)
                {
                    FunctionVo functionvo = new FunctionVo();
                    functionvo.Langid = f.Id.Langid;
                    functionvo.Functionid = f.Id.Functionid;
                    functionvo.Catalogid = f.Catalogid;
                    functionvo.Functionimage = f.Functionimage;
                    functionvo.Functionindex = f.Functionindex;
                    functionvo.Functionname = f.Functionname;
                    functionvo.Functionpath = f.Functionpath;
                    funcvolist.Add(functionvo);
                }
                functionallvo.Functionlist = funcvolist;
                functionallvolist.Add(functionallvo);
            }

            //log.Debug("result=" + re);
            return functionallvolist;

        }
    }
}

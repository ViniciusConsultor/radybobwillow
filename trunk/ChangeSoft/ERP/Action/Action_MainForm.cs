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
    public class Action_MainForm : Com.GainWinSoft.Common.IBaseAction, Com.GainWinSoft.ERP.Action.IAction_MainForm
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Action_MainForm));

        public IList<FunctionAllVo> GetFunctionDataList()
        {
            IList<FunctionAllVo> functionallvolist = new List<FunctionAllVo>();
            ////Com.GainWinSoft.ERP.Entity.Dao.TestDao td = new Com.GainWinSoft.ERP.Entity.Dao.TestDao();
            ////通过Windsor的组件容器，获取Dao的实例
            ICCatalogHasManyFunctionDao td = ComponentLocator.Instance().Resolve<ICCatalogHasManyFunctionDao>();
            //////调用Dao的方法
            ////IList<MFunctioncatalog> re = td.GetFunctionCatalogList(""); 

            ////Test td = new Test();
            IList<CCatalogHasManyFunction> mfuncatalist = td.GetFunctionAllList(LangUtils.GetCurrentLanguage());
            foreach (CCatalogHasManyFunction mfvo in mfuncatalist)
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

        public IList<FunctionAllVo> GetCatalogFunctionByUserId(string userid)
        {
            IList<FunctionAllVo> functionallvolist = new List<FunctionAllVo>();

            ICCatalogFunctionNoARDao dao = ComponentLocator.Instance().Resolve<ICCatalogFunctionNoARDao>();
            IList<CCatalogFunctionNoAR> catalogfunctionlist =   dao.GetCatalogFunctionByUserId(LangUtils.GetCurrentLanguage(),userid);
            int oldcatalogid = -1;

            foreach (CCatalogFunctionNoAR vo in catalogfunctionlist)
            {
                if (vo.Catalogid != oldcatalogid)
                {
                    FunctionAllVo allvo = new FunctionAllVo();
                    allvo.Catalogid = vo.Catalogid;
                    allvo.Catalogimage = vo.Catalogimage;
                    allvo.Catalogname = vo.Catalogname;
                    IList<FunctionVo> funclist = new List<FunctionVo>();
                    allvo.Functionlist=funclist;
                    functionallvolist.Add(allvo);
                    oldcatalogid = vo.Catalogid;
                }
                FunctionVo fvo = new FunctionVo();
                fvo.Catalogid = vo.Catalogid;
                fvo.Functionid = vo.Functionid;
                fvo.Functionimage = vo.Functionimage;
                fvo.Functionindex = vo.Functionindex;
                fvo.Functionname = vo.Functionname;
                fvo.Functionpath = vo.Functionpath;
                functionallvolist[functionallvolist.Count - 1].Functionlist.Add(fvo);

            }
            return functionallvolist;
        }

        public TermVo GetTermInfo(string userid)
        {

            ITTermMsDao dao = ComponentLocator.Instance().Resolve<ITTermMsDao>();

            TTermMs termms = dao.getTermbyUserId(userid);
            if (termms == null)
            {
                return null;
            }
            else
            {
                TermVo termvo = new TermVo();

                PropertiesCopier.CopyProperties(termms, termvo);
                return termvo;
            }
        }
        public FactoryVo GetFactoryByCd(string FacCd)
        {
            ITFactoryMsDao dao = ComponentLocator.Instance().Resolve<ITFactoryMsDao>();
            TFactoryMs factoryms = dao.getFactoryByCd(FacCd);
            if (factoryms == null)
            {
                throw new ApplicationException(MessageUtils.GetMessage("E0001"));
            }
            else
            {
                FactoryVo factoryvo = new FactoryVo();
                PropertiesCopier.CopyProperties(factoryms, factoryvo);
                return factoryvo;

            }
        }

        public PersonVo GetPersonByUserId(string userId)
        {
            ITPersonMsDao dao = ComponentLocator.Instance().Resolve<ITPersonMsDao>();
            TPersonMs personms = dao.getPersonByUserId(userId);
            if (personms == null)
            {
                throw new ApplicationException(MessageUtils.GetMessage("E0001"));
            }
            else
            {
                PersonVo personvo = new PersonVo();
                PropertiesCopier.CopyProperties(personms, personvo);
                personvo.ICompanyCd = personms.Id.ICompanyCd;
                personvo.IPersonCd = personms.Id.IPersonCd;

                return personvo;

            }
        }

        public CompanyConditionVo GetCompanyCondition(string companyCd)
        {
            ITCompanyConditionMsDao dao = ComponentLocator.Instance().Resolve<ITCompanyConditionMsDao>();
            TCompanyConditionMs companyconditionms = dao.getCompanyCondition(companyCd);
            if (companyconditionms == null)
            {
                throw new ApplicationException(MessageUtils.GetMessage("E0001"));
            }
            else
            {
                CompanyConditionVo companyconditonvo = new CompanyConditionVo();
                PropertiesCopier.CopyProperties(companyconditionms, companyconditonvo);
                return companyconditonvo;

            }
        }

    }
}

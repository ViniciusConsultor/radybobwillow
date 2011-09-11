using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Com.GainWinSoft.Common;
using log4net;
using System.Data;
using Com.GainWinSoft.ERP.Entity.Dao;
using Com.GainWinSoft.ERP.Entity;

namespace Com.GainWinSoft.ERP.CodeRef.Action
{
    class Action_CodeRefClsDetail:IBaseAction, Com.GainWinSoft.ERP.CodeRef.Action.IAction_CodeRefClsDetail
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Action_TestCode));

        public DataSet GetClsDetailDataSet(string clsCd)
        {
            ICClsDetailNoARDao d = ComponentLocator.Instance().Resolve<ICClsDetailNoARDao>();
            IList<CClsDetailNoAR> list = d.GetClsDetail(LangUtils.GetCurrentLanguage(), clsCd);
            DataTable dt = DataTableUtils.ToDataTable(list);
            dt.TableName = "CLSDETAIL";
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }

    }
}

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
    class Action_CodeRefSection : IBaseAction, Com.GainWinSoft.ERP.CodeRef.Action.IAction_CodeRefSection
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Action_CodeRefSection));

        public DataSet GetSectionDataSet(string companyCd, string secCd, string secNm)
        {
            ITSectionMsDao d = ComponentLocator.Instance().Resolve<ITSectionMsDao>();
            IList<TSectionMsNoAR> list = d.getAllSectionByCdNm(companyCd, secCd, secNm);
            DataTable dt = DataTableUtils.ToDataTable(list);
            dt.TableName = "CCodeRefSection";
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
    }
}

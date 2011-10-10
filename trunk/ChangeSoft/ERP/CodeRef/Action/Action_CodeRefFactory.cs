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
    class Action_CodeRefFactory : IBaseAction, Com.GainWinSoft.ERP.CodeRef.Action.IAction_CodeRefFactory
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Action_CodeRefFactory));

        public DataSet GetFactoryDataSet(string companyCd, string facCd, string facNm)
        {
            ITFactoryMsDao d = ComponentLocator.Instance().Resolve<ITFactoryMsDao>();
            IList<TFactoryMs> list = d.getAllFactoryByCdNm(companyCd, facCd, facNm);
            if (list.Count == 0)
            {
                list.Add(new TFactoryMs());
            }
            DataTable dt = DataTableUtils.ToDataTable(list);
            dt.TableName = "CCodeRefFactory";
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
    }
}

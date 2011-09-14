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
    class Action_CodeRefWarehouse : IBaseAction, Com.GainWinSoft.ERP.CodeRef.Action.IAction_CodeRefWarehouse
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Action_CodeRefFactory));

        public DataSet GetWarehouseDataSet(string facCd, string strWhere, string whCd, string whDesc)
        {
            ITWhPrcsMsDao d = ComponentLocator.Instance().Resolve<ITWhPrcsMsDao>();
            IList<TWhPrcsMsNoAR> list = d.getAllWhPrcsByCdNm(facCd, strWhere, whCd, whDesc);
            DataTable dt = DataTableUtils.ToDataTable(list);
            dt.TableName = "CCodeRefWarehouse";
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
    }
}

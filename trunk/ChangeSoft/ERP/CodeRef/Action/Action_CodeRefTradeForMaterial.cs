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
    class Action_CodeRefTradeForMaterial : IBaseAction, Com.GainWinSoft.ERP.CodeRef.Action.IAction_CodeRefTradeForMaterial
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Action_CodeRefTradeForMaterial));

        public DataSet GetTradeForMaterialDataSet(string companyCd, string dlCd, string dlDesc)
        {
            ICCodeRefTradeForMaterialNoARDao d = ComponentLocator.Instance().Resolve<ICCodeRefTradeForMaterialNoARDao>();
            IList<CCodeRefTradeForMaterialNoAR> list = d.GetCodeRefTradeForMaterial(LangUtils.GetCurrentLanguage(), companyCd, dlCd, dlDesc);
            DataTable dt = DataTableUtils.ToDataTable(list);
            dt.TableName = "CCodeRefTradeForMaterial";
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }

    }
}

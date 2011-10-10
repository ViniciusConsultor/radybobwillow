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
    class Action_CodeRefPerson : IBaseAction, Com.GainWinSoft.ERP.CodeRef.Action.IAction_CodeRefPerson
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Action_CodeRefPerson));

        public DataSet GetPersonDataSet(string companyCd, string sectionCd, string personCd,string personNm)
        {
            ICTPersonMsNoARDao d = ComponentLocator.Instance().Resolve<ICTPersonMsNoARDao>();
            IList<CTPersonMsNoAR> list = d.GetPersonMsList(companyCd, sectionCd, personCd, personNm);
            DataTable dt = DataTableUtils.ToDataTable(list);
            dt.TableName = "CTPersonMsNoAR";
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
    }
}

﻿using System;
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
    class Action_CodeRefPerson : IBaseAction
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Action_CodeRefPerson));

        public DataSet GetFactoryDataSet(string companyCd, string sectionCd, string personCd,string personNm)
        {
//            ITFactoryMsDao d = ComponentLocator.Instance().Resolve<ITFactoryMsDao>();
//            IList<TFactoryMs> list = d.getAllFactoryByCdNm(companyCd, facCd, facNm);
//            DataTable dt = DataTableUtils.ToDataTable(list);
//            dt.TableName = "CCodeRefFactory";
            DataSet ds = new DataSet();
//            ds.Tables.Add(dt);
            return ds;
        }
    }
}

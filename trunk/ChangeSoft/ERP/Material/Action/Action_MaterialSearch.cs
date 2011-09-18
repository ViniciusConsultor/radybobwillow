using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Com.GainWinSoft.Common;
using log4net;
using System.Data;
using Com.GainWinSoft.ERP.Entity.Dao;
using Com.GainWinSoft.ERP.Entity;
using Com.GainWinSoft.ERP.Material.FormVo;

namespace Com.GainWinSoft.ERP.Material.Action
{
    class Action_MaterialSearch :IBaseAction
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Action_MaterialSearch));

        public DataSet GetPmMsDetail(CardVo cardvo)
        {
            DataSet ds = new DataSet();


            ICTPmMsNoARDao d = ComponentLocator.Instance().Resolve<ICTPmMsNoARDao>();
            SearchCondition condition = new SearchCondition();
            condition.AddCondition("T_PM_MS.I_ITEM_ENTRY_CLS", "00", SqlOperator.Equal);
            condition.AddCondition("T_PM_MS.I_FAC_CD", cardvo.IFacCd,SqlOperator.Equal);
            condition.AddCondition("T_PM_MS.I_ITEM_TYPE", cardvo.IItemType, SqlOperator.Equal);
            condition.AddCondition("T_PM_MS.I_ITEM_CLS", cardvo.IItemCls, SqlOperator.Equal);
            //condition.AddCondition("T_PM_MS.I_DISP_ITEM_CD",cardvo.

            IList<CTPmMsNoAR> l = d.GetPmMsDetail(condition, false);


            return ds;
        }
    }
}

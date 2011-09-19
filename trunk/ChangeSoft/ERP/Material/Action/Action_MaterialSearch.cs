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
using Com.GainWinSoft.Common.Vo;
using Com.GainWinSoft.Common.Control.PagerGridView;
using System.Resources;

namespace Com.GainWinSoft.ERP.Material.Action
{
    public class Action_MaterialSearch :IBaseAction, Com.GainWinSoft.ERP.Material.Action.IAction_MaterialSearch
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Action_MaterialSearch));
        private ResourceManager rm = new System.Resources.ResourceManager(typeof(FrmMaterialSearch));

        public void GetPmMsDetail(PagerGridView gridview, CardVo cardvo)
        {
            DataSet ds = new DataSet();

            LoginUserInfoVo uservo = (LoginUserInfoVo)SessionUtils.GetSession(SessionUtils.COMMON_LOGIN_USER_INFO);
            

            SearchCondition condition = new SearchCondition();
            condition.SetAddtionalCondition("ALLFACTORY", false);
            condition.AddCondition("T_PM_MS.I_ITEM_ENTRY_CLS","IITEMENTRYCLS","00", SqlOperator.Equal);
            condition.AddCondition("T_PM_MS.I_FAC_CD", "IFACCD", cardvo.IFacCd, SqlOperator.Equal);
            condition.AddCondition("T_PM_MS.I_ITEM_TYPE","IITEMTYPE", cardvo.IItemType, SqlOperator.Equal);
            condition.AddCondition("T_PM_MS.I_ITEM_CLS","IITEMCLS", cardvo.IItemCls, SqlOperator.Equal);
            condition.AddCondition("T_PM_MS.I_DISP_ITEM_CD","IDISPITEMCD", cardvo.IDispItemCd, SqlOperator.Equal);
            condition.AddCondition("T_PM_MS.I_DISP_ITEM_REV", "IDISPITEMREV",cardvo.IDispItemRev, SqlOperator.Equal);
            condition.AddCondition("T_PM_MS.I_ITEM_DESC","IITEMDESC", cardvo.IItemDesc, SqlOperator.Like);
            condition.AddCondition("T_PM_MS.I_MODEL", "IMODEL",cardvo.IModel, SqlOperator.Like);
            condition.AddCondition("T_PM_MS.I_SPEC", "ISPEC",cardvo.ISpec, SqlOperator.Like);
            condition.AddCondition("T_PM_MS.I_DRW_NO","IDRWNO", cardvo.IDrwNo, SqlOperator.Like);
            condition.AddCondition("T_PM_MS.I_SEIBAN","ISEIBAN", cardvo.ISeiban, SqlOperator.Like);
            condition.AddCondition("T_PM_MS.I_MAKER_CD","IMAKERCD", cardvo.IMakerCd, SqlOperator.Equal);
            condition.AddCondition("T_PM_MS.I_QRY_MTRL","IQRYMTRL", cardvo.IQryMtrl, SqlOperator.Like);
            condition.AddCondition("T_PM_MS.I_MNT_CLS", "IMNTCLS",cardvo.IMntCls, SqlOperator.Equal);
            condition.AddCondition("companyCd", uservo.CompanyCondition.ICompanyCd);
            condition.AddCondition("langCd", LangUtils.GetCurrentLanguage());



            gridview.Pagerhelper = new PagerHelper("CTPmMsPagerNoARDao", condition, 1, 5);
            gridview.LoadData();
            log.Debug("Search Init");
            //设置列名
            foreach (string key in gridview.Pagerhelper.Columns)
            {
                gridview.SetColumnAlias(key, (string)rm.GetObject(key));
            }

            //设置可视列


           gridview.SetDisplayColumns(gridview.Name, null);


        }
    }
}

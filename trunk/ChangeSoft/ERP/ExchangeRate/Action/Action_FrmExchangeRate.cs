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

using Com.GainWinSoft.ERP.ExchangeRate.FormVo;
using System.Resources;
using Com.GainWinSoft.Common.Control.PagerGridView;
using System.Data;
using Com.GainWinSoft.Common.Vo;


namespace Com.GainWinSoft.ERP.ExchangeRate.Action
{
    public class Action_FrmExchangeRate : Com.GainWinSoft.ERP.ExchangeRate.Action.IAction_FrmExchangeRate, Com.GainWinSoft.Common.IBaseAction
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Action_FrmExchangeRate));
        private ResourceManager rm = new System.Resources.ResourceManager(typeof(FrmExchangeRate));
        private string[] columnlist = new string[] { "IDispItemCd", "IDispItemRev", "IDlCd", "IDrwNo" };




        #region 查询汇率
        public void GetRateMsDetail(PagerGridView gridview, 
                Com.GainWinSoft.ERP.ExchangeRate.FormVo.FrmExRateCardVo cardvo){
                    log.Debug("Search Init start");


               DataSet ds = new DataSet();
               LoginUserInfoVo uservo = (LoginUserInfoVo)SessionUtils.GetSession(SessionUtils.COMMON_LOGIN_USER_INFO);
               SearchCondition condition = new SearchCondition();


               condition.SetAddtionalCondition("ALLFACTORY", false);
               condition.AddCondition("T_PM_MS.I_ITEM_ENTRY_CLS", "IITEMENTRYCLS", "00", SqlOperator.Equal);


               gridview.Pagerhelper = new PagerHelper("CTPmMsPagerNoARDao", condition, 1, 15);
               gridview.LoadData();
               log.Debug("Search Init over");



               foreach (string key in columnlist)
               {
                   gridview.SetColumnAlias(key, rm.GetString(key));
               }

               SetDisplayColumns(gridview);

        }
        #endregion


        #region 设置显示列
        private void SetDisplayColumns(PagerGridView gridview)
        {
            //设置可视列

            IList<ColumnInfoVo> clist = new List<ColumnInfoVo>();
            ColumnInfoVo columnvo = new ColumnInfoVo();
            columnvo.Columnname = "IDispItemCd";
            columnvo.Columnwidth = 100;
            clist.Add(columnvo);
            columnvo = new ColumnInfoVo();
            columnvo.Columnname = "IDispItemRev";
            columnvo.Columnwidth = 50;
            clist.Add(columnvo);
            columnvo = new ColumnInfoVo();
            columnvo.Columnname = "IItemDesc";
            columnvo.Columnwidth = 100;
            clist.Add(columnvo);
            columnvo = new ColumnInfoVo();
            columnvo.Columnname = "VDlDesc";
            columnvo.Columnwidth = 100;
            clist.Add(columnvo);
            columnvo = new ColumnInfoVo();
            columnvo.Columnname = "VItemclsdesc";
            columnvo.Columnwidth = 100;
            clist.Add(columnvo);
            columnvo = new ColumnInfoVo();
            columnvo.Columnname = "VItemtypedesc";
            columnvo.Columnwidth = 100;
            clist.Add(columnvo);
            columnvo = new ColumnInfoVo();
            columnvo.Columnname = "VMakerdesc";
            columnvo.Columnwidth = 100;
            clist.Add(columnvo);
            columnvo = new ColumnInfoVo();
            columnvo.Columnname = "IModel";
            columnvo.Columnwidth = 100;
            clist.Add(columnvo);
            columnvo = new ColumnInfoVo();
            columnvo.Columnname = "IDrwNo";
            columnvo.Columnwidth = 100;
            clist.Add(columnvo);
            columnvo = new ColumnInfoVo();
            columnvo.Columnname = "ISpec";
            columnvo.Columnwidth = 100;
            clist.Add(columnvo);
            columnvo = new ColumnInfoVo();
            columnvo.Columnname = "ISeiban";
            columnvo.Columnwidth = 100;
            clist.Add(columnvo);
            columnvo = new ColumnInfoVo();
            columnvo.Columnname = "IQryMtrl";
            columnvo.Columnwidth = 100;
            clist.Add(columnvo);

            gridview.SetDisplayColumns(gridview.Name, clist);
        }
        #endregion

        #region 初始化  Init_GridView
        public void Init_GridView(PagerGridView gridview)
        {
            DataTable dt = new DataTable();

            foreach (string key in columnlist)
            {
                DataColumn col = new DataColumn();
                col.ColumnName = key;
                dt.Columns.Add(col);
            }

            gridview.InitGridView(dt);

            foreach (string key in columnlist)
            {
                gridview.SetColumnAlias(key, rm.GetString(key));
            }


            SetDisplayColumns(gridview);

        }

        #endregion



        #region 登陆rateSTP
        public Boolean InsExchangeRateStp(FrmExRateCardVo exRatevo)
        {
            //Com.GainWinSoft.ERP.Entity.Dao.TestDao td = new Com.GainWinSoft.ERP.Entity.Dao.TestDao();
            //通过Windsor的组件容器，获取Dao的实例
            ITRateStpDao td = ComponentLocator.Instance().Resolve<ITRateStpDao>();
            ////调用Dao的方法
            //IList<MFunctioncatalog> re = td.GetFunctionCatalogList(""); 
            TRateStp tRateModel = new TRateStp();
            PropertiesCopier.CopyProperties(exRatevo, tRateModel);
            tRateModel.Id.ICompanyCd = "00";
            tRateModel.Id.IJournalNo = (decimal)1000001;
            tRateModel.IPgId = "FxRate";
            tRateModel.IPrcsCls = "00";
            tRateModel.IPrcsDate = DateTime.Now;
            tRateModel.IPrcsTime = DateTime.Now.ToShortTimeString();
            tRateModel.IRefTimestamp = "100001";

            tRateModel.IUpdCls = "0";
            tRateModel.IUserId = "flyant";


            //Test td = new Test();
            Boolean re = td.InsTRateStp(tRateModel);

            log.Debug("result=" + re);
            
            return re;

        }

        #endregion

    }
}

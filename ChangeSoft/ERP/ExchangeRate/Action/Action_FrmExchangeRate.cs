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

        private string[] columnlist = new string[] { "I_COMPANY_CD", "I_RATE_CLS", "I_CLS_DETAIL_DESC", "I_DL_CURR_CD"
                                , "I_CURR_DESC", "I_EFF_END_DATE", "I_RATE", "I_CNV_METHOD", "I_CNV_METHOD_DESC" };

        //货币代码
        string CurrCD = "CurrCD";
        //汇率区分
        string RateCls = "RateCls";

        #   region 查询汇率
        public Int32 GetRateMsDetail(PagerGridView gridview, 
                Com.GainWinSoft.ERP.ExchangeRate.FormVo.FrmExRateCardVo cardvo){
                    log.Debug("Search Init start");


            
               LoginUserInfoVo uservo = (LoginUserInfoVo)SessionUtils.GetSession(SessionUtils.COMMON_LOGIN_USER_INFO);
               SearchCondition condition = new SearchCondition();


               condition.SetAddtionalCondition(CurrCD, cardvo.IDlCurrCd);
               condition.SetAddtionalCondition(RateCls, cardvo.IRateCls);






               if (!string.IsNullOrEmpty(cardvo.IDlCurrCd))
               {
                   condition.AddCondition("T_RATE_MS.I_DL_CURR_CD", "I_DL_CURR_CD", cardvo.IDlCurrCd, SqlOperator.Equal);

               }

               if (!string.IsNullOrEmpty(cardvo.IRateCls))
               {
                   condition.AddCondition("T_RATE_MS.I_RATE_CLS", "I_RATE_CLS", cardvo.IRateCls, SqlOperator.Equal);                   
               }
               condition.AddCondition("I_COMPANY_CD", uservo.CompanyCondition.ICompanyCd);
               condition.AddCondition("I_LANGUAGE_CD", LangUtils.GetCurrentLanguage());


               gridview.Pagerhelper = new PagerHelper("TrateMsPagerNoARDao", condition, 1, 15);
               gridview.LoadData();

               log.Debug("Search Init over");



               foreach (string key in columnlist)
               {
                   gridview.SetColumnAlias(key, rm.GetString(key));
               }

               SetDisplayColumns(gridview);
               DataSet ds = (DataSet)gridview.DataSource;
               DataTable dt = ds.Tables["TrateMsPagerNoARDao"];
               return dt.Rows.Count;

        }
        #endregion


        #region 设置显示列
        private void SetDisplayColumns(PagerGridView gridview)
        {
            //设置可视列

            IList<ColumnInfoVo> clist = new List<ColumnInfoVo>();
            ColumnInfoVo columnvo = new ColumnInfoVo();

            columnvo.Columnname = "I_COMPANY_CD";
            columnvo.Columnwidth = 0;
            clist.Add(columnvo);

            columnvo = new ColumnInfoVo();
            columnvo.Columnname = "I_RATE_CLS";
            columnvo.Columnwidth = 50;
            clist.Add(columnvo);

            columnvo = new ColumnInfoVo();
            columnvo.Columnname = "I_CLS_DETAIL_DESC";
            columnvo.Columnwidth = 100;
            clist.Add(columnvo);
            columnvo = new ColumnInfoVo();
            columnvo.Columnname = "I_DL_CURR_CD";
            columnvo.Columnwidth = 100;
            clist.Add(columnvo);
            columnvo = new ColumnInfoVo();
            columnvo.Columnname = "I_CURR_DESC";
            columnvo.Columnwidth = 100;
            clist.Add(columnvo);
            columnvo = new ColumnInfoVo();
            columnvo.Columnname = "I_EFF_END_DATE";
            columnvo.Columnwidth = 50;
            clist.Add(columnvo);

            columnvo = new ColumnInfoVo();
            columnvo.Columnname = "I_RATE";
            columnvo.Columnwidth = 50;
            clist.Add(columnvo);
            columnvo = new ColumnInfoVo();
            columnvo.Columnname = "I_CNV_METHOD";
            columnvo.Columnwidth = 100;
            clist.Add(columnvo);
            columnvo = new ColumnInfoVo();
            columnvo.Columnname = "I_CNV_METHOD_DESC";
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

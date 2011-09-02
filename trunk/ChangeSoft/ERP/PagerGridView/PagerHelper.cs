using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Com.ChangeSoft.Common;
using Com.ChangeSoft.ERP.Entity.Dao;
using System.Data.SqlClient;

namespace Com.ChangeSoft.Common.Control.PagerGridView
{
    /// <summary>
    /// 
    /// </summary>
    public class PagerHelper
    {
        private string sql = "";
        private int currentPage = 0;
        private int pagerSize;
        private string key = "";
        private SearchCondition condition;
        private int totalrecords = 0;
        private int totalpages = 0;

        private int currentPageFirst = 0;

  
        private int currentPageLast = 0;

 

  



        /// <summary>
        /// 
        /// </summary>
        /// <param name="key">CastleWindsor 的配置文件里定义的bean的ID</param>
        /// <param name="condition"></param>
        /// <param name="currentPage">从1开始</param>
        /// <param name="pagerSize"></param>
        public PagerHelper(string key,SearchCondition condition,int currentPage,int pagerSize)
        {

            this.condition = condition;
            this.pagerSize = pagerSize;
            this.key = key;
            this.currentPage = currentPage;
            this.totalrecords = GetCount();
            this.totalpages = this.totalrecords / this.pagerSize;
			
			// Adjust page count if the last page contains partial page.
			if (this.totalrecords % this.pagerSize > 0)
				this.totalpages++;

            this.currentPageFirst = (currentPage - 1) * pagerSize + 1;
            this.CurrentPageLast = (currentPage - 1) * pagerSize + pagerSize;


        }

        public string Key
        {
            get { return key; }
            set { key = value; }
        }

        public string Sql
        {
            get { return sql; }
            set { sql = value; }
        }

        public int CurrentPage
        {
            get { return currentPage; }
            set { currentPage = value; }
        }
        
        public int PagerSize
        {
            get { return pagerSize; }
            set { pagerSize = value; }
        }

        public SearchCondition Condition
        {
            get { return condition; }
            set { condition = value; }
        }

        public int Totalrecords
        {
            get { return totalrecords; }
            set { totalrecords = value; }
        }

        public int Totalpages
        {
            get { return totalpages; }
            set { totalpages = value; }
        }
        public int CurrentPageFirst
        {
            get { return currentPageFirst; }
            set { currentPageFirst = value; }
        }
        public int CurrentPageLast
        {
            get { return currentPageLast; }
            set { currentPageLast = value; }
        }
        public DataSet GetDataSet()
        {

            ICPagerDao td = (ICPagerDao)ComponentLocator.Instance().Resolve(key,typeof(ICPagerDao));
            DataSet ds = td.GetDataSet(this.key,this.condition,this.pagerSize,(this.currentPage-1));
            return ds;

        }

        public int GetCount()
        {
            ICPagerDao td = (ICPagerDao)ComponentLocator.Instance().Resolve(key, typeof(ICPagerDao));
            int result = td.GetCount(this.key, this.condition);
            return result;
        }

    }
}

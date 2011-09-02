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
    public class PagerHelper
    {
        private string sql = "";
        private int currentPage = 0;
        private int pagerSize;
        private string tablename = "";
        private IList<SqlParameter> paralist;
        private int totalrecords = 0;

  

        public PagerHelper()
        {
        }

        public PagerHelper(string sql,string tablename,IList<SqlParameter> paralist,int currentPage,int pagerSize)
        {
            this.sql = sql;
            this.paralist = paralist;
            this.pagerSize = pagerSize;
            this.tablename = tablename;
            this.currentPage = currentPage;
            this.totalrecords = GetCount();

        }

        public string Tablename
        {
            get { return tablename; }
            set { tablename = value; }
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

        public IList<SqlParameter> Paralist
        {
            get { return paralist; }
            set { paralist = value; }
        }

        public int Totalrecords
        {
            get { return totalrecords; }
            set { totalrecords = value; }
        }

        public DataSet GetDataSet()
        {

            ICPagerDao td = (ICPagerDao)ComponentLocator.Instance().Resolve("",typeof(ICPagerDao));
            DataSet ds = td.GetDataSet(this.tablename,this.sql,this.paralist,this.pagerSize,this.currentPage);
            return ds;

        }

        public int GetCount()
        {
            ICPagerDao td = ComponentLocator.Instance().Resolve<ICPagerDao>();
            int result = td.GetCount(this.tablename, this.sql, this.paralist);
            return result;
        }

    }
}

using System;
using System.Data.SqlClient;
using System.Collections.Generic;
namespace Com.ChangeSoft.ERP.Entity.Dao
{
    public interface ICPagerDao
    {
        int GetCount(string tablename, string sql, IList<SqlParameter> paralist);
        System.Data.DataSet GetDataSet(string tablename, string sql, IList<SqlParameter> paralist, int pagesize, int pageindex);
    }
}

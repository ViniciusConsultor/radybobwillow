using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using Com.ChangeSoft.Common;
namespace Com.ChangeSoft.ERP.Entity.Dao
{
    public interface ICPagerDao
    {
        int GetCount(string key, SearchCondition condition);
        System.Data.DataSet GetDataSet(string key, SearchCondition condition, int pagesize, int pageindex);
    }
}

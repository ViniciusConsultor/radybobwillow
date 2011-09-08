using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using Com.GainWinSoft.Common;
namespace Com.GainWinSoft.ERP.Entity.Dao
{
    public interface ICPagerDao
    {
        int GetCount(string key, SearchCondition condition);
        System.Data.DataSet GetDataSet(string key, SearchCondition condition, int pagesize, int pageindex);
    }
}

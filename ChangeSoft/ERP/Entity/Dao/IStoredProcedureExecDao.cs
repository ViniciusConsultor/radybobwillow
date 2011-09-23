using System;
namespace Com.GainWinSoft.ERP.Entity.Dao
{
    public interface IStoredProcedureExecDao
    {
        decimal StoredProcedureExecReturnNumber(string procedureName, Com.GainWinSoft.Common.StoredProcedureCondition parameters);
    }
}

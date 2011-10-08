using System;
using Com.GainWinSoft.ERP.Entity.Dao.StoredInfo;
namespace Com.GainWinSoft.ERP.Entity.Dao
{
    public interface IStoredProcedureExecDao
    {
        void StoredProcedureExec(IStoredParameterInfo storedinfo);

    }
}

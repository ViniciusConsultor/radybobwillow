using System;
using System.Collections.Generic;
namespace Com.GainWinSoft.ERP.Entity.Dao
{
    public interface ITWhPrcsMsDao
    {
        IList<TWhPrcsMsNoAR> getAllWhPrcsByCdNm(string facCd, string strWhere, string whCd, string whDesc);
    }
}

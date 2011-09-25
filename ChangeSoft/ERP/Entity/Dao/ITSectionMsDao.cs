using System;
using System.Collections.Generic;
namespace Com.GainWinSoft.ERP.Entity.Dao
{
    public interface ITSectionMsDao
    {
        TSectionMs getSectionByCd(string companyCd, string secCd);
        IList<TSectionMsNoAR> getAllSectionByCdNm(string companyCd, string secCd, string secNm);
    }
}

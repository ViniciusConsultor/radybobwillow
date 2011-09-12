using System;
using System.Collections.Generic;
namespace Com.GainWinSoft.ERP.Entity.Dao
{
    public interface ITFactoryMsDao
    {
        Com.GainWinSoft.ERP.Entity.TFactoryMs getFactoryByCd(string facCd);
        IList<Com.GainWinSoft.ERP.Entity.TFactoryMs> getAllFactoryByCdNm(string companyCd, string facCd, string facNm);
    }
}

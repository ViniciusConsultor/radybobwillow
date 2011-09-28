using System;
using System.Collections.Generic;
namespace Com.GainWinSoft.ERP.Entity.Dao
{
    public interface ITFactoryMsDao
    {
        TFactoryMs getFactoryByCd(string facCd);
        IList<TFactoryMs> getAllFactoryByCdNm(string companyCd, string facCd, string facNm);
    }
}

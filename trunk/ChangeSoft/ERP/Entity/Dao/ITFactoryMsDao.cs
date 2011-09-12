using System;
namespace Com.GainWinSoft.ERP.Entity.Dao
{
    public interface ITFactoryMsDao
    {
        Com.GainWinSoft.ERP.Entity.TFactoryMs getFactoryByCd(string facCd);
    }
}

using System;
namespace Com.GainWinSoft.ERP.Entity.Dao
{
    public interface ICTPersonMsNoARDao
    {
        System.Collections.Generic.IList<Com.GainWinSoft.ERP.Entity.CTPersonMsNoAR> GetPersonMsList(string companyCd, string sectionCd, string personCd, string personNm);
    }
}

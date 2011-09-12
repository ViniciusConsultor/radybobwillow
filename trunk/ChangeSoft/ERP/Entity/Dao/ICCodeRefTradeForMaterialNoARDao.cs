using System;
namespace Com.GainWinSoft.ERP.Entity.Dao
{
    public interface ICCodeRefTradeForMaterialNoARDao
    {
        System.Collections.Generic.IList<Com.GainWinSoft.ERP.Entity.CCodeRefTradeForMaterialNoAR> GetCodeRefTradeForMaterial(string langId, string companyCd, string dlCd, string dlDesc);
    }
}

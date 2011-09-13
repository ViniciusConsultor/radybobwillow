using System;
using System.Collections.Generic;
namespace Com.GainWinSoft.ERP.Entity.Dao
{
    public interface ICTableDropDownListNoARDao
    {
        IList<Com.GainWinSoft.ERP.Entity.CTableDropDownListNoAR> GetDetail(string langId, string langColumn, string talbeNm, string valueColumn, string nameColumn);
        IList<Com.GainWinSoft.ERP.Entity.CTableDropDownListNoAR> GetDetail(string talbeNm, string valueColumn, string nameColumn);
    }
}

using System;
namespace Com.GainWinSoft.ERP.CodeRef.Action
{
    public interface IAction_CodeRefTradeForMaterial
    {
        System.Data.DataSet GetTradeForMaterialDataSet(string companyCd, string dlCd, string dlDesc);
    }
}

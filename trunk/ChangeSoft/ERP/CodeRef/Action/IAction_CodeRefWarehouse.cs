using System;
namespace Com.GainWinSoft.ERP.CodeRef.Action
{
    public interface IAction_CodeRefWarehouse
    {
        System.Data.DataSet GetWarehouseDataSet(string facCd, string strWhere, string whCd, string whDesc);
    }
}

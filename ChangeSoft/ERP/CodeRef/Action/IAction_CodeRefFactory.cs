using System;
namespace Com.GainWinSoft.ERP.CodeRef.Action
{
    public interface IAction_CodeRefFactory
    {
        System.Data.DataSet GetFactoryDataSet(string companyCd, string facCd, string facNm);
    }
}

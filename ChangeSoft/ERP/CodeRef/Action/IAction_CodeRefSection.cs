using System;
namespace Com.GainWinSoft.ERP.CodeRef.Action
{
    public interface IAction_CodeRefSection
    {
        System.Data.DataSet GetSectionDataSet(string companyCd, string secCd, string secNm);
    }
}

using System;
namespace Com.GainWinSoft.ERP.CodeRef.Action
{
    public interface IAction_CodeRefPerson
    {
        System.Data.DataSet GetPersonDataSet(string companyCd, string sectionCd, string personCd, string personNm);
    }
}

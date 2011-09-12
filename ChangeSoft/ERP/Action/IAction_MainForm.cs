using System;
using System.Collections.Generic;
using Com.GainWinSoft.Common.Vo;
namespace Com.GainWinSoft.ERP.Action
{
    public interface IAction_MainForm
    {
        System.Collections.Generic.IList<Com.GainWinSoft.Common.Vo.FunctionAllVo> GetFunctionDataList();

        IList<FunctionAllVo> GetCatalogFunctionByUserId(string userid);

        TermVo GetTermInfo(string userid);

        FactoryVo GetFactoryByCd(string FacCd);

        PersonVo GetPersonByUserId(string userId);

        CompanyConditionVo GetCompanyCondition(string companyCd);
    }
}

using System;
using Com.GainWinSoft.ERP.FormVo;
using System.Collections.Generic;
namespace Com.GainWinSoft.ERP.Action
{
    public interface IAction_MainForm
    {
        System.Collections.Generic.IList<Com.GainWinSoft.ERP.FormVo.FunctionAllVo> GetFunctionDataList();

        IList<FunctionAllVo> GetCatalogFunctionByUserId(string userid);
    }
}

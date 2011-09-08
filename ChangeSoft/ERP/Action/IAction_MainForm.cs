using System;
namespace Com.GainWinSoft.ERP.Action
{
    public interface IAction_MainForm
    {
        System.Collections.Generic.IList<Com.GainWinSoft.ERP.FormVo.FunctionAllVo> GetFunctionDataList();
    }
}

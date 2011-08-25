using System;
namespace Com.ChangeSoft.ERP.Action
{
    public interface IAction_MainForm
    {
        System.Collections.Generic.IList<Com.ChangeSoft.ERP.FormVo.FunctionAllVo> GetFunctionDataList();
    }
}

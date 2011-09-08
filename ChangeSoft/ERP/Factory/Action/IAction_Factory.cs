using System;
using Com.GainWinSoft.ERP.Entity;

namespace Com.GainWinSoft.ERP.Factory.Action
{
    public interface IAction_Factory
    {
        System.Collections.Generic.IList<Com.GainWinSoft.ERP.Entity.MFunctioncatalog> GetFunctionDataList();
    }
}

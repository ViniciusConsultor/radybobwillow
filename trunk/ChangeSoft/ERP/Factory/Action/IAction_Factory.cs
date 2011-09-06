using System;
using Com.ChangeSoft.ERP.Entity;

namespace Com.ChangeSoft.ERP.Factory.Action
{
    public interface IAction_Factory
    {
        System.Collections.Generic.IList<Com.ChangeSoft.ERP.Entity.MFunctioncatalog> GetFunctionDataList();
    }
}

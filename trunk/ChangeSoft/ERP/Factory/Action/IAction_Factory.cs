using System;
using Com.GainWinSoft.ERP.Entity;
using System.Collections.Generic;

namespace Com.GainWinSoft.ERP.Factory.Action
{
    public interface IAction_Factory
    {
        TFactoryMs GetFactoryByCd(String facCd);
    }
}

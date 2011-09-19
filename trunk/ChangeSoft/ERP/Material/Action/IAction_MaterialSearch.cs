using System;
using Com.GainWinSoft.Common.Control.PagerGridView;
namespace Com.GainWinSoft.ERP.Material.Action
{
    public interface IAction_MaterialSearch
    {
        void GetPmMsDetail(PagerGridView gridview,Com.GainWinSoft.ERP.Material.FormVo.CardVo cardvo);
    }
}

using System;

using Com.GainWinSoft.ERP.ExchangeRate.FormVo;
using Com.GainWinSoft.Common.Control.PagerGridView;

namespace Com.GainWinSoft.ERP.ExchangeRate.Action
{
    interface IAction_FrmExchangeRate
    {
        Boolean InsExchangeRateStp(FrmExRateCardVo exRatevo);
       Int32 GetRateMsDetail(PagerGridView gridview, Com.GainWinSoft.ERP.ExchangeRate.FormVo.FrmExRateCardVo cardvo);



    }
}

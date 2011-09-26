using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Com.GainWinSoft.ERP.Entity;
using Com.GainWinSoft.ERP.Entity.Dao;
using Com.GainWinSoft.Common;
using System.Data;

namespace Com.GainWinSoft.ERP.MasterCheck
{
    /// <summary>
    /// 客户表各种Check方法类
    /// </summary>
    public class CheckTrade
    {
        /// <summary>
        /// 
        /// 根据客户代码判断是否存在
        /// </summary>
        /// <param name="companyCd"></param>
        /// <param name="dlCd"></param>
        /// <returns></returns>
        public Boolean Check01Bool(string companyCd, string dlCd)
        {
            Boolean rtnVal = false;
            TTradeMs vo = Check01Vo(companyCd, dlCd);
            if (vo != null && vo.Id!=null)
            {
                rtnVal = true;
            }

            return rtnVal;
        }
        /// <summary>
        /// 根据客户代码判断是否存在
        /// </summary>
        /// <param name="companyCd"></param>
        /// <param name="dlCd"></param>
        /// <returns></returns>
        public TTradeMs Check01Vo(string companyCd, string dlCd)
        {
            TTradeMs vo = null;
            try
            {
                if (!String.IsNullOrEmpty(companyCd) && !(string.IsNullOrEmpty(dlCd)) )
                {
                    ITTradeMsDao d = ComponentLocator.Instance().Resolve<ITTradeMsDao>();
                    vo = d.getTradeByCd(companyCd,dlCd);
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message, ex);
            }

            return vo;
        }
    }
}

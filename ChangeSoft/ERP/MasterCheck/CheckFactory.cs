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
    /// 工厂表各种Check方法类
    /// </summary>
    public class CheckFactory
    {
        /// <summary>
        /// 根据工厂代码，检查数据表中是否存在
        /// <param name="facCd">工厂代码</param>
        /// <returns>Boolean</returns>
        /// </summary>
        public Boolean Check01Bool(String facCd)
        {
            Boolean rtnVal = false;
            TFactoryMs vo = Check01Vo(facCd);
            if (vo != null && !String.IsNullOrEmpty(vo.IFacCd))
            {
                rtnVal = true;
            }

            return rtnVal;
        }

        /// <summary>
        /// 根据工厂代码，检查数据表中是否存在
        /// <param name="facCd">工厂代码</param>
        /// <returns>TFactoryMs</returns>
        /// </summary>
        public TFactoryMs Check01Vo(String facCd)
        {
            TFactoryMs vo = new TFactoryMs();
            try
            {
                if (!String.IsNullOrEmpty(facCd))
                {
                    ITFactoryMsDao d = ComponentLocator.Instance().Resolve<ITFactoryMsDao>();
                    vo = d.getFactoryByCd(facCd);
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

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
    /// 区分表各种Check方法类
    /// </summary>
    public class CheckCls
    {
        /// <summary>
        /// 根据区分代码和区分明细代码，检查数据表中是否存在
        ///<param name="clsCd"></param>
        ///<param name="detailCd"></param>
        ///<param name="langCd"></param>
        /// <returns>Boolean</returns>
        /// </summary>
        public Boolean Check01Bool(string langCd, string clsCd, string detailCd)
        {
            Boolean rtnVal = false;
            CClsDetailNoAR vo = Check01Vo(langCd,clsCd,detailCd);
            if (vo != null && !String.IsNullOrEmpty(vo.IClsDetailCd))
            {
                rtnVal = true;
            }

            return rtnVal;
        }

        /// <summary>
        /// 根据区分代码和区分明细代码，检查数据表中是否存在
        ///<param name="clsCd"></param>
        ///<param name="detailCd"></param>
        ///<param name="langCd"></param>
        /// <returns>Boolean</returns>
        /// <returns>CClsDetailNoAR</returns>
        /// </summary>
        public CClsDetailNoAR Check01Vo(string langCd,string clsCd,string detailCd)
        {
            CClsDetailNoAR vo = null;
            try
            {
                if (!String.IsNullOrEmpty(clsCd)&&!(string.IsNullOrEmpty(detailCd))&&!(string.IsNullOrEmpty(langCd)))
                {
                    ICClsDetailNoARDao d = ComponentLocator.Instance().Resolve<ICClsDetailNoARDao>();
                    vo = d.GetClsDetail(langCd,clsCd,detailCd);
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

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
    /// 部门表各种Check方法类
    /// </summary>
    public class CheckSection
    {
        /// <summary>
        /// 根据部门代码，检查数据表中是否存在
        /// <param name="companyCd">公司代码</param>
        /// <param name="secCd">部门代码</param>
        /// <returns>Boolean</returns>
        /// </summary>
        public Boolean Check01Bool(String companyCd, String secCd)
        {
            Boolean rtnVal = false;
            TSectionMs vo = Check01Vo(companyCd, secCd);
            if (vo != null && !String.IsNullOrEmpty(vo.Id.ISectionCd))
            {
                rtnVal = true;
            }

            return rtnVal;
        }

        /// <summary>
        /// 根据部门代码，检查数据表中是否存在
        /// <param name="companyCd">公司代码</param>
        /// <param name="secCd">部门代码</param>
        /// <returns>TSectionMs</returns>
        /// </summary>
        public TSectionMs Check01Vo(String companyCd, String secCd)
        {
            TSectionMs vo = new TSectionMs();
            try
            {
                if (!String.IsNullOrEmpty(secCd))
                {
                    ITSectionMsDao d = ComponentLocator.Instance().Resolve<ITSectionMsDao>();
                    vo = d.getSectionByCd(companyCd, secCd);
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

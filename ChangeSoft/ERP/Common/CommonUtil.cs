using System;
using System.Collections;
using System.Xml;
using System.Collections.Generic;

namespace Com.GainWinSoft.Common
{
    public class CommonUtil
    {
        #region シングルコーテーション付与
        /// <summary>
        /// シングルコーテーション付与
        /// </summary>
        /// <param name="value">変換値</param>
        /// <returns></returns>
        public static string AddSquote(string value)
        {
            try
            {
                if (!string.IsNullOrEmpty(value))
                    return "'" + value + "'";
                return "";
            }
            catch (System.Exception ex)
            {
                throw new Exception("共通関数内部エラーです", ex);
            }
        }
        #endregion

        #region 根据更新模式，返回STP表用处理种别
        /// <summary>
        /// 根据更新模式，返回STP表用处理种别
        /// </summary>
        /// <param name="strMode">更新模式</param>
        /// <returns></returns>
        public static String GET_I_PRCS_CLS(String strMode)
        {
            String rtnValue = "00";
            switch (strMode)
            {
                case Constant.MODE_ADD:
                    rtnValue = Constant.I_PRCS_CLS_C;
                    break;
                case Constant.MODE_UPD:
                    rtnValue = Constant.I_PRCS_CLS_U;
                    break;
                case Constant.MODE_DEL:
                    rtnValue = Constant.I_PRCS_CLS_D;
                    break;
            }

            return rtnValue;
        }
        #endregion
    }
}

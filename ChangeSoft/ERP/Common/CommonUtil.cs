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


        #region 日付変換(DateTime型)

        /// <summary>
        /// 日付変換(string型からDateTime型へ変換する)
        /// </summary>
        /// <param name="inDate">日付項目</param>
        /// <returns>変換後日付</returns>
        public static DateTime DateToDateTime(string inDate)
        {
            return ConvertToDate(inDate);
        }

        /// <summary>
        /// 日付変換(decimal型からDateTime型へ変換する)
        /// </summary>
        /// <param name="inDate">日付項目</param>
        /// <returns>変換後日付</returns>
        public static DateTime DateToDateTime(decimal inDate)
        {
            return ConvertToDate(inDate);
        }

        /// <summary>
        /// 日付変換(DateTime型)
        /// </summary>
        /// <param name="obj">日付項目</param>
        /// <returns>DateTime</returns>
        private static DateTime ConvertToDate(Object obj)
        {
            try
            {
                switch (obj.GetType().Name)
                {
                    case "String":
                        string strDate = obj.ToString().Replace("/", "").Replace(":", "").Replace(" ", "").Trim();
                        return DateTime.ParseExact(strDate.PadRight(14, '0'), "yyyyMMddHHmmss", null);

                    case "DateTime":
                        return (DateTime)obj;

                    case "Decimal":
                        return ConvertToDate(obj.ToString());

                    default:
                        throw new System.Exception();
                }
            }
            catch (System.Exception ex)
            {
                throw new Exception("共通関数内部エラーです", ex);
            }

        }
        #endregion
    }
}

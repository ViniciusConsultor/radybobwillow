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

        #region 空文字变换
        /// <summary>
        /// 空文字变换
        /// </summary>
        /// <param name="value">变换值</param>
        /// <returns></returns>
        public static string NullToEmpty(string value)
        {
            try
            {
                if (!string.IsNullOrEmpty(value))
                {
                    return value.Trim();
                }
                return "";
            }
            catch (System.Exception ex)
            {
                throw new SystemException("共通内部错误", ex);
            }
        }
        #endregion

        #region 半角空格变换
        /// <summary>
        /// 半角空格变换
        /// </summary>
        /// <param name="obj">变换值</param>
        /// <returns>文字列</returns>
        public static string NullToSpace(object obj)
        {
            try
            {

                if (obj == null) return " ";

                switch (obj.GetType().Name)
                {
                    case "String":
                        if (obj == null) return " ";
                        if (obj.ToString() == "") return " ";
                        return ToString(obj);

                    case "DateTime":
                        return DateToString(ToDateTime(obj), Constant.yyyy_MM_dd_HH_mm_ss);

                    case "Decimal":
                        return ToString(obj);

                    default:
                        throw new System.Exception();
                }

            }
            catch (System.Exception ex)
            {
                throw new SystemException("共通内部错误", ex);
            }
        }
        #endregion

        #region 0値変換
        /// <summary>
        /// 0値変換
        /// </summary>
        /// <param name="obj">変換値</param>
        /// <returns>数値</returns>
        public static decimal NullToZero(object obj)
        {
            try
            {
                if (obj == null) return 0;

                switch (obj.GetType().Name)
                {
                    case "String":
                        if (obj == null) return 0;
                        if (ToString(obj) == "") return 0;
                        return ToDecimal(obj);

                    case "DateTime":
                        return DateToDecimal(ToDateTime(obj));

                    case "Decimal":
                        return ToDecimal(obj);

                    default:
                        throw new System.Exception();
                }
            }
            catch (System.Exception ex)
            {
                throw new SystemException("共通内部错误", ex);
            }
        }
        #endregion

        #region 数据类型变换
        /// <summary>
        /// 数据类型变换object→string
        /// </summary>
        /// <param name="value">值</param>
        /// <returns>string</returns>
        internal static string ToString(object value)
        {
            if (value == System.DBNull.Value)
            {
                return null;
            }
            return Convert.ToString(value);
        }

        /// <summary>
        /// 数据类型变换object→decimal?
        /// </summary>
        /// <param name="value">值</param>
        /// <returns>decimal</returns>
        internal static decimal? ToNullDecimal(object value)
        {
            if (value == System.DBNull.Value)
            {
                return null;
            }
            return Convert.ToDecimal(value.ToString());
        }

        /// <summary>
        /// 数据类型变换object→decimal
        /// null的场合返回0
        /// </summary>
        /// <param name="value">值</param>
        /// <returns>decimal</returns>
        internal static decimal ToDecimal(object value)
        {
            if (value == System.DBNull.Value)
            {
                return 0;
            }
            return Convert.ToDecimal(value.ToString());
        }

        /// <summary>
        /// 数据类型变换object→Datetime?
        /// </summary>
        /// <param name="value">值</param>
        /// <returns>DateTime</returns>
        internal static DateTime? ToNullDateTime(object value)
        {
            if (value == System.DBNull.Value)
            {
                return null;
            }
            return Convert.ToDateTime(value.ToString());
        }

        /// <summary>
        /// 数据类型变换object→Datetime
        /// null的场合返回1800/01/01
        /// </summary>
        /// <param name="value">值</param>
        /// <returns>DateTime</returns>
        internal static DateTime ToDateTime(object value)
        {

            if (value == System.DBNull.Value)
            {
                return DateTime.Parse("1800/01/01");
            }
            return Convert.ToDateTime(value.ToString());
        }

        /// <summary>
        /// 日期变换
        /// </summary>
        /// <param name="inDate">日期项目</param>
        /// <param name="convertType">变换形式</param>
        /// <returns>变换后日期</returns>
        public static string DateToString(string inDate, string convertType)
        {
            return ConvertToString(inDate, convertType);
        }


        /// <summary>
        /// 日期变换(从decimal型变换到string型)
        /// </summary>
        /// <param name="inDate">日期项目</param>
        /// <param name="convertType">变换形式</param>
        /// <returns>变换后日期</returns>
        public static string DateToString(decimal inDate, string convertType)
        {
            return ConvertToString(inDate, convertType);
        }

        /// <summary>
        /// 日期变换(从DateTime型变换到string型)
        /// </summary>
        /// <param name="inDate">日期项目</param>
        /// <param name="convertType">变换形式</param>
        /// <returns>变换后日期</returns>
        public static string DateToString(DateTime inDate, string convertType)
        {
            return ConvertToString(inDate, convertType);
        }

        /// <summary>
        /// 日期变换(string型)
        /// </summary>
        /// <param name="obj">日期项目</param>
        /// <param name="convertTypes">变换形式</param>
        /// <returns>String</returns>
        private static string ConvertToString(Object obj, string convertTypes)
        {
            try
            {
                switch (convertTypes)
                {
                    case Constant.yyyyMMddHHmmss:
                        return ConvertToDate(obj).ToString("yyyyMMddHHmmss");
                    case Constant.yyyyMMdd:
                        return ConvertToDate(obj).ToString("yyyyMMdd");
                    case Constant.yyyy_MM_dd:
                        return ConvertToDate(obj).ToString("yyyy/MM/dd");
                    case Constant.HHmmss:
                        return ConvertToDate(obj).ToString("HHmmss");
                    case Constant.yyyy_MM_dd_HH_mm_ss:
                        return ConvertToDate(obj).ToString("yyyy/MM/dd HH:mm:ss");
                    default:
                        return ConvertToDate(obj).ToString("yyyyMMddHHmmss");
                }
            }
            catch (System.Exception ex)
            {
                throw new SystemException("共通内部错误", ex);
            }
        }

        /// <summary>
        /// 日期变换(从string型变换到decimal型)
        /// </summary>
        /// <param name="inDate">日期项目</param>
        /// <returns>变换后日期</returns>
        public static decimal DateToDecimal(string inDate)
        {
            return ConvertToDecimal(inDate);
        }

        /// <summary>
        /// 日期变换(从DateTime型变换到decimal型)
        /// </summary>
        /// <param name="inDate">日期项目</param>
        /// <returns>变换后日期</returns>
        public static decimal DateToDecimal(DateTime inDate)
        {
            return ConvertToDecimal(inDate);
        }

        /// <summary>
        /// 日期变换(decimal型)
        /// </summary>
        /// <param name="obj">日期项目</param>
        /// <returns>String</returns>
        private static decimal ConvertToDecimal(Object obj)
        {
            try
            {
                return Convert.ToDecimal(ConvertToString(obj, Constant.yyyyMMdd));
            }
            catch (System.Exception ex)
            {
                throw new SystemException("共通内部错误", ex);
            }
        }
        #endregion
    }
}

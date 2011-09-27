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


    }







}

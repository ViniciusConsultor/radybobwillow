using System;
using System.Collections;
using System.Threading;
using System.Collections.Generic;

namespace Com.GainWinSoft.Common
{
    public class LangUtils
    {
        public static String GetDefaultLanguage()
        {
            String defaultlang = System.Configuration.ConfigurationManager.AppSettings["defaultlanguage"];

            return defaultlang;
        }  

        public static IList<ConditionVo> GetLanguageList()
        {
            IList<ConditionVo> result = new List<ConditionVo>();

            result = (IList<ConditionVo>)ConditionUtils.Conditions[ConditionUtils.COND_LANGUAGE];
            return result;
        }

        public static String GetCurrentLanguage()
        {
            return Thread.CurrentThread.CurrentUICulture.Name;
        }
    }
}

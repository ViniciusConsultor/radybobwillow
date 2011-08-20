using System;
using System.Collections;

namespace Com.ChangeSoft.Common
{
    public class LangUtils
    {
        public static String GetDefaultLanguage()
        {
            String defaultlang = System.Configuration.ConfigurationManager.AppSettings["defaultlanguage"];

            return defaultlang;
        }  

        public static IList GetLanguageList()
        {
            IList result = new ArrayList();

            result = (IList)ConditionUtils.Conditions[ConditionUtils.COND_LANGUAGE];
            return result;
        }  
            
    }
}

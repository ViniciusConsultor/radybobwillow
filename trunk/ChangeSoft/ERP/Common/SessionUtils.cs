using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Com.GainWinSoft.Common
{

 
    public class SessionUtils
    {
        public const string COMMON_LOGIN_USER_INFO = "COMMON_LOGIN_USER_INFO";
        private static Hashtable SessionContext = new Hashtable();



        public static Object GetSession(string key)
        {
            Object result = SessionContext[key];
            return result;
        }

        public static void SetSession(string key, Object data)
        {
            SessionContext.Add(key, data);
        }
        public static void RemoveSession(string key)
        {
            SessionContext.Remove(key);
        }

    }
}

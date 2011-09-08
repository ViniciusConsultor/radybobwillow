using System.Resources;
using System.Reflection;

namespace Com.GainWinSoft.Common
{
    public class MessageUtils
    {
        public static string GetMessage(string messageid, params string[] values)
        {
            string message="";

            ResourceManager rm = new System.Resources.ResourceManager("Com.ChangeSoft.Common.Resources.Message", Assembly.GetExecutingAssembly());
            message = rm.GetString(messageid);

            for (int i = 0; i < values.Length; i++)
            {
                message = message.Replace("%"+(i+1),values[i]);
            }
            return message;
        }
    }
}

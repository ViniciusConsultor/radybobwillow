using System.Resources;
using System.Reflection;

namespace Com.ChangeSoft.Common
{
    public class ResourcesUtils
    {
        public static object GetResource(string key)
        {

            return Properties.Resources.ResourceManager.GetObject(key);
        }
    }
}

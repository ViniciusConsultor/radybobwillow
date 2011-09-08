using System;
using Castle.Windsor;
using Castle.Windsor.Configuration.Interpreters;
using Castle.MicroKernel;

namespace Com.GainWinSoft.Common
{
    public class ComponentLocator 
    {
        private WindsorContainer windsor;
        private IKernel kernel;
        private static ComponentLocator instance; 

        private ComponentLocator()
        {
            Castle.Core.Resource.ConfigResource source = new Castle.Core.Resource.ConfigResource();
            XmlInterpreter interpreter = new XmlInterpreter(source);
            windsor = new WindsorContainer(interpreter);
            kernel = windsor.Kernel;

        }
        public static ComponentLocator Instance()
        {
            if (instance==null)
            {
                instance = new ComponentLocator();
            }

            return instance;
        }

        public T Resolve<T>()
        {
            return  (T)windsor.Resolve<T>();
        }

        public object Resolve(Type service)
        {
            return windsor.Resolve(service); 
        }
        public object Resolve(String key,Type service)
        {
            return windsor.Resolve(key,service);
        }


        public void Dispose()
        {
            kernel.Dispose();
        }
    }
}

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
            //todo 本来想这里用个singleton的话，就不用每次去读configuration了。不知道为什么，用了singleton的话，
            //T Resolve<T>()或者factrory.create都不会重新new
            //一个实例，导致一个画面打开再关闭的时候，还是取得原来的实例，但是原来的实例里IsDisposed却是true
            //导致画面打开失败。
            /*
                <component id="FExchangeRate"
                service="Com.GainWinSoft.Common.IBaseContent,Com.GainWinSoft.Common"
                    type="Com.GainWinSoft.ERP.ExchangeRate.FrmExchangeRate, Com.GainWinSoft.ERP.ExchangeRate"
                    lifestyle="transient" />
             * Windsor 默认取得组件是singleton模式的，组件定义的时候lifestyle="transient"  表示每次都new一个实例。
             * 完美解决。

             */
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
        public void Release(object component)
        {
            windsor.Release(component);
        }

        public void Dispose()
        {
            kernel.Dispose();
        }
    }
}

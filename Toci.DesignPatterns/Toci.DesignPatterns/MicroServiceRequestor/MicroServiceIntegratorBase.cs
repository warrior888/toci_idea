using System;
using System.Collections.Generic;
using System.Text;
using Toci.DesignPatterns.Interfaces.MicroServiceRequestor;

namespace Toci.DesignPatterns.MicroServiceRequestor
{
    public abstract class MicroServiceIntegratorBase<TProxy, TServiceBusinessLogicBase> : IMicroServiceIntegrator<TProxy, TServiceBusinessLogicBase>
        where TProxy : ProxyBase
        where TServiceBusinessLogicBase : ServiceBusinessLogicBase
    {
        protected TProxy Proxy;

        public abstract IBusinessLogicEntity Run(IServiceResponseEntity serviceResponseEntity);

        protected virtual IServiceResponseEntity Request()
        {
            // todo instantiate proxy and add request

            return Proxy.Request();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Toci.DesignPatterns.Interfaces.MicroServiceRequestor
{
    public interface IMicroServiceIntegrator<out TProxy, out TBusinessLogic> 
        where TProxy : IProxy<IServiceEntity, IServiceResponseEntity>
        where TBusinessLogic : IServiceBusinessLogic<IBusinessLogicEntity, IServiceResponseEntity>
    {
        IBusinessLogicEntity Run(IServiceResponseEntity serviceResponseEntity);
    }
}

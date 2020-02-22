using System;
using System.Collections.Generic;
using System.Text;

namespace Toci.DesignPatterns.Interfaces.MicroServiceRequestor
{
    public interface IServiceBusinessLogic<out TBIEntity, out TServiceResponseEntity> 
        where TBIEntity : IBusinessLogicEntity
        where TServiceResponseEntity : IServiceResponseEntity
    {
        TBIEntity Execute();
    }
}

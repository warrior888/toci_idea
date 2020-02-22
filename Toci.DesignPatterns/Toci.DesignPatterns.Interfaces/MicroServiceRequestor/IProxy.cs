using System;
using System.Collections.Generic;
using System.Text;

namespace Toci.DesignPatterns.Interfaces.MicroServiceRequestor
{
    public interface IProxy<out TServiceRequestEntity, out TServiceResponseEntity> 
        where TServiceRequestEntity : IServiceEntity
        where TServiceResponseEntity : IServiceResponseEntity
    {
        TServiceResponseEntity Request();
    }
}

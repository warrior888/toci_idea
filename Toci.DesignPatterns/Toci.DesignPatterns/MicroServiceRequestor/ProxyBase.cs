using System;
using System.Collections.Generic;
using System.Text;
using Toci.DesignPatterns.Interfaces.MicroServiceRequestor;

namespace Toci.DesignPatterns.MicroServiceRequestor
{
    public abstract class ProxyBase : IProxy<ServiceEntityBase, ServiceResponseEntityBase>
    {
        protected ServiceEntityBase requestEntity;

        protected ProxyBase(ServiceEntityBase serviceReqestEntity)
        {
            requestEntity = serviceReqestEntity;
        }

        public abstract ServiceResponseEntityBase Request();
    }
}

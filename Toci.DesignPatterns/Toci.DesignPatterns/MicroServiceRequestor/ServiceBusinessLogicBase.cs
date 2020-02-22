using System;
using System.Collections.Generic;
using System.Text;
using Toci.DesignPatterns.Interfaces.MicroServiceRequestor;

namespace Toci.DesignPatterns.MicroServiceRequestor
{
    public abstract class ServiceBusinessLogicBase : IServiceBusinessLogic<BusinessLogicEntityBase, ServiceResponseEntityBase>
    {
        protected ServiceResponseEntityBase serviceResponseEntityBase;

        protected ServiceBusinessLogicBase(ServiceResponseEntityBase serviceResponse)
        {
            serviceResponseEntityBase = serviceResponse;
        }
        public abstract BusinessLogicEntityBase Execute();
    }
}

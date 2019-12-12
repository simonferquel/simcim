using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMCoolingDevice : CIMLogicalDevice
    {
        protected CIMCoolingDevice()
        {
        }

        protected CIMCoolingDevice(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Boolean? ActiveCooling
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("ActiveCooling", out result);
                return result;
            }
        }
    }
}
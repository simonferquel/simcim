using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMProtocolControllerForUnit : CIMProtocolControllerForDevice
    {
        protected CIMProtocolControllerForUnit()
        {
        }

        protected CIMProtocolControllerForUnit(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16? DeviceAccess
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("DeviceAccess", out result);
                return result;
            }

            set
            {
                this.SetProperty("DeviceAccess", value);
            }
        }
    }
}
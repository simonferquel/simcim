using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmFlexIoDevice : CIMLogicalDevice
    {
        public MsvmFlexIoDevice()
        {
        }

        public MsvmFlexIoDevice(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String[] EmulatorConfiguration
        {
            get
            {
                System.String[] result;
                this.GetProperty("EmulatorConfiguration", out result);
                return result;
            }
        }

        public System.String EmulatorId
        {
            get
            {
                System.String result;
                this.GetProperty("EmulatorId", out result);
                return result;
            }
        }
    }
}
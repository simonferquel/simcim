using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmPciExpress : CIMLogicalDevice
    {
        public MsvmPciExpress()
        {
        }

        public MsvmPciExpress(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String DeviceInstancePath
        {
            get
            {
                System.String result;
                this.GetProperty("DeviceInstancePath", out result);
                return result;
            }
        }

        public System.UInt16? FunctionNumber
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("FunctionNumber", out result);
                return result;
            }
        }

        public System.String LocationPath
        {
            get
            {
                System.String result;
                this.GetProperty("LocationPath", out result);
                return result;
            }
        }
    }
}
using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmResourcePoolConfigurationCapabilities : CIMCapabilities
    {
        public MsvmResourcePoolConfigurationCapabilities()
        {
        }

        public MsvmResourcePoolConfigurationCapabilities(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32[] AsynchronousMethodsSupported
        {
            get
            {
                System.UInt32[] result;
                this.GetProperty("AsynchronousMethodsSupported", out result);
                return result;
            }

            set
            {
                this.SetProperty("AsynchronousMethodsSupported", value);
            }
        }

        public System.UInt32[] SynchronousMethodsSupported
        {
            get
            {
                System.UInt32[] result;
                this.GetProperty("SynchronousMethodsSupported", out result);
                return result;
            }

            set
            {
                this.SetProperty("SynchronousMethodsSupported", value);
            }
        }
    }
}
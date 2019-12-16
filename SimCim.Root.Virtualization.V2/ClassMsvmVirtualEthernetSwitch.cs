using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmVirtualEthernetSwitch : CIMComputerSystem
    {
        public MsvmVirtualEthernetSwitch()
        {
        }

        public MsvmVirtualEthernetSwitch(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? MaxIOVOffloads
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaxIOVOffloads", out result);
                return result;
            }
        }

        public System.UInt32? MaxVMQOffloads
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaxVMQOffloads", out result);
                return result;
            }

            set
            {
                this.SetProperty("MaxVMQOffloads", value);
            }
        }
    }
}
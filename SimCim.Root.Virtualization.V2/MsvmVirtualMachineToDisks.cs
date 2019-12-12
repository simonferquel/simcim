using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmVirtualMachineToDisks : GenericInfrastructureObject
    {
        public MsvmVirtualMachineToDisks()
        {
        }

        public MsvmVirtualMachineToDisks(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String[] DisksToExport
        {
            get
            {
                System.String[] result;
                this.GetProperty("DisksToExport", out result);
                return result;
            }
        }

        public System.String VirtualMachineId
        {
            get
            {
                System.String result;
                this.GetProperty("VirtualMachineId", out result);
                return result;
            }

            set
            {
                this.SetProperty("VirtualMachineId", value);
            }
        }
    }
}
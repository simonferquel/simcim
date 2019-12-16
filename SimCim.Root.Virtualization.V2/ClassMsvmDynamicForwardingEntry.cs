using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmDynamicForwardingEntry : CIMDynamicForwardingEntry
    {
        public MsvmDynamicForwardingEntry()
        {
        }

        public MsvmDynamicForwardingEntry(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16? VlanId
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("VlanId", out result);
                return result;
            }

            set
            {
                this.SetProperty("VlanId", value);
            }
        }
    }
}
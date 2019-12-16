using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmResourceAllocationSettingData : CIMResourceAllocationSettingData
    {
        public MsvmResourceAllocationSettingData()
        {
        }

        public MsvmResourceAllocationSettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String[] VirtualSystemIdentifiers
        {
            get
            {
                System.String[] result;
                this.GetProperty("VirtualSystemIdentifiers", out result);
                return result;
            }
        }
    }
}
using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmVirtualLogicalUnitSettingData : CIMResourceAllocationSettingData
    {
        public MsvmVirtualLogicalUnitSettingData()
        {
        }

        public MsvmVirtualLogicalUnitSettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String StorageSubsystemType
        {
            get
            {
                System.String result;
                this.GetProperty("StorageSubsystemType", out result);
                return result;
            }

            set
            {
                this.SetProperty("StorageSubsystemType", value);
            }
        }
    }
}
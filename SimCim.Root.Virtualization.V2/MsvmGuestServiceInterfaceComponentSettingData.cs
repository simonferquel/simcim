using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmGuestServiceInterfaceComponentSettingData : CIMResourceAllocationSettingData
    {
        public MsvmGuestServiceInterfaceComponentSettingData()
        {
        }

        public MsvmGuestServiceInterfaceComponentSettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16? DefaultEnabledStatePolicy
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("DefaultEnabledStatePolicy", out result);
                return result;
            }
        }

        public System.UInt16? EnabledState
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("EnabledState", out result);
                return result;
            }
        }

        public IEnumerable<CIMSettingData> ResolveMsvmGuestServiceInterfaceSettingDataComponentPartComponent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_GuestServiceInterfaceSettingDataComponent", "CIM_SettingData", "GroupComponent", "PartComponent");
            return instances.Select(i => (CIMSettingData)InfrastuctureObjectScope.Mapper.Create(i));
        }
    }
}
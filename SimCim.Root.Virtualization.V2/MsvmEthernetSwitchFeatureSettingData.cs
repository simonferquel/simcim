using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class MsvmEthernetSwitchFeatureSettingData : MsvmFeatureSettingData
    {
        protected MsvmEthernetSwitchFeatureSettingData()
        {
        }

        protected MsvmEthernetSwitchFeatureSettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public MsvmVirtualEthernetSwitchSettingData ResolveMsvmVirtualEthernetSwitchSettingDataComponentGroupComponent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_VirtualEthernetSwitchSettingDataComponent", "Msvm_VirtualEthernetSwitchSettingData", "PartComponent", "GroupComponent");
            return instances.Select(i => (MsvmVirtualEthernetSwitchSettingData)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }
    }
}
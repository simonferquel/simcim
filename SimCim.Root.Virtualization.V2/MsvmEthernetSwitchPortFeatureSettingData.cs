using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class MsvmEthernetSwitchPortFeatureSettingData : MsvmFeatureSettingData
    {
        protected MsvmEthernetSwitchPortFeatureSettingData()
        {
        }

        protected MsvmEthernetSwitchPortFeatureSettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public IEnumerable<MsvmEthernetPortAllocationSettingData> ResolveMsvmEthernetPortSettingDataComponentGroupComponent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_EthernetPortSettingDataComponent", "Msvm_EthernetPortAllocationSettingData", "PartComponent", "GroupComponent");
            return instances.Select(i => (MsvmEthernetPortAllocationSettingData)InfrastuctureObjectScope.Mapper.Create(i));
        }
    }
}
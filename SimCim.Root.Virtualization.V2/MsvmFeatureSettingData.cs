using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class MsvmFeatureSettingData : CIMSettingData
    {
        protected MsvmFeatureSettingData()
        {
        }

        protected MsvmFeatureSettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public IEnumerable<MsvmEthernetSwitchFeatureCapabilities> ResolveMsvmFeatureSettingsDefineCapabilitiesGroupComponent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_FeatureSettingsDefineCapabilities", "Msvm_EthernetSwitchFeatureCapabilities", "PartComponent", "GroupComponent");
            return instances.Select(i => (MsvmEthernetSwitchFeatureCapabilities)InfrastuctureObjectScope.Mapper.Create(i));
        }
    }
}
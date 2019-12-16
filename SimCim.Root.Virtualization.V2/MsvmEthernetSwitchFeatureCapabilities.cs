using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmEthernetSwitchFeatureCapabilities : CIMCapabilities
    {
        public MsvmEthernetSwitchFeatureCapabilities()
        {
        }

        public MsvmEthernetSwitchFeatureCapabilities(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16? Applicability
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("Applicability", out result);
                return result;
            }
        }

        public System.String FeatureId
        {
            get
            {
                System.String result;
                this.GetProperty("FeatureId", out result);
                return result;
            }
        }

        public System.String Version
        {
            get
            {
                System.String result;
                this.GetProperty("Version", out result);
                return result;
            }
        }

        public IEnumerable<MsvmFeatureSettingData> ResolveMsvmFeatureSettingsDefineCapabilitiesPartComponent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_FeatureSettingsDefineCapabilities", "Msvm_FeatureSettingData", "GroupComponent", "PartComponent");
            return instances.Select(i => (MsvmFeatureSettingData)InfrastuctureObjectScope.Mapper.Create(i));
        }

        public IEnumerable<MsvmInstalledEthernetSwitchExtension> ResolveMsvmEthernetSwitchExtensionCapabilitiesManagedElement()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_EthernetSwitchExtensionCapabilities", "Msvm_InstalledEthernetSwitchExtension", "Capabilities", "ManagedElement");
            return instances.Select(i => (MsvmInstalledEthernetSwitchExtension)InfrastuctureObjectScope.Mapper.Create(i));
        }
    }
}
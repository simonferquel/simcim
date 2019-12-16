using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMCapabilities : CIMManagedElement
    {
        protected CIMCapabilities()
        {
        }

        protected CIMCapabilities(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public IEnumerable<CIMSettingData> ResolveCIMSettingsDefineCapabilitiesPartComponent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "CIM_SettingsDefineCapabilities", "CIM_SettingData", "GroupComponent", "PartComponent");
            return instances.Select(i => (CIMSettingData)InfrastuctureObjectScope.Mapper.Create(i));
        }

        public IEnumerable<CIMSettingData> ResolveMsvmSettingsDefineCapabilitiesPartComponent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_SettingsDefineCapabilities", "CIM_SettingData", "GroupComponent", "PartComponent");
            return instances.Select(i => (CIMSettingData)InfrastuctureObjectScope.Mapper.Create(i));
        }

        public CIMManagedElement ResolveCIMElementCapabilitiesManagedElement()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "CIM_ElementCapabilities", "CIM_ManagedElement", "Capabilities", "ManagedElement");
            return instances.Select(i => (CIMManagedElement)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public IEnumerable<CIMManagedElement> ResolveMsvmElementCapabilitiesManagedElement()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_ElementCapabilities", "CIM_ManagedElement", "Capabilities", "ManagedElement");
            return instances.Select(i => (CIMManagedElement)InfrastuctureObjectScope.Mapper.Create(i));
        }
    }
}
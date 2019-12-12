using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMSettingData : CIMManagedElement
    {
        protected CIMSettingData()
        {
        }

        protected CIMSettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public CIMManagedElement ResolveCIMElementSettingDataManagedElement()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "CIM_ElementSettingData", "CIM_ManagedElement", "SettingData", "ManagedElement");
            return instances.Select(i => (CIMManagedElement)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public CIMManagedElement ResolveMsvmElementSettingDataManagedElement()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_ElementSettingData", "CIM_ManagedElement", "SettingData", "ManagedElement");
            return instances.Select(i => (CIMManagedElement)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public MsvmGuestServiceInterfaceComponentSettingData ResolveMsvmGuestServiceInterfaceSettingDataComponentGroupComponent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_GuestServiceInterfaceSettingDataComponent", "Msvm_GuestServiceInterfaceComponentSettingData", "PartComponent", "GroupComponent");
            return instances.Select(i => (MsvmGuestServiceInterfaceComponentSettingData)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public CIMCapabilities ResolveCIMSettingsDefineCapabilitiesGroupComponent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "CIM_SettingsDefineCapabilities", "CIM_Capabilities", "PartComponent", "GroupComponent");
            return instances.Select(i => (CIMCapabilities)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public CIMCapabilities ResolveMsvmSettingsDefineCapabilitiesGroupComponent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_SettingsDefineCapabilities", "CIM_Capabilities", "PartComponent", "GroupComponent");
            return instances.Select(i => (CIMCapabilities)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public CIMManagedElement ResolveCIMSettingsDefineStateManagedElement()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "CIM_SettingsDefineState", "CIM_ManagedElement", "SettingData", "ManagedElement");
            return instances.Select(i => (CIMManagedElement)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public CIMManagedElement ResolveMsvmSettingsDefineStateManagedElement()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_SettingsDefineState", "CIM_ManagedElement", "SettingData", "ManagedElement");
            return instances.Select(i => (CIMManagedElement)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }
    }
}
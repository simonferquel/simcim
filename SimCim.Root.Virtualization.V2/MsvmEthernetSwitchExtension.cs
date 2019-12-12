using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmEthernetSwitchExtension : CIMEnabledLogicalElement
    {
        public MsvmEthernetSwitchExtension()
        {
        }

        public MsvmEthernetSwitchExtension(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String CreationClassName
        {
            get
            {
                System.String result;
                this.GetProperty("CreationClassName", out result);
                return result;
            }

            set
            {
                this.SetProperty("CreationClassName", value);
            }
        }

        public System.Byte? ExtensionType
        {
            get
            {
                System.Byte? result;
                this.GetProperty("ExtensionType", out result);
                return result;
            }
        }

        public System.String SystemCreationClassName
        {
            get
            {
                System.String result;
                this.GetProperty("SystemCreationClassName", out result);
                return result;
            }

            set
            {
                this.SetProperty("SystemCreationClassName", value);
            }
        }

        public System.String SystemName
        {
            get
            {
                System.String result;
                this.GetProperty("SystemName", out result);
                return result;
            }

            set
            {
                this.SetProperty("SystemName", value);
            }
        }

        public System.String Vendor
        {
            get
            {
                System.String result;
                this.GetProperty("Vendor", out result);
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

        public MsvmInstalledEthernetSwitchExtension ResolveMsvmConcreteDependencyAntecedent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_ConcreteDependency", "Msvm_InstalledEthernetSwitchExtension", "Dependent", "Antecedent");
            return instances.Select(i => (MsvmInstalledEthernetSwitchExtension)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public MsvmEthernetSwitchExtension ResolveMsvmParentEthernetSwitchExtensionDependent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_ParentEthernetSwitchExtension", "Msvm_EthernetSwitchExtension", "Antecedent", "Dependent");
            return instances.Select(i => (MsvmEthernetSwitchExtension)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public MsvmEthernetSwitchExtension ResolveMsvmParentEthernetSwitchExtensionAntecedent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_ParentEthernetSwitchExtension", "Msvm_EthernetSwitchExtension", "Dependent", "Antecedent");
            return instances.Select(i => (MsvmEthernetSwitchExtension)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public MsvmVirtualEthernetSwitch ResolveMsvmHostedEthernetSwitchExtensionAntecedent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_HostedEthernetSwitchExtension", "Msvm_VirtualEthernetSwitch", "Dependent", "Antecedent");
            return instances.Select(i => (MsvmVirtualEthernetSwitch)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }
    }
}
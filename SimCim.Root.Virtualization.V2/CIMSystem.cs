using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMSystem : CIMEnabledLogicalElement
    {
        protected CIMSystem()
        {
        }

        protected CIMSystem(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
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

        public System.String[] IdentifyingDescriptions
        {
            get
            {
                System.String[] result;
                this.GetProperty("IdentifyingDescriptions", out result);
                return result;
            }

            set
            {
                this.SetProperty("IdentifyingDescriptions", value);
            }
        }

        public System.String NameFormat
        {
            get
            {
                System.String result;
                this.GetProperty("NameFormat", out result);
                return result;
            }

            set
            {
                this.SetProperty("NameFormat", value);
            }
        }

        public System.String[] OtherIdentifyingInfo
        {
            get
            {
                System.String[] result;
                this.GetProperty("OtherIdentifyingInfo", out result);
                return result;
            }

            set
            {
                this.SetProperty("OtherIdentifyingInfo", value);
            }
        }

        public System.String PrimaryOwnerContact
        {
            get
            {
                System.String result;
                this.GetProperty("PrimaryOwnerContact", out result);
                return result;
            }

            set
            {
                this.SetProperty("PrimaryOwnerContact", value);
            }
        }

        public System.String PrimaryOwnerName
        {
            get
            {
                System.String result;
                this.GetProperty("PrimaryOwnerName", out result);
                return result;
            }

            set
            {
                this.SetProperty("PrimaryOwnerName", value);
            }
        }

        public System.String[] Roles
        {
            get
            {
                System.String[] result;
                this.GetProperty("Roles", out result);
                return result;
            }

            set
            {
                this.SetProperty("Roles", value);
            }
        }

        public IEnumerable<CIMManagedSystemElement> ResolveCIMSystemComponentPartComponent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "CIM_SystemComponent", "CIM_ManagedSystemElement", "GroupComponent", "PartComponent");
            return instances.Select(i => (CIMManagedSystemElement)InfrastuctureObjectScope.Mapper.Create(i));
        }

        public IEnumerable<CIMManagedSystemElement> ResolveMsvmSystemComponentPartComponent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_SystemComponent", "CIM_ManagedSystemElement", "GroupComponent", "PartComponent");
            return instances.Select(i => (CIMManagedSystemElement)InfrastuctureObjectScope.Mapper.Create(i));
        }

        public IEnumerable<CIMLogicalDevice> ResolveCIMSystemDevicePartComponent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "CIM_SystemDevice", "CIM_LogicalDevice", "GroupComponent", "PartComponent");
            return instances.Select(i => (CIMLogicalDevice)InfrastuctureObjectScope.Mapper.Create(i));
        }

        public IEnumerable<CIMLogicalDevice> ResolveMsvmSystemDevicePartComponent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_SystemDevice", "CIM_LogicalDevice", "GroupComponent", "PartComponent");
            return instances.Select(i => (CIMLogicalDevice)InfrastuctureObjectScope.Mapper.Create(i));
        }

        public IEnumerable<CIMResourcePool> ResolveCIMHostedResourcePoolPartComponent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "CIM_HostedResourcePool", "CIM_ResourcePool", "GroupComponent", "PartComponent");
            return instances.Select(i => (CIMResourcePool)InfrastuctureObjectScope.Mapper.Create(i));
        }

        public CIMService ResolveCIMHostedServiceDependent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "CIM_HostedService", "CIM_Service", "Antecedent", "Dependent");
            return instances.Select(i => (CIMService)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public CIMService ResolveMsvmHostedServiceDependent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_HostedService", "CIM_Service", "Antecedent", "Dependent");
            return instances.Select(i => (CIMService)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public CIMServiceAccessPoint ResolveCIMHostedAccessPointDependent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "CIM_HostedAccessPoint", "CIM_ServiceAccessPoint", "Antecedent", "Dependent");
            return instances.Select(i => (CIMServiceAccessPoint)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }
    }
}
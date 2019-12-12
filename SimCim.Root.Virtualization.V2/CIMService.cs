using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMService : CIMEnabledLogicalElement
    {
        protected CIMService()
        {
        }

        protected CIMService(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
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

        public System.Boolean? Started
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("Started", out result);
                return result;
            }

            set
            {
                this.SetProperty("Started", value);
            }
        }

        public System.String StartMode
        {
            get
            {
                System.String result;
                this.GetProperty("StartMode", out result);
                return result;
            }

            set
            {
                this.SetProperty("StartMode", value);
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

        public System.UInt32 StartService()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "StartService", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 StopService()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "StopService", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public CIMManagedElement ResolveCIMServiceAffectsElementAffectedElement()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "CIM_ServiceAffectsElement", "CIM_ManagedElement", "AffectingElement", "AffectedElement");
            return instances.Select(i => (CIMManagedElement)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public CIMManagedElement ResolveMsvmServiceAffectsElementAffectedElement()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_ServiceAffectsElement", "CIM_ManagedElement", "AffectingElement", "AffectedElement");
            return instances.Select(i => (CIMManagedElement)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public IEnumerable<CIMService> ResolveCIMServiceComponentPartComponent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "CIM_ServiceComponent", "CIM_Service", "GroupComponent", "PartComponent");
            return instances.Select(i => (CIMService)InfrastuctureObjectScope.Mapper.Create(i));
        }

        public CIMService ResolveCIMServiceComponentGroupComponent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "CIM_ServiceComponent", "CIM_Service", "PartComponent", "GroupComponent");
            return instances.Select(i => (CIMService)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public CIMSystem ResolveCIMHostedServiceAntecedent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "CIM_HostedService", "CIM_System", "Dependent", "Antecedent");
            return instances.Select(i => (CIMSystem)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public CIMSystem ResolveMsvmHostedServiceAntecedent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_HostedService", "CIM_System", "Dependent", "Antecedent");
            return instances.Select(i => (CIMSystem)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public MsvmVirtualEthernetSwitch ResolveMsvmHostedSwitchServiceAntecedent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_HostedSwitchService", "Msvm_VirtualEthernetSwitch", "Dependent", "Antecedent");
            return instances.Select(i => (MsvmVirtualEthernetSwitch)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public CIMServiceAccessPoint ResolveCIMServiceSAPDependencyAntecedent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "CIM_ServiceSAPDependency", "CIM_ServiceAccessPoint", "Dependent", "Antecedent");
            return instances.Select(i => (CIMServiceAccessPoint)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }
    }
}
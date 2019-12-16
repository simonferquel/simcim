using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMServiceAccessPoint : CIMEnabledLogicalElement
    {
        protected CIMServiceAccessPoint()
        {
        }

        protected CIMServiceAccessPoint(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
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

        public CIMSystem ResolveCIMHostedAccessPointAntecedent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "CIM_HostedAccessPoint", "CIM_System", "Dependent", "Antecedent");
            return instances.Select(i => (CIMSystem)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public CIMService ResolveCIMServiceSAPDependencyDependent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "CIM_ServiceSAPDependency", "CIM_Service", "Antecedent", "Dependent");
            return instances.Select(i => (CIMService)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public CIMServiceAccessPoint ResolveCIMSAPSAPDependencyDependent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "CIM_SAPSAPDependency", "CIM_ServiceAccessPoint", "Antecedent", "Dependent");
            return instances.Select(i => (CIMServiceAccessPoint)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public CIMServiceAccessPoint ResolveCIMSAPSAPDependencyAntecedent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "CIM_SAPSAPDependency", "CIM_ServiceAccessPoint", "Dependent", "Antecedent");
            return instances.Select(i => (CIMServiceAccessPoint)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public CIMServiceAccessPoint ResolveCIMActiveConnectionDependent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "CIM_ActiveConnection", "CIM_ServiceAccessPoint", "Antecedent", "Dependent");
            return instances.Select(i => (CIMServiceAccessPoint)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public CIMServiceAccessPoint ResolveCIMActiveConnectionAntecedent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "CIM_ActiveConnection", "CIM_ServiceAccessPoint", "Dependent", "Antecedent");
            return instances.Select(i => (CIMServiceAccessPoint)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public CIMProtocolEndpoint ResolveCIMBindsToAntecedent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "CIM_BindsTo", "CIM_ProtocolEndpoint", "Dependent", "Antecedent");
            return instances.Select(i => (CIMProtocolEndpoint)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public CIMLANEndpoint ResolveCIMBindsToLANEndpointAntecedent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "CIM_BindsToLANEndpoint", "CIM_LANEndpoint", "Dependent", "Antecedent");
            return instances.Select(i => (CIMLANEndpoint)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public CIMLogicalDevice ResolveCIMDeviceSAPImplementationAntecedent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "CIM_DeviceSAPImplementation", "CIM_LogicalDevice", "Dependent", "Antecedent");
            return instances.Select(i => (CIMLogicalDevice)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public CIMLogicalDevice ResolveMsvmDeviceSAPImplementationAntecedent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_DeviceSAPImplementation", "CIM_LogicalDevice", "Dependent", "Antecedent");
            return instances.Select(i => (CIMLogicalDevice)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }
    }
}
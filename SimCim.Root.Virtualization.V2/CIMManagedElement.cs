using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMManagedElement : GenericInfrastructureObject
    {
        protected CIMManagedElement()
        {
        }

        protected CIMManagedElement(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String Caption
        {
            get
            {
                System.String result;
                this.GetProperty("Caption", out result);
                return result;
            }

            set
            {
                this.SetProperty("Caption", value);
            }
        }

        public System.String Description
        {
            get
            {
                System.String result;
                this.GetProperty("Description", out result);
                return result;
            }

            set
            {
                this.SetProperty("Description", value);
            }
        }

        public System.String ElementName
        {
            get
            {
                System.String result;
                this.GetProperty("ElementName", out result);
                return result;
            }

            set
            {
                this.SetProperty("ElementName", value);
            }
        }

        public System.String InstanceID
        {
            get
            {
                System.String result;
                this.GetProperty("InstanceID", out result);
                return result;
            }

            set
            {
                this.SetProperty("InstanceID", value);
            }
        }

        public CIMManagedElement ResolveCIMLogicalIdentitySystemElement()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "CIM_LogicalIdentity", "CIM_ManagedElement", "SameElement", "SystemElement");
            return instances.Select(i => (CIMManagedElement)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public CIMManagedElement ResolveCIMLogicalIdentitySameElement()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "CIM_LogicalIdentity", "CIM_ManagedElement", "SystemElement", "SameElement");
            return instances.Select(i => (CIMManagedElement)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public CIMManagedElement ResolveMsvmLogicalIdentitySystemElement()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_LogicalIdentity", "CIM_ManagedElement", "SameElement", "SystemElement");
            return instances.Select(i => (CIMManagedElement)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public CIMManagedElement ResolveMsvmLogicalIdentitySameElement()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_LogicalIdentity", "CIM_ManagedElement", "SystemElement", "SameElement");
            return instances.Select(i => (CIMManagedElement)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public CIMSettingData ResolveCIMElementSettingDataSettingData()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "CIM_ElementSettingData", "CIM_SettingData", "ManagedElement", "SettingData");
            return instances.Select(i => (CIMSettingData)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public CIMSettingData ResolveMsvmElementSettingDataSettingData()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_ElementSettingData", "CIM_SettingData", "ManagedElement", "SettingData");
            return instances.Select(i => (CIMSettingData)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public CIMService ResolveCIMServiceAffectsElementAffectingElement()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "CIM_ServiceAffectsElement", "CIM_Service", "AffectedElement", "AffectingElement");
            return instances.Select(i => (CIMService)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public CIMService ResolveMsvmServiceAffectsElementAffectingElement()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_ServiceAffectsElement", "CIM_Service", "AffectedElement", "AffectingElement");
            return instances.Select(i => (CIMService)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public CIMCapabilities ResolveCIMElementCapabilitiesCapabilities()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "CIM_ElementCapabilities", "CIM_Capabilities", "ManagedElement", "Capabilities");
            return instances.Select(i => (CIMCapabilities)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public CIMCapabilities ResolveMsvmElementCapabilitiesCapabilities()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_ElementCapabilities", "CIM_Capabilities", "ManagedElement", "Capabilities");
            return instances.Select(i => (CIMCapabilities)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public IEnumerable<CIMManagedElement> ResolveCIMComponentPartComponent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "CIM_Component", "CIM_ManagedElement", "GroupComponent", "PartComponent");
            return instances.Select(i => (CIMManagedElement)InfrastuctureObjectScope.Mapper.Create(i));
        }

        public CIMManagedElement ResolveCIMComponentGroupComponent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "CIM_Component", "CIM_ManagedElement", "PartComponent", "GroupComponent");
            return instances.Select(i => (CIMManagedElement)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public IEnumerable<CIMManagedElement> ResolveMsvmBootSourceComponentPartComponent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_BootSourceComponent", "CIM_ManagedElement", "GroupComponent", "PartComponent");
            return instances.Select(i => (CIMManagedElement)InfrastuctureObjectScope.Mapper.Create(i));
        }

        public CIMManagedElement ResolveMsvmBootSourceComponentGroupComponent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_BootSourceComponent", "CIM_ManagedElement", "PartComponent", "GroupComponent");
            return instances.Select(i => (CIMManagedElement)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public IEnumerable<CIMManagedElement> ResolveCIMConcreteComponentPartComponent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "CIM_ConcreteComponent", "CIM_ManagedElement", "GroupComponent", "PartComponent");
            return instances.Select(i => (CIMManagedElement)InfrastuctureObjectScope.Mapper.Create(i));
        }

        public CIMManagedElement ResolveCIMConcreteComponentGroupComponent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "CIM_ConcreteComponent", "CIM_ManagedElement", "PartComponent", "GroupComponent");
            return instances.Select(i => (CIMManagedElement)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public IEnumerable<CIMManagedElement> ResolveMsvmConcreteComponentPartComponent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_ConcreteComponent", "CIM_ManagedElement", "GroupComponent", "PartComponent");
            return instances.Select(i => (CIMManagedElement)InfrastuctureObjectScope.Mapper.Create(i));
        }

        public CIMManagedElement ResolveMsvmConcreteComponentGroupComponent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_ConcreteComponent", "CIM_ManagedElement", "PartComponent", "GroupComponent");
            return instances.Select(i => (CIMManagedElement)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public CIMSettingData ResolveCIMSettingsDefineStateSettingData()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "CIM_SettingsDefineState", "CIM_SettingData", "ManagedElement", "SettingData");
            return instances.Select(i => (CIMSettingData)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public CIMSettingData ResolveMsvmSettingsDefineStateSettingData()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_SettingsDefineState", "CIM_SettingData", "ManagedElement", "SettingData");
            return instances.Select(i => (CIMSettingData)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public CIMCollection ResolveCIMMemberOfCollectionCollection()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "CIM_MemberOfCollection", "CIM_Collection", "Member", "Collection");
            return instances.Select(i => (CIMCollection)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public CIMManagedElement ResolveCIMDependencyDependent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "CIM_Dependency", "CIM_ManagedElement", "Antecedent", "Dependent");
            return instances.Select(i => (CIMManagedElement)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public CIMManagedElement ResolveCIMDependencyAntecedent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "CIM_Dependency", "CIM_ManagedElement", "Dependent", "Antecedent");
            return instances.Select(i => (CIMManagedElement)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public CIMBaseMetricDefinition ResolveCIMMetricDefForMEDependent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "CIM_MetricDefForME", "CIM_BaseMetricDefinition", "Antecedent", "Dependent");
            return instances.Select(i => (CIMBaseMetricDefinition)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public CIMBaseMetricDefinition ResolveMsvmMetricDefForMEDependent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_MetricDefForME", "CIM_BaseMetricDefinition", "Antecedent", "Dependent");
            return instances.Select(i => (CIMBaseMetricDefinition)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public CIMManagedElement ResolveMsvmMetricCollectionDependencyDependent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_MetricCollectionDependency", "CIM_ManagedElement", "Antecedent", "Dependent");
            return instances.Select(i => (CIMManagedElement)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public CIMManagedElement ResolveMsvmMetricCollectionDependencyAntecedent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_MetricCollectionDependency", "CIM_ManagedElement", "Dependent", "Antecedent");
            return instances.Select(i => (CIMManagedElement)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public CIMManagedElement ResolveCIMConcreteDependencyDependent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "CIM_ConcreteDependency", "CIM_ManagedElement", "Antecedent", "Dependent");
            return instances.Select(i => (CIMManagedElement)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public CIMManagedElement ResolveCIMConcreteDependencyAntecedent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "CIM_ConcreteDependency", "CIM_ManagedElement", "Dependent", "Antecedent");
            return instances.Select(i => (CIMManagedElement)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public CIMManagedElement ResolveCIMHostedDependencyDependent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "CIM_HostedDependency", "CIM_ManagedElement", "Antecedent", "Dependent");
            return instances.Select(i => (CIMManagedElement)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public CIMManagedElement ResolveCIMHostedDependencyAntecedent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "CIM_HostedDependency", "CIM_ManagedElement", "Dependent", "Antecedent");
            return instances.Select(i => (CIMManagedElement)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public CIMManagedElement ResolveMsvmHostedDependencyDependent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_HostedDependency", "CIM_ManagedElement", "Antecedent", "Dependent");
            return instances.Select(i => (CIMManagedElement)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public CIMManagedElement ResolveMsvmHostedDependencyAntecedent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_HostedDependency", "CIM_ManagedElement", "Dependent", "Antecedent");
            return instances.Select(i => (CIMManagedElement)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public CIMBaseMetricValue ResolveCIMMetricForMEDependent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "CIM_MetricForME", "CIM_BaseMetricValue", "Antecedent", "Dependent");
            return instances.Select(i => (CIMBaseMetricValue)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public CIMBaseMetricValue ResolveMsvmMetricForMEDependent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_MetricForME", "CIM_BaseMetricValue", "Antecedent", "Dependent");
            return instances.Select(i => (CIMBaseMetricValue)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public CIMView ResolveCIMElementViewDependent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "CIM_ElementView", "CIM_View", "Antecedent", "Dependent");
            return instances.Select(i => (CIMView)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public CimInstance ResolveCIMElementConformsToProfileConformantStandard()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "CIM_ElementConformsToProfile", "CIM_RegisteredProfile", "ManagedElement", "ConformantStandard");
            return instances.SingleOrDefault();
        }

        public CIMJob ResolveCIMAffectedJobElementAffectingElement()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "CIM_AffectedJobElement", "CIM_Job", "AffectedElement", "AffectingElement");
            return instances.Select(i => (CIMJob)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public MsvmStorageJob ResolveMsvmAffectedStorageJobElementAffectingElement()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_AffectedStorageJobElement", "Msvm_StorageJob", "AffectedElement", "AffectingElement");
            return instances.Select(i => (MsvmStorageJob)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public CIMJob ResolveMsvmAffectedJobElementAffectingElement()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_AffectedJobElement", "CIM_Job", "AffectedElement", "AffectingElement");
            return instances.Select(i => (CIMJob)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public CIMJob ResolveCIMOwningJobElementOwnedElement()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "CIM_OwningJobElement", "CIM_Job", "OwningElement", "OwnedElement");
            return instances.Select(i => (CIMJob)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public CIMJob ResolveMsvmOwningJobElementOwnedElement()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_OwningJobElement", "CIM_Job", "OwningElement", "OwnedElement");
            return instances.Select(i => (CIMJob)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }
    }
}
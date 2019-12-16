using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMResourcePool : CIMLogicalElement
    {
        protected CIMResourcePool()
        {
        }

        protected CIMResourcePool(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String AllocationUnits
        {
            get
            {
                System.String result;
                this.GetProperty("AllocationUnits", out result);
                return result;
            }

            set
            {
                this.SetProperty("AllocationUnits", value);
            }
        }

        public System.UInt64? Capacity
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("Capacity", out result);
                return result;
            }

            set
            {
                this.SetProperty("Capacity", value);
            }
        }

        public System.String ConsumedResourceUnits
        {
            get
            {
                System.String result;
                this.GetProperty("ConsumedResourceUnits", out result);
                return result;
            }

            set
            {
                this.SetProperty("ConsumedResourceUnits", value);
            }
        }

        public System.UInt64? CurrentlyConsumedResource
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("CurrentlyConsumedResource", out result);
                return result;
            }

            set
            {
                this.SetProperty("CurrentlyConsumedResource", value);
            }
        }

        public System.UInt64? MaxConsumableResource
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("MaxConsumableResource", out result);
                return result;
            }

            set
            {
                this.SetProperty("MaxConsumableResource", value);
            }
        }

        public System.String OtherResourceType
        {
            get
            {
                System.String result;
                this.GetProperty("OtherResourceType", out result);
                return result;
            }

            set
            {
                this.SetProperty("OtherResourceType", value);
            }
        }

        public System.String PoolID
        {
            get
            {
                System.String result;
                this.GetProperty("PoolID", out result);
                return result;
            }

            set
            {
                this.SetProperty("PoolID", value);
            }
        }

        public System.Boolean? Primordial
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("Primordial", out result);
                return result;
            }

            set
            {
                this.SetProperty("Primordial", value);
            }
        }

        public System.UInt64? Reserved
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("Reserved", out result);
                return result;
            }

            set
            {
                this.SetProperty("Reserved", value);
            }
        }

        public System.String ResourceSubType
        {
            get
            {
                System.String result;
                this.GetProperty("ResourceSubType", out result);
                return result;
            }

            set
            {
                this.SetProperty("ResourceSubType", value);
            }
        }

        public System.UInt16? ResourceType
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("ResourceType", out result);
                return result;
            }

            set
            {
                this.SetProperty("ResourceType", value);
            }
        }

        public IEnumerable<MsvmComputerSystem> ResolveMsvmHostedResourcePoolGroupComponent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_HostedResourcePool", "Msvm_ComputerSystem", "PartComponent", "GroupComponent");
            return instances.Select(i => (MsvmComputerSystem)InfrastuctureObjectScope.Mapper.Create(i));
        }

        public IEnumerable<CIMSystem> ResolveCIMHostedResourcePoolGroupComponent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "CIM_HostedResourcePool", "CIM_System", "PartComponent", "GroupComponent");
            return instances.Select(i => (CIMSystem)InfrastuctureObjectScope.Mapper.Create(i));
        }

        public CIMLogicalElement ResolveCIMElementAllocatedFromPoolDependent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "CIM_ElementAllocatedFromPool", "CIM_LogicalElement", "Antecedent", "Dependent");
            return instances.Select(i => (CIMLogicalElement)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public CIMLogicalElement ResolveMsvmElementAllocatedFromPoolDependent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_ElementAllocatedFromPool", "CIM_LogicalElement", "Antecedent", "Dependent");
            return instances.Select(i => (CIMLogicalElement)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public CIMResourceAllocationSettingData ResolveCIMResourceAllocationFromPoolDependent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "CIM_ResourceAllocationFromPool", "CIM_ResourceAllocationSettingData", "Antecedent", "Dependent");
            return instances.Select(i => (CIMResourceAllocationSettingData)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public CIMResourceAllocationSettingData ResolveMsvmResourceAllocationFromPoolDependent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_ResourceAllocationFromPool", "CIM_ResourceAllocationSettingData", "Antecedent", "Dependent");
            return instances.Select(i => (CIMResourceAllocationSettingData)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }
    }
}
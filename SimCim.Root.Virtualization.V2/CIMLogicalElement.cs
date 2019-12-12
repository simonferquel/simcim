using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMLogicalElement : CIMManagedSystemElement
    {
        protected CIMLogicalElement()
        {
        }

        protected CIMLogicalElement(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public MsvmNumaNode ResolveMsvmElementAllocatedFromNumaNodeAntecedent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_ElementAllocatedFromNumaNode", "Msvm_NumaNode", "Dependent", "Antecedent");
            return instances.Select(i => (MsvmNumaNode)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public CIMResourcePool ResolveCIMElementAllocatedFromPoolAntecedent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "CIM_ElementAllocatedFromPool", "CIM_ResourcePool", "Dependent", "Antecedent");
            return instances.Select(i => (CIMResourcePool)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public CIMResourcePool ResolveMsvmElementAllocatedFromPoolAntecedent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/virtualization/v2", InnerCimInstance, "Msvm_ElementAllocatedFromPool", "CIM_ResourcePool", "Dependent", "Antecedent");
            return instances.Select(i => (CIMResourcePool)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }
    }
}
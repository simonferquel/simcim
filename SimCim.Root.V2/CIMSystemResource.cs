using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMSystemResource : CIMLogicalElement
    {
        protected CIMSystemResource()
        {
        }

        protected CIMSystemResource(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public Win32ComputerSystem ResolveWin32SystemResourcesGroupComponent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_SystemResources", "Win32_ComputerSystem", "PartComponent", "GroupComponent");
            return instances.Select(i => (Win32ComputerSystem)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public CimInstance ResolveWin32PNPAllocatedResourceDependent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_PNPAllocatedResource", "Win32_PNPEntity", "Antecedent", "Dependent");
            return instances.SingleOrDefault();
        }

        public CIMLogicalDevice ResolveWin32AllocatedResourceDependent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_AllocatedResource", "CIM_LogicalDevice", "Antecedent", "Dependent");
            return instances.Select(i => (CIMLogicalDevice)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }
    }
}
using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32LoadOrderGroup : CIMLogicalElement
    {
        public Win32LoadOrderGroup()
        {
        }

        public Win32LoadOrderGroup(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Boolean? DriverEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("DriverEnabled", out result);
                return result;
            }
        }

        public System.UInt32? GroupOrder
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("GroupOrder", out result);
                return result;
            }
        }

        public Win32ComputerSystem ResolveWin32SystemLoadOrderGroupsGroupComponent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_SystemLoadOrderGroups", "Win32_ComputerSystem", "PartComponent", "GroupComponent");
            return instances.Select(i => (Win32ComputerSystem)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public IEnumerable<Win32BaseService> ResolveWin32LoadOrderGroupServiceMembersPartComponent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_LoadOrderGroupServiceMembers", "Win32_BaseService", "GroupComponent", "PartComponent");
            return instances.Select(i => (Win32BaseService)InfrastuctureObjectScope.Mapper.Create(i));
        }

        public Win32BaseService ResolveWin32LoadOrderGroupServiceDependenciesDependent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_LoadOrderGroupServiceDependencies", "Win32_BaseService", "Antecedent", "Dependent");
            return instances.Select(i => (Win32BaseService)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }
    }
}
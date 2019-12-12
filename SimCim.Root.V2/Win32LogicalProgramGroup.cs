using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32LogicalProgramGroup : Win32ProgramGroupOrItem
    {
        public Win32LogicalProgramGroup()
        {
        }

        public Win32LogicalProgramGroup(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String GroupName
        {
            get
            {
                System.String result;
                this.GetProperty("GroupName", out result);
                return result;
            }
        }

        public System.String UserName
        {
            get
            {
                System.String result;
                this.GetProperty("UserName", out result);
                return result;
            }
        }

        public IEnumerable<Win32ProgramGroupOrItem> ResolveWin32ProgramGroupContentsPartComponent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_ProgramGroupContents", "Win32_ProgramGroupOrItem", "GroupComponent", "PartComponent");
            return instances.Select(i => (Win32ProgramGroupOrItem)InfrastuctureObjectScope.Mapper.Create(i));
        }

        public Win32Directory ResolveWin32LogicalProgramGroupDirectoryDependent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_LogicalProgramGroupDirectory", "Win32_Directory", "Antecedent", "Dependent");
            return instances.Select(i => (Win32Directory)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }

        public Win32ComputerSystem ResolveWin32SystemProgramGroupsElement()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_SystemProgramGroups", "Win32_ComputerSystem", "Setting", "Element");
            return instances.Select(i => (Win32ComputerSystem)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }
    }
}
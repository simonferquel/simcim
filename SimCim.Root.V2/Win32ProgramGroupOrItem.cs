using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class Win32ProgramGroupOrItem : CIMLogicalElement
    {
        protected Win32ProgramGroupOrItem()
        {
        }

        protected Win32ProgramGroupOrItem(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public Win32LogicalProgramGroup ResolveWin32ProgramGroupContentsGroupComponent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_ProgramGroupContents", "Win32_LogicalProgramGroup", "PartComponent", "GroupComponent");
            return instances.Select(i => (Win32LogicalProgramGroup)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }
    }
}
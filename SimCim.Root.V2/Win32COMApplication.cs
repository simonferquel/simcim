using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class Win32COMApplication : CIMLogicalElement
    {
        protected Win32COMApplication()
        {
        }

        protected Win32COMApplication(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public IEnumerable<Win32COMClass> ResolveWin32COMApplicationClassesPartComponent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_COMApplicationClasses", "Win32_COMClass", "GroupComponent", "PartComponent");
            return instances.Select(i => (Win32COMClass)InfrastuctureObjectScope.Mapper.Create(i));
        }
    }
}
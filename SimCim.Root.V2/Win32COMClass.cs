using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class Win32COMClass : CIMLogicalElement
    {
        protected Win32COMClass()
        {
        }

        protected Win32COMClass(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public Win32COMApplication ResolveWin32COMApplicationClassesGroupComponent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_COMApplicationClasses", "Win32_COMApplication", "PartComponent", "GroupComponent");
            return instances.Select(i => (Win32COMApplication)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }
    }
}
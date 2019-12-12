using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMComputerSystem : CIMSystem
    {
        protected CIMComputerSystem()
        {
        }

        protected CIMComputerSystem(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public Win32SoftwareElement ResolveWin32InstalledSoftwareElementSoftware()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_InstalledSoftwareElement", "Win32_SoftwareElement", "System", "Software");
            return instances.Select(i => (Win32SoftwareElement)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }
    }
}
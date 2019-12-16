using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32SystemDriver : Win32BaseService
    {
        public Win32SystemDriver()
        {
        }

        public Win32SystemDriver(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public IEnumerable<Win32ComputerSystem> ResolveWin32SystemSystemDriverGroupComponent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_SystemSystemDriver", "Win32_ComputerSystem", "PartComponent", "GroupComponent");
            return instances.Select(i => (Win32ComputerSystem)InfrastuctureObjectScope.Mapper.Create(i));
        }

        public CimInstance ResolveWin32SystemDriverPNPEntityAntecedent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_SystemDriverPNPEntity", "Win32_PNPEntity", "Dependent", "Antecedent");
            return instances.SingleOrDefault();
        }
    }
}
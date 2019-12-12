using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32USBHub : CIMUSBHub
    {
        public Win32USBHub()
        {
        }

        public Win32USBHub(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public Win32USBController ResolveWin32ControllerHasHubAntecedent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_ControllerHasHub", "Win32_USBController", "Dependent", "Antecedent");
            return instances.Select(i => (Win32USBController)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }
    }
}
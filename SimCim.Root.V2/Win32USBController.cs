using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32USBController : CIMUSBController
    {
        public Win32USBController()
        {
        }

        public Win32USBController(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public Win32USBHub ResolveWin32ControllerHasHubDependent()
        {
            var instances = InfrastuctureObjectScope.CimSession.EnumerateAssociatedInstances("root/cimv2", InnerCimInstance, "Win32_ControllerHasHub", "Win32_USBHub", "Antecedent", "Dependent");
            return instances.Select(i => (Win32USBHub)InfrastuctureObjectScope.Mapper.Create(i)).SingleOrDefault();
        }
    }
}
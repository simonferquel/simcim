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
    }
}
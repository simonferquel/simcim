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
    }
}
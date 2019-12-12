using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32ComputerShutdownEvent : Win32ComputerSystemEvent
    {
        public Win32ComputerShutdownEvent()
        {
        }

        public Win32ComputerShutdownEvent(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? Type
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Type", out result);
                return result;
            }
        }
    }
}
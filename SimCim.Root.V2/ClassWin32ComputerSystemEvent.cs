using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32ComputerSystemEvent : ExtrinsicEvent
    {
        public Win32ComputerSystemEvent()
        {
        }

        public Win32ComputerSystemEvent(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String MachineName
        {
            get
            {
                System.String result;
                this.GetProperty("MachineName", out result);
                return result;
            }
        }
    }
}
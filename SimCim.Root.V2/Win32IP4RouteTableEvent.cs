using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32IP4RouteTableEvent : ExtrinsicEvent
    {
        public Win32IP4RouteTableEvent()
        {
        }

        public Win32IP4RouteTableEvent(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }
    }
}
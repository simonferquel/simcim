using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PowerManagementEvent : ExtrinsicEvent
    {
        public Win32PowerManagementEvent()
        {
        }

        public Win32PowerManagementEvent(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16? EventType
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("EventType", out result);
                return result;
            }
        }

        public System.UInt16? OEMEventCode
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("OEMEventCode", out result);
                return result;
            }
        }
    }
}
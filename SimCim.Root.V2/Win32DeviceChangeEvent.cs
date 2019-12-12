using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32DeviceChangeEvent : ExtrinsicEvent
    {
        public Win32DeviceChangeEvent()
        {
        }

        public Win32DeviceChangeEvent(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
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
    }
}
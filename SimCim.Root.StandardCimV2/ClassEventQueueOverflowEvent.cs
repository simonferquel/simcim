using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class EventQueueOverflowEvent : EventDroppedEvent
    {
        public EventQueueOverflowEvent()
        {
        }

        public EventQueueOverflowEvent(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? CurrentQueueSize
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CurrentQueueSize", out result);
                return result;
            }

            set
            {
                this.SetProperty("CurrentQueueSize", value);
            }
        }
    }
}
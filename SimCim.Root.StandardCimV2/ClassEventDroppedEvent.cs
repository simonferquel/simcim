using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class EventDroppedEvent : SystemEvent
    {
        public EventDroppedEvent()
        {
        }

        public EventDroppedEvent(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public Event Event
        {
            get
            {
                Event result;
                this.GetInfrastructureObjectProperty("Event", out result);
                return result;
            }

            set
            {
                this.SetProperty("Event", value);
            }
        }

        public EventConsumer IntendedConsumer
        {
            get
            {
                EventConsumer result;
                this.GetInfrastructureObjectProperty("IntendedConsumer", out result);
                return result;
            }

            set
            {
                this.SetProperty("IntendedConsumer", value);
            }
        }
    }
}
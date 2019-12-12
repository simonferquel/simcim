using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class AggregateEvent : IndicationRelated
    {
        public AggregateEvent()
        {
        }

        public AggregateEvent(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? NumberOfEvents
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NumberOfEvents", out result);
                return result;
            }

            set
            {
                this.SetProperty("NumberOfEvents", value);
            }
        }

        public CimInstance Representative
        {
            get
            {
                CimInstance result;
                this.GetProperty("Representative", out result);
                return result;
            }

            set
            {
                this.SetProperty("Representative", value);
            }
        }
    }
}
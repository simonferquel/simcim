using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class TimerEvent : Event
    {
        public TimerEvent()
        {
        }

        public TimerEvent(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? NumFirings
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NumFirings", out result);
                return result;
            }

            set
            {
                this.SetProperty("NumFirings", value);
            }
        }

        public System.String TimerId
        {
            get
            {
                System.String result;
                this.GetProperty("TimerId", out result);
                return result;
            }

            set
            {
                this.SetProperty("TimerId", value);
            }
        }
    }
}
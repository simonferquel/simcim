using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class IntervalTimerInstruction : TimerInstruction
    {
        public IntervalTimerInstruction()
        {
        }

        public IntervalTimerInstruction(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32 IntervalBetweenEvents
        {
            get
            {
                System.UInt32 result;
                this.GetProperty("IntervalBetweenEvents", out result);
                return result;
            }

            set
            {
                this.SetProperty("IntervalBetweenEvents", value);
            }
        }
    }
}
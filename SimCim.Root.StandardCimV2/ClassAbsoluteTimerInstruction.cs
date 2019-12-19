using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class AbsoluteTimerInstruction : TimerInstruction
    {
        public AbsoluteTimerInstruction()
        {
        }

        public AbsoluteTimerInstruction(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.DateTime EventDateTime
        {
            get
            {
                System.DateTime result;
                this.GetProperty("EventDateTime", out result);
                return result;
            }

            set
            {
                this.SetProperty("EventDateTime", value);
            }
        }
    }
}
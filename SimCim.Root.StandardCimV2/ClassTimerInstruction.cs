using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public abstract class TimerInstruction : EventGenerator
    {
        protected TimerInstruction()
        {
        }

        protected TimerInstruction(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Boolean? SkipIfPassed
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("SkipIfPassed", out result);
                return result;
            }

            set
            {
                this.SetProperty("SkipIfPassed", value);
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
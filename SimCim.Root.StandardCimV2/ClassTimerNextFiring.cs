using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class TimerNextFiring : IndicationRelated
    {
        public TimerNextFiring()
        {
        }

        public TimerNextFiring(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Int64 NextEvent64BitTime
        {
            get
            {
                System.Int64 result;
                this.GetProperty("NextEvent64BitTime", out result);
                return result;
            }

            set
            {
                this.SetProperty("NextEvent64BitTime", value);
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
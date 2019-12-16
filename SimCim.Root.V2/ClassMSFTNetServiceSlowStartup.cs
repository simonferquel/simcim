using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class MSFTNetServiceSlowStartup : MSFTSCMEventLogEvent
    {
        public MSFTNetServiceSlowStartup()
        {
        }

        public MSFTNetServiceSlowStartup(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String Service
        {
            get
            {
                System.String result;
                this.GetProperty("Service", out result);
                return result;
            }

            set
            {
                this.SetProperty("Service", value);
            }
        }

        public System.UInt32? StartupTime
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("StartupTime", out result);
                return result;
            }

            set
            {
                this.SetProperty("StartupTime", value);
            }
        }
    }
}
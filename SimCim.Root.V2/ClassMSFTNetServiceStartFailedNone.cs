using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class MSFTNetServiceStartFailedNone : MSFTSCMEventLogEvent
    {
        public MSFTNetServiceStartFailedNone()
        {
        }

        public MSFTNetServiceStartFailedNone(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String NonExistingService
        {
            get
            {
                System.String result;
                this.GetProperty("NonExistingService", out result);
                return result;
            }

            set
            {
                this.SetProperty("NonExistingService", value);
            }
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
    }
}
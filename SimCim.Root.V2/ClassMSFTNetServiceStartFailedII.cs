using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class MSFTNetServiceStartFailedII : MSFTSCMEventLogEvent
    {
        public MSFTNetServiceStartFailedII()
        {
        }

        public MSFTNetServiceStartFailedII(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String DependedOnService
        {
            get
            {
                System.String result;
                this.GetProperty("DependedOnService", out result);
                return result;
            }

            set
            {
                this.SetProperty("DependedOnService", value);
            }
        }

        public System.UInt32? Error
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Error", out result);
                return result;
            }

            set
            {
                this.SetProperty("Error", value);
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
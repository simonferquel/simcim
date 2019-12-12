using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class MSFTNetServiceDifferentPIDConnected : MSFTSCMEventLogEvent
    {
        public MSFTNetServiceDifferentPIDConnected()
        {
        }

        public MSFTNetServiceDifferentPIDConnected(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? ActualPID
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ActualPID", out result);
                return result;
            }

            set
            {
                this.SetProperty("ActualPID", value);
            }
        }

        public System.UInt32? ExpectedPID
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ExpectedPID", out result);
                return result;
            }

            set
            {
                this.SetProperty("ExpectedPID", value);
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
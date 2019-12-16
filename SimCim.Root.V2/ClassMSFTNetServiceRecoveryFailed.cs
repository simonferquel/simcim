using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class MSFTNetServiceRecoveryFailed : MSFTSCMEventLogEvent
    {
        public MSFTNetServiceRecoveryFailed()
        {
        }

        public MSFTNetServiceRecoveryFailed(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String Action
        {
            get
            {
                System.String result;
                this.GetProperty("Action", out result);
                return result;
            }

            set
            {
                this.SetProperty("Action", value);
            }
        }

        public System.UInt32? ActionType
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ActionType", out result);
                return result;
            }

            set
            {
                this.SetProperty("ActionType", value);
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
using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class MSFTNetServiceCrash : MSFTSCMEventLogEvent
    {
        public MSFTNetServiceCrash()
        {
        }

        public MSFTNetServiceCrash(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
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

        public System.UInt32? ActionDelay
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ActionDelay", out result);
                return result;
            }

            set
            {
                this.SetProperty("ActionDelay", value);
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

        public System.UInt32? TimesFailed
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TimesFailed", out result);
                return result;
            }

            set
            {
                this.SetProperty("TimesFailed", value);
            }
        }
    }
}
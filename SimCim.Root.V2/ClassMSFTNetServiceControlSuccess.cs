using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class MSFTNetServiceControlSuccess : MSFTSCMEventLogEvent
    {
        public MSFTNetServiceControlSuccess()
        {
        }

        public MSFTNetServiceControlSuccess(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String Control
        {
            get
            {
                System.String result;
                this.GetProperty("Control", out result);
                return result;
            }

            set
            {
                this.SetProperty("Control", value);
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

        public System.String Sid
        {
            get
            {
                System.String result;
                this.GetProperty("sid", out result);
                return result;
            }

            set
            {
                this.SetProperty("sid", value);
            }
        }
    }
}
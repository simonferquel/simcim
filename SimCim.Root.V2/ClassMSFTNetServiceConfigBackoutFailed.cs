using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class MSFTNetServiceConfigBackoutFailed : MSFTSCMEventLogEvent
    {
        public MSFTNetServiceConfigBackoutFailed()
        {
        }

        public MSFTNetServiceConfigBackoutFailed(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String ConfigField
        {
            get
            {
                System.String result;
                this.GetProperty("ConfigField", out result);
                return result;
            }

            set
            {
                this.SetProperty("ConfigField", value);
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
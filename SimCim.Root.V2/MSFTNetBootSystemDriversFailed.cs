using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class MSFTNetBootSystemDriversFailed : MSFTSCMEventLogEvent
    {
        public MSFTNetBootSystemDriversFailed()
        {
        }

        public MSFTNetBootSystemDriversFailed(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String DriverList
        {
            get
            {
                System.String result;
                this.GetProperty("DriverList", out result);
                return result;
            }

            set
            {
                this.SetProperty("DriverList", value);
            }
        }
    }
}
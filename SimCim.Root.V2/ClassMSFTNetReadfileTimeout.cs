using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class MSFTNetReadfileTimeout : MSFTSCMEventLogEvent
    {
        public MSFTNetReadfileTimeout()
        {
        }

        public MSFTNetReadfileTimeout(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? Milliseconds
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Milliseconds", out result);
                return result;
            }

            set
            {
                this.SetProperty("Milliseconds", value);
            }
        }
    }
}
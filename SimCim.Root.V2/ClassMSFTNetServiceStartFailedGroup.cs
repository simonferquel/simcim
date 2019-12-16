using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class MSFTNetServiceStartFailedGroup : MSFTSCMEventLogEvent
    {
        public MSFTNetServiceStartFailedGroup()
        {
        }

        public MSFTNetServiceStartFailedGroup(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String Group
        {
            get
            {
                System.String result;
                this.GetProperty("Group", out result);
                return result;
            }

            set
            {
                this.SetProperty("Group", value);
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
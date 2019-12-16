using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class MSFTNetTakeOwnership : MSFTSCMEventLogEvent
    {
        public MSFTNetTakeOwnership()
        {
        }

        public MSFTNetTakeOwnership(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String RegistryKey
        {
            get
            {
                System.String result;
                this.GetProperty("RegistryKey", out result);
                return result;
            }

            set
            {
                this.SetProperty("RegistryKey", value);
            }
        }
    }
}
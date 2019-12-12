using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class MSFTNetBadAccount : MSFTSCMEventLogEvent
    {
        public MSFTNetBadAccount()
        {
        }

        public MSFTNetBadAccount(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }
    }
}
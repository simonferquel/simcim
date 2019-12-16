using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class MSFTNetRevertedToLastKnownGood : MSFTSCMEventLogEvent
    {
        public MSFTNetRevertedToLastKnownGood()
        {
        }

        public MSFTNetRevertedToLastKnownGood(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }
    }
}
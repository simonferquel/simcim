using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class MSFTNetAdapterPowerManagementWakePatternWildCard : MSFTNetAdapterPowerManagementWakePattern
    {
        public MSFTNetAdapterPowerManagementWakePatternWildCard()
        {
        }

        public MSFTNetAdapterPowerManagementWakePatternWildCard(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }
    }
}
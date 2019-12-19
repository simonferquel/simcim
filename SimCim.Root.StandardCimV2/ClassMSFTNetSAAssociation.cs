using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class MSFTNetSAAssociation : CIMPhase1SAUsedForPhase2
    {
        public MSFTNetSAAssociation()
        {
        }

        public MSFTNetSAAssociation(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }
    }
}
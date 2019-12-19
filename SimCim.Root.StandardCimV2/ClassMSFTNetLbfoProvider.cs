using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class MSFTNetLbfoProvider : MSFTNetImPlatProvider
    {
        public MSFTNetLbfoProvider()
        {
        }

        public MSFTNetLbfoProvider(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }
    }
}
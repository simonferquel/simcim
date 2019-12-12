﻿using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class MSFTNetCircularDependencyAuto : MSFTSCMEventLogEvent
    {
        public MSFTNetCircularDependencyAuto()
        {
        }

        public MSFTNetCircularDependencyAuto(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }
    }
}
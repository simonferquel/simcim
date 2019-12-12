﻿using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class MSFTNetCircularDependencyDemand : MSFTSCMEventLogEvent
    {
        public MSFTNetCircularDependencyDemand()
        {
        }

        public MSFTNetCircularDependencyDemand(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
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
﻿using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmMetricServiceCapabilities : CIMMetricServiceCapabilities
    {
        public MsvmMetricServiceCapabilities()
        {
        }

        public MsvmMetricServiceCapabilities(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }
    }
}
﻿using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32HeatPipe : CIMHeatPipe
    {
        public Win32HeatPipe()
        {
        }

        public Win32HeatPipe(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }
    }
}
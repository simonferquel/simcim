﻿using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public abstract class SystemClass : GenericInfrastructureObject
    {
        protected SystemClass()
        {
        }

        protected SystemClass(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }
    }
}
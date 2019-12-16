﻿using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32ApplicationService : CIMService
    {
        public Win32ApplicationService()
        {
        }

        public Win32ApplicationService(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }
    }
}
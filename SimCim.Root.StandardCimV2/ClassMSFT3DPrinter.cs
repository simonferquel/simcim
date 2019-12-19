﻿using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFT3DPrinter : MSFTPrinter
    {
        public MSFT3DPrinter()
        {
        }

        public MSFT3DPrinter(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }
    }
}
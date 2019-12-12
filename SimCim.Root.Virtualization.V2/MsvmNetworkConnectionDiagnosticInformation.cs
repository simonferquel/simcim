﻿using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmNetworkConnectionDiagnosticInformation : GenericInfrastructureObject
    {
        public MsvmNetworkConnectionDiagnosticInformation()
        {
        }

        public MsvmNetworkConnectionDiagnosticInformation(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? RoundTripTime
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("RoundTripTime", out result);
                return result;
            }
        }
    }
}
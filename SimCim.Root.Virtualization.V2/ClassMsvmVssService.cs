﻿using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmVssService : MsvmGuestService
    {
        public MsvmVssService()
        {
        }

        public MsvmVssService(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public (System.UInt32 retval, MsvmGuestClusterInformation outGuestClusterInformation) QueryGuestClusterInformation()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "QueryGuestClusterInformation", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (MsvmGuestClusterInformation)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["GuestClusterInformation"].Value));
        }
    }
}
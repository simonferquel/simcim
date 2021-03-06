﻿using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmGuestFileService : MsvmGuestService
    {
        public MsvmGuestFileService()
        {
        }

        public MsvmGuestFileService(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) CopyFilesToGuest(System.String[] inCopyFileToGuestSettings)
        {
            var parameters = new CimMethodParametersCollection();
            if (inCopyFileToGuestSettings != null)
                parameters.Add(CimMethodParameter.Create("CopyFileToGuestSettings", inCopyFileToGuestSettings, CimType.StringArray, inCopyFileToGuestSettings == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "CopyFilesToGuest", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["Job"].Value));
        }
    }
}
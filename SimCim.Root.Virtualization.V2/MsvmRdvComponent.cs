using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmRdvComponent : CIMLogicalDevice
    {
        public MsvmRdvComponent()
        {
        }

        public MsvmRdvComponent(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32 EnableEndPoints()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "EnableEndPoints", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }
    }
}
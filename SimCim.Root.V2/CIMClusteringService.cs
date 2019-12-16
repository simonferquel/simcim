using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMClusteringService : CIMService
    {
        protected CIMClusteringService()
        {
        }

        protected CIMClusteringService(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32 AddNode(CIMComputerSystem inCS)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("CS", inCS.AsCimInstance(), CimType.Reference, inCS == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "AddNode", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 EvictNode(CIMComputerSystem inCS)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("CS", inCS.AsCimInstance(), CimType.Reference, inCS == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "EvictNode", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }
    }
}
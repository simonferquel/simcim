using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmProcessorPool : CIMResourcePool
    {
        public MsvmProcessorPool()
        {
        }

        public MsvmProcessorPool(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32 CalculatePossibleReserve(System.UInt16? inProcessorCount)
        {
            var parameters = new CimMethodParametersCollection();
            if (inProcessorCount.HasValue)
                parameters.Add(CimMethodParameter.Create("ProcessorCount", inProcessorCount.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("ProcessorCount", null, CimFlags.NullValue));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "CalculatePossibleReserve", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }
    }
}
using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmShutdownComponent : CIMLogicalDevice
    {
        public MsvmShutdownComponent()
        {
        }

        public MsvmShutdownComponent(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32 InitiateShutdown(System.Boolean? inForce, System.String inReason)
        {
            var parameters = new CimMethodParametersCollection();
            if (inForce.HasValue)
                parameters.Add(CimMethodParameter.Create("Force", inForce.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("Force", null, CimFlags.NullValue));
            parameters.Add(CimMethodParameter.Create("Reason", inReason, CimType.String, inReason == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "InitiateShutdown", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 InitiateReboot(System.Boolean? inForce, System.String inReason)
        {
            var parameters = new CimMethodParametersCollection();
            if (inForce.HasValue)
                parameters.Add(CimMethodParameter.Create("Force", inForce.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("Force", null, CimFlags.NullValue));
            parameters.Add(CimMethodParameter.Create("Reason", inReason, CimType.String, inReason == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "InitiateReboot", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public System.UInt32 InitiateHibernate()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "InitiateHibernate", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }
    }
}
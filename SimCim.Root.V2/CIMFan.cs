using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMFan : CIMCoolingDevice
    {
        protected CIMFan()
        {
        }

        protected CIMFan(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? DesiredSpeed
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("DesiredSpeed", out result);
                return result;
            }
        }

        public System.Boolean? VariableSpeed
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("VariableSpeed", out result);
                return result;
            }
        }

        public System.UInt32 SetSpeed(System.UInt64? inDesiredSpeed)
        {
            var parameters = new CimMethodParametersCollection();
            if (inDesiredSpeed.HasValue)
                parameters.Add(CimMethodParameter.Create("DesiredSpeed", inDesiredSpeed.Value, CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "SetSpeed", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }
    }
}
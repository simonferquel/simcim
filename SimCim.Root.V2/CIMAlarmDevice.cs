using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMAlarmDevice : CIMLogicalDevice
    {
        protected CIMAlarmDevice()
        {
        }

        protected CIMAlarmDevice(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Boolean? AudibleAlarm
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("AudibleAlarm", out result);
                return result;
            }
        }

        public System.UInt16? Urgency
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("Urgency", out result);
                return result;
            }
        }

        public System.Boolean? VisibleAlarm
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("VisibleAlarm", out result);
                return result;
            }
        }

        public System.UInt32 SetUrgency(System.UInt16? inRequestedUrgency)
        {
            var parameters = new CimMethodParametersCollection();
            if (inRequestedUrgency.HasValue)
                parameters.Add(CimMethodParameter.Create("RequestedUrgency", inRequestedUrgency.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("RequestedUrgency", null, CimFlags.NullValue));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "SetUrgency", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }
    }
}
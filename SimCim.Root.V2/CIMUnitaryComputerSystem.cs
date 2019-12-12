using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMUnitaryComputerSystem : CIMComputerSystem
    {
        protected CIMUnitaryComputerSystem()
        {
        }

        protected CIMUnitaryComputerSystem(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String[] InitialLoadInfo
        {
            get
            {
                System.String[] result;
                this.GetProperty("InitialLoadInfo", out result);
                return result;
            }
        }

        public System.String LastLoadInfo
        {
            get
            {
                System.String result;
                this.GetProperty("LastLoadInfo", out result);
                return result;
            }
        }

        public System.UInt16[] PowerManagementCapabilities
        {
            get
            {
                System.UInt16[] result;
                this.GetProperty("PowerManagementCapabilities", out result);
                return result;
            }
        }

        public System.Boolean? PowerManagementSupported
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("PowerManagementSupported", out result);
                return result;
            }
        }

        public System.UInt16? PowerState
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("PowerState", out result);
                return result;
            }
        }

        public System.UInt16? ResetCapability
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("ResetCapability", out result);
                return result;
            }
        }

        public System.UInt32 SetPowerState(System.UInt16? inPowerState, System.DateTime? inTime)
        {
            var parameters = new CimMethodParametersCollection();
            if (inPowerState.HasValue)
                parameters.Add(CimMethodParameter.Create("PowerState", inPowerState.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("PowerState", null, CimFlags.NullValue));
            if (inTime.HasValue)
                parameters.Add(CimMethodParameter.Create("Time", inTime.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("Time", null, CimFlags.NullValue));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "SetPowerState", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }
    }
}
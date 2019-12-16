using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMComputerSystem : CIMSystem
    {
        protected CIMComputerSystem()
        {
        }

        protected CIMComputerSystem(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16[] Dedicated
        {
            get
            {
                System.UInt16[] result;
                this.GetProperty("Dedicated", out result);
                return result;
            }

            set
            {
                this.SetProperty("Dedicated", value);
            }
        }

        public System.String[] OtherDedicatedDescriptions
        {
            get
            {
                System.String[] result;
                this.GetProperty("OtherDedicatedDescriptions", out result);
                return result;
            }

            set
            {
                this.SetProperty("OtherDedicatedDescriptions", value);
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

            set
            {
                this.SetProperty("PowerManagementCapabilities", value);
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

            set
            {
                this.SetProperty("ResetCapability", value);
            }
        }

        public System.UInt32 SetPowerState(System.UInt32? inPowerState, System.DateTime? inTime)
        {
            var parameters = new CimMethodParametersCollection();
            if (inPowerState.HasValue)
                parameters.Add(CimMethodParameter.Create("PowerState", inPowerState.Value, CimFlags.None));
            if (inTime.HasValue)
                parameters.Add(CimMethodParameter.Create("Time", inTime.Value, CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "SetPowerState", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }
    }
}
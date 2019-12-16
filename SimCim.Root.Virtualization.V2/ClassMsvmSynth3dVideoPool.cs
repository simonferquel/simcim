using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmSynth3dVideoPool : CIMResourcePool
    {
        public MsvmSynth3dVideoPool()
        {
        }

        public MsvmSynth3dVideoPool(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String DirectXVersion
        {
            get
            {
                System.String result;
                this.GetProperty("DirectXVersion", out result);
                return result;
            }
        }

        public System.Boolean? Is3dVideoSupported
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("Is3dVideoSupported", out result);
                return result;
            }
        }

        public System.Boolean? IsGPUCapable
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("IsGPUCapable", out result);
                return result;
            }
        }

        public System.Boolean? IsSLATCapable
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("IsSLATCapable", out result);
                return result;
            }
        }

        public System.String RequiredMinimumDirectXVersion
        {
            get
            {
                System.String result;
                this.GetProperty("RequiredMinimumDirectXVersion", out result);
                return result;
            }
        }

        public (System.UInt32 retval, System.UInt64? outrequiredVideoMemory) CalculateVideoMemoryRequirements(System.UInt32? inmonitorResolution, System.UInt32? innumberOfMonitors)
        {
            var parameters = new CimMethodParametersCollection();
            if (inmonitorResolution.HasValue)
                parameters.Add(CimMethodParameter.Create("monitorResolution", inmonitorResolution.Value, CimFlags.None));
            if (innumberOfMonitors.HasValue)
                parameters.Add(CimMethodParameter.Create("numberOfMonitors", innumberOfMonitors.Value, CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "CalculateVideoMemoryRequirements", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (System.UInt64? )result.OutParameters["requiredVideoMemory"].Value);
        }
    }
}
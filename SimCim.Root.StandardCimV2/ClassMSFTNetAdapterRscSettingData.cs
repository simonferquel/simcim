using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTNetAdapterRscSettingData : MSFTNetAdapterSettingData
    {
        public MSFTNetAdapterRscSettingData()
        {
        }

        public MSFTNetAdapterRscSettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Boolean? IPv4Enabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("IPv4Enabled", out result);
                return result;
            }

            set
            {
                this.SetProperty("IPv4Enabled", value);
            }
        }

        public System.UInt32? IPv4FailureReason
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("IPv4FailureReason", out result);
                return result;
            }
        }

        public System.Boolean? IPv4OperationalState
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("IPv4OperationalState", out result);
                return result;
            }
        }

        public System.Boolean? IPv6Enabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("IPv6Enabled", out result);
                return result;
            }

            set
            {
                this.SetProperty("IPv6Enabled", value);
            }
        }

        public System.UInt32? IPv6FailureReason
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("IPv6FailureReason", out result);
                return result;
            }
        }

        public System.Boolean? IPv6OperationalState
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("IPv6OperationalState", out result);
                return result;
            }
        }

        public MSFTNetAdapterRscCapabilities RscHardwareCapabilities
        {
            get
            {
                MSFTNetAdapterRscCapabilities result;
                this.GetInfrastructureObjectProperty("RscHardwareCapabilities", out result);
                return result;
            }
        }

        public (System.UInt32 retval, MSFTNetAdapterRscSettingData outcmdletOutput) Enable(System.Boolean? inIPv4, System.Boolean? inIPv6)
        {
            var parameters = new CimMethodParametersCollection();
            if (inIPv4.HasValue)
                parameters.Add(CimMethodParameter.Create("IPv4", inIPv4.Value, CimFlags.None));
            if (inIPv6.HasValue)
                parameters.Add(CimMethodParameter.Create("IPv6", inIPv6.Value, CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Enable", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (MSFTNetAdapterRscSettingData)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["cmdletOutput"].Value));
        }

        public (System.UInt32 retval, MSFTNetAdapterRscSettingData outcmdletOutput) Disable(System.Boolean? inIPv4, System.Boolean? inIPv6)
        {
            var parameters = new CimMethodParametersCollection();
            if (inIPv4.HasValue)
                parameters.Add(CimMethodParameter.Create("IPv4", inIPv4.Value, CimFlags.None));
            if (inIPv6.HasValue)
                parameters.Add(CimMethodParameter.Create("IPv6", inIPv6.Value, CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Disable", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (MSFTNetAdapterRscSettingData)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["cmdletOutput"].Value));
        }
    }
}
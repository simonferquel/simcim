using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTNetAdapterLsoSettingData : MSFTNetAdapterSettingData
    {
        public MSFTNetAdapterLsoSettingData()
        {
        }

        public MSFTNetAdapterLsoSettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
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

        public MSFTNetAdapterLargeSendOffloadV1Capabilities LargeSendOffloadV1HardwareCapabilities
        {
            get
            {
                MSFTNetAdapterLargeSendOffloadV1Capabilities result;
                this.GetInfrastructureObjectProperty("LargeSendOffloadV1HardwareCapabilities", out result);
                return result;
            }
        }

        public MSFTNetAdapterLargeSendOffloadV2Capabilities LargeSendOffloadV2HardwareCapabilities
        {
            get
            {
                MSFTNetAdapterLargeSendOffloadV2Capabilities result;
                this.GetInfrastructureObjectProperty("LargeSendOffloadV2HardwareCapabilities", out result);
                return result;
            }
        }

        public System.UInt32? MaximumLsoVersionSupported
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaximumLsoVersionSupported", out result);
                return result;
            }
        }

        public System.Boolean? V1IPv4Enabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("V1IPv4Enabled", out result);
                return result;
            }

            set
            {
                this.SetProperty("V1IPv4Enabled", value);
            }
        }

        public (System.UInt32 retval, MSFTNetAdapterLsoSettingData outcmdletOutput) Enable(System.Boolean? inIPv4, System.Boolean? inIPv6)
        {
            var parameters = new CimMethodParametersCollection();
            if (inIPv4.HasValue)
                parameters.Add(CimMethodParameter.Create("IPv4", inIPv4.Value, CimFlags.None));
            if (inIPv6.HasValue)
                parameters.Add(CimMethodParameter.Create("IPv6", inIPv6.Value, CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Enable", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (MSFTNetAdapterLsoSettingData)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["cmdletOutput"].Value));
        }

        public (System.UInt32 retval, MSFTNetAdapterLsoSettingData outcmdletOutput) Disable(System.Boolean? inIPv4, System.Boolean? inIPv6)
        {
            var parameters = new CimMethodParametersCollection();
            if (inIPv4.HasValue)
                parameters.Add(CimMethodParameter.Create("IPv4", inIPv4.Value, CimFlags.None));
            if (inIPv6.HasValue)
                parameters.Add(CimMethodParameter.Create("IPv6", inIPv6.Value, CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Disable", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (MSFTNetAdapterLsoSettingData)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["cmdletOutput"].Value));
        }
    }
}
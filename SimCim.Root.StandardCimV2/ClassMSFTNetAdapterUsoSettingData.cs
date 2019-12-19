using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTNetAdapterUsoSettingData : MSFTNetAdapterSettingData
    {
        public MSFTNetAdapterUsoSettingData()
        {
        }

        public MSFTNetAdapterUsoSettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
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

        public MSFTNetAdapterUdpSegmentationOffloadCapabilities UdpSegmentationOffloadHardwareCapabilities
        {
            get
            {
                MSFTNetAdapterUdpSegmentationOffloadCapabilities result;
                this.GetInfrastructureObjectProperty("UdpSegmentationOffloadHardwareCapabilities", out result);
                return result;
            }
        }

        public (System.UInt32 retval, MSFTNetAdapterUsoSettingData outcmdletOutput) Enable(System.Boolean? inIPv4, System.Boolean? inIPv6)
        {
            var parameters = new CimMethodParametersCollection();
            if (inIPv4.HasValue)
                parameters.Add(CimMethodParameter.Create("IPv4", inIPv4.Value, CimFlags.None));
            if (inIPv6.HasValue)
                parameters.Add(CimMethodParameter.Create("IPv6", inIPv6.Value, CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Enable", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (MSFTNetAdapterUsoSettingData)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["cmdletOutput"].Value));
        }

        public (System.UInt32 retval, MSFTNetAdapterUsoSettingData outcmdletOutput) Disable(System.Boolean? inIPv4, System.Boolean? inIPv6)
        {
            var parameters = new CimMethodParametersCollection();
            if (inIPv4.HasValue)
                parameters.Add(CimMethodParameter.Create("IPv4", inIPv4.Value, CimFlags.None));
            if (inIPv6.HasValue)
                parameters.Add(CimMethodParameter.Create("IPv6", inIPv6.Value, CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Disable", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (MSFTNetAdapterUsoSettingData)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["cmdletOutput"].Value));
        }
    }
}
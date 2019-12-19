using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class MSFTNetAdapterIPsecOffloadV2SettingData : MSFTNetAdapterSettingData
    {
        public MSFTNetAdapterIPsecOffloadV2SettingData()
        {
        }

        public MSFTNetAdapterIPsecOffloadV2SettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Boolean? AhEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("AhEnabled", out result);
                return result;
            }
        }

        public System.Boolean? AhEspCombinedEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("AhEspCombinedEnabled", out result);
                return result;
            }
        }

        public System.Boolean? AhEspCombinedSupported
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("AhEspCombinedSupported", out result);
                return result;
            }
        }

        public System.Boolean? AhSupported
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("AhSupported", out result);
                return result;
            }
        }

        public System.UInt32? AuthenticationAlgorithmsEnabled
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("AuthenticationAlgorithmsEnabled", out result);
                return result;
            }
        }

        public System.UInt32? AuthenticationAlgorithmsSupported
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("AuthenticationAlgorithmsSupported", out result);
                return result;
            }
        }

        public System.Boolean? Enabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("Enabled", out result);
                return result;
            }

            set
            {
                this.SetProperty("Enabled", value);
            }
        }

        public System.UInt32? EncryptionAlgorithmsEnabled
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("EncryptionAlgorithmsEnabled", out result);
                return result;
            }
        }

        public System.UInt32? EncryptionAlgorithmsSupported
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("EncryptionAlgorithmsSupported", out result);
                return result;
            }
        }

        public System.Boolean? EspEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("EspEnabled", out result);
                return result;
            }
        }

        public System.Boolean? EspSupported
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("EspSupported", out result);
                return result;
            }
        }

        public System.Boolean? IPv4OptionsEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("IPv4OptionsEnabled", out result);
                return result;
            }
        }

        public System.Boolean? IPv4OptionsSupported
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("IPv4OptionsSupported", out result);
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
        }

        public System.Boolean? IPv6NonIPsecExtensionHeadersEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("IPv6NonIPsecExtensionHeadersEnabled", out result);
                return result;
            }
        }

        public System.Boolean? IPv6NonIPsecExtensionHeadersSupported
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("IPv6NonIPsecExtensionHeadersSupported", out result);
                return result;
            }
        }

        public System.Boolean? IPv6Supported
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("IPv6Supported", out result);
                return result;
            }
        }

        public System.Boolean? LsoEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("LsoEnabled", out result);
                return result;
            }
        }

        public System.Boolean? LsoSupported
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("LsoSupported", out result);
                return result;
            }
        }

        public System.UInt32? SaOffloadCapacityEnabled
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SaOffloadCapacityEnabled", out result);
                return result;
            }
        }

        public System.UInt32? SaOffloadCapacitySupported
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SaOffloadCapacitySupported", out result);
                return result;
            }
        }

        public System.Boolean? TransportEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("TransportEnabled", out result);
                return result;
            }
        }

        public System.Boolean? TransportSupported
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("TransportSupported", out result);
                return result;
            }
        }

        public System.Boolean? TunnelEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("TunnelEnabled", out result);
                return result;
            }
        }

        public System.Boolean? TunnelSupported
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("TunnelSupported", out result);
                return result;
            }
        }

        public System.UInt32? UdpEspEnabled
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("UdpEspEnabled", out result);
                return result;
            }
        }

        public System.UInt32? UdpEspSupported
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("UdpEspSupported", out result);
                return result;
            }
        }

        public (System.UInt32 retval, MSFTNetAdapterIPsecOffloadV2SettingData outcmdletOutput) Set(System.Boolean? inEnabled, System.Boolean? inNoRestart, System.Boolean? inPassThru)
        {
            var parameters = new CimMethodParametersCollection();
            if (inEnabled.HasValue)
                parameters.Add(CimMethodParameter.Create("Enabled", inEnabled.Value, CimFlags.None));
            if (inNoRestart.HasValue)
                parameters.Add(CimMethodParameter.Create("NoRestart", inNoRestart.Value, CimFlags.None));
            if (inPassThru.HasValue)
                parameters.Add(CimMethodParameter.Create("PassThru", inPassThru.Value, CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Set", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (MSFTNetAdapterIPsecOffloadV2SettingData)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["cmdletOutput"].Value));
        }

        public (System.UInt32 retval, MSFTNetAdapterIPsecOffloadV2SettingData outcmdletOutput) Enable(System.Boolean? inNoRestart, System.Boolean? inPassThru)
        {
            var parameters = new CimMethodParametersCollection();
            if (inNoRestart.HasValue)
                parameters.Add(CimMethodParameter.Create("NoRestart", inNoRestart.Value, CimFlags.None));
            if (inPassThru.HasValue)
                parameters.Add(CimMethodParameter.Create("PassThru", inPassThru.Value, CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Enable", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (MSFTNetAdapterIPsecOffloadV2SettingData)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["cmdletOutput"].Value));
        }

        public (System.UInt32 retval, MSFTNetAdapterIPsecOffloadV2SettingData outcmdletOutput) Disable(System.Boolean? inNoRestart, System.Boolean? inPassThru)
        {
            var parameters = new CimMethodParametersCollection();
            if (inNoRestart.HasValue)
                parameters.Add(CimMethodParameter.Create("NoRestart", inNoRestart.Value, CimFlags.None));
            if (inPassThru.HasValue)
                parameters.Add(CimMethodParameter.Create("PassThru", inPassThru.Value, CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Disable", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (MSFTNetAdapterIPsecOffloadV2SettingData)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["cmdletOutput"].Value));
        }
    }
}
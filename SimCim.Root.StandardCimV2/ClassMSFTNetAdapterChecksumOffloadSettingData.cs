using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTNetAdapterChecksumOffloadSettingData : MSFTNetAdapterSettingData
    {
        public MSFTNetAdapterChecksumOffloadSettingData()
        {
        }

        public MSFTNetAdapterChecksumOffloadSettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public MSFTNetAdapterChecksumOffloadCapabilities ChecksumOffloadHardwareCapabilities
        {
            get
            {
                MSFTNetAdapterChecksumOffloadCapabilities result;
                this.GetInfrastructureObjectProperty("ChecksumOffloadHardwareCapabilities", out result);
                return result;
            }
        }

        public System.UInt32? IpIPv4Enabled
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("IpIPv4Enabled", out result);
                return result;
            }

            set
            {
                this.SetProperty("IpIPv4Enabled", value);
            }
        }

        public System.UInt32? TcpIPv4Enabled
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TcpIPv4Enabled", out result);
                return result;
            }

            set
            {
                this.SetProperty("TcpIPv4Enabled", value);
            }
        }

        public System.UInt32? TcpIPv6Enabled
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TcpIPv6Enabled", out result);
                return result;
            }

            set
            {
                this.SetProperty("TcpIPv6Enabled", value);
            }
        }

        public System.UInt32? UdpIPv4Enabled
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("UdpIPv4Enabled", out result);
                return result;
            }

            set
            {
                this.SetProperty("UdpIPv4Enabled", value);
            }
        }

        public System.UInt32? UdpIPv6Enabled
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("UdpIPv6Enabled", out result);
                return result;
            }

            set
            {
                this.SetProperty("UdpIPv6Enabled", value);
            }
        }

        public (System.UInt32 retval, MSFTNetAdapterChecksumOffloadSettingData outcmdletOutput) Enable(System.Boolean? inIpIPv4, System.UInt32? inRxTxControl, System.Boolean? inTcpIPv4, System.Boolean? inTcpIPv6, System.Boolean? inUdpIPv4, System.Boolean? inUdpIPv6)
        {
            var parameters = new CimMethodParametersCollection();
            if (inIpIPv4.HasValue)
                parameters.Add(CimMethodParameter.Create("IpIPv4", inIpIPv4.Value, CimFlags.None));
            if (inRxTxControl.HasValue)
                parameters.Add(CimMethodParameter.Create("RxTxControl", inRxTxControl.Value, CimFlags.None));
            if (inTcpIPv4.HasValue)
                parameters.Add(CimMethodParameter.Create("TcpIPv4", inTcpIPv4.Value, CimFlags.None));
            if (inTcpIPv6.HasValue)
                parameters.Add(CimMethodParameter.Create("TcpIPv6", inTcpIPv6.Value, CimFlags.None));
            if (inUdpIPv4.HasValue)
                parameters.Add(CimMethodParameter.Create("UdpIPv4", inUdpIPv4.Value, CimFlags.None));
            if (inUdpIPv6.HasValue)
                parameters.Add(CimMethodParameter.Create("UdpIPv6", inUdpIPv6.Value, CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Enable", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (MSFTNetAdapterChecksumOffloadSettingData)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["cmdletOutput"].Value));
        }

        public (System.UInt32 retval, MSFTNetAdapterChecksumOffloadSettingData outcmdletOutput) Disable(System.Boolean? inIpIPv4, System.UInt32? inRxTxControl, System.Boolean? inTcpIPv4, System.Boolean? inTcpIPv6, System.Boolean? inUdpIPv4, System.Boolean? inUdpIPv6)
        {
            var parameters = new CimMethodParametersCollection();
            if (inIpIPv4.HasValue)
                parameters.Add(CimMethodParameter.Create("IpIPv4", inIpIPv4.Value, CimFlags.None));
            if (inRxTxControl.HasValue)
                parameters.Add(CimMethodParameter.Create("RxTxControl", inRxTxControl.Value, CimFlags.None));
            if (inTcpIPv4.HasValue)
                parameters.Add(CimMethodParameter.Create("TcpIPv4", inTcpIPv4.Value, CimFlags.None));
            if (inTcpIPv6.HasValue)
                parameters.Add(CimMethodParameter.Create("TcpIPv6", inTcpIPv6.Value, CimFlags.None));
            if (inUdpIPv4.HasValue)
                parameters.Add(CimMethodParameter.Create("UdpIPv4", inUdpIPv4.Value, CimFlags.None));
            if (inUdpIPv6.HasValue)
                parameters.Add(CimMethodParameter.Create("UdpIPv6", inUdpIPv6.Value, CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Disable", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (MSFTNetAdapterChecksumOffloadSettingData)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["cmdletOutput"].Value));
        }
    }
}
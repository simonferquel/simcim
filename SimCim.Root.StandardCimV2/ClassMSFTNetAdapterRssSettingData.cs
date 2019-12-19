using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class MSFTNetAdapterRssSettingData : MSFTNetAdapterSettingData
    {
        public MSFTNetAdapterRssSettingData()
        {
        }

        public MSFTNetAdapterRssSettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16? BaseProcessorGroup
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("BaseProcessorGroup", out result);
                return result;
            }

            set
            {
                this.SetProperty("BaseProcessorGroup", value);
            }
        }

        public System.Byte? BaseProcessorNumber
        {
            get
            {
                System.Byte? result;
                this.GetProperty("BaseProcessorNumber", out result);
                return result;
            }

            set
            {
                this.SetProperty("BaseProcessorNumber", value);
            }
        }

        public System.Boolean? ClassificationAtDpcSupported
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("ClassificationAtDpcSupported", out result);
                return result;
            }
        }

        public System.Boolean? ClassificationAtIsrSupported
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("ClassificationAtIsrSupported", out result);
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

        public System.UInt16? HashKeySize
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("HashKeySize", out result);
                return result;
            }
        }

        public IEnumerable<MSFTNetAdapterProcessorNumber> IndirectionTable
        {
            get
            {
                IEnumerable<MSFTNetAdapterProcessorNumber> result;
                this.GetInfrastructureObjectProperty("IndirectionTable", out result);
                return result;
            }
        }

        public System.UInt16? IndirectionTableEntryCount
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("IndirectionTableEntryCount", out result);
                return result;
            }
        }

        public System.Boolean? IPv4HashEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("IPv4HashEnabled", out result);
                return result;
            }
        }

        public System.Boolean? IPv6ExtensionHashEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("IPv6ExtensionHashEnabled", out result);
                return result;
            }
        }

        public System.Boolean? IPv6HashEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("IPv6HashEnabled", out result);
                return result;
            }
        }

        public System.UInt16? MaxProcessorGroup
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("MaxProcessorGroup", out result);
                return result;
            }

            set
            {
                this.SetProperty("MaxProcessorGroup", value);
            }
        }

        public System.Byte? MaxProcessorNumber
        {
            get
            {
                System.Byte? result;
                this.GetProperty("MaxProcessorNumber", out result);
                return result;
            }

            set
            {
                this.SetProperty("MaxProcessorNumber", value);
            }
        }

        public System.UInt32? MaxProcessors
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaxProcessors", out result);
                return result;
            }

            set
            {
                this.SetProperty("MaxProcessors", value);
            }
        }

        public System.Boolean? MsiSupported
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("MsiSupported", out result);
                return result;
            }
        }

        public System.Boolean? MsiXEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("MsiXEnabled", out result);
                return result;
            }
        }

        public System.Boolean? MsiXSupported
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("MsiXSupported", out result);
                return result;
            }
        }

        public System.UInt16? NumaNode
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("NumaNode", out result);
                return result;
            }

            set
            {
                this.SetProperty("NumaNode", value);
            }
        }

        public System.UInt32? NumberOfInterruptMessages
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NumberOfInterruptMessages", out result);
                return result;
            }
        }

        public System.UInt32? NumberOfReceiveQueues
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NumberOfReceiveQueues", out result);
                return result;
            }

            set
            {
                this.SetProperty("NumberOfReceiveQueues", value);
            }
        }

        public System.UInt32? Profile
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Profile", out result);
                return result;
            }

            set
            {
                this.SetProperty("Profile", value);
            }
        }

        public System.Boolean? RssOnPortsSupported
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("RssOnPortsSupported", out result);
                return result;
            }
        }

        public IEnumerable<MSFTNetAdapterRssProcessor> RssProcessorArray
        {
            get
            {
                IEnumerable<MSFTNetAdapterRssProcessor> result;
                this.GetInfrastructureObjectProperty("RssProcessorArray", out result);
                return result;
            }
        }

        public System.UInt32? RssProcessorArraySize
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("RssProcessorArraySize", out result);
                return result;
            }
        }

        public System.Boolean? TcpIPv4HashEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("TcpIPv4HashEnabled", out result);
                return result;
            }
        }

        public System.Boolean? TcpIPv4HashSupported
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("TcpIPv4HashSupported", out result);
                return result;
            }
        }

        public System.Boolean? TcpIPv6ExtensionHashEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("TcpIPv6ExtensionHashEnabled", out result);
                return result;
            }
        }

        public System.Boolean? TcpIPv6ExtensionHashSupported
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("TcpIPv6ExtensionHashSupported", out result);
                return result;
            }
        }

        public System.Boolean? TcpIPv6HashEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("TcpIPv6HashEnabled", out result);
                return result;
            }
        }

        public System.Boolean? TcpIPv6HashSupported
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("TcpIPv6HashSupported", out result);
                return result;
            }
        }

        public System.Boolean? ToeplitzHashFunctionEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("ToeplitzHashFunctionEnabled", out result);
                return result;
            }
        }

        public System.Boolean? ToeplitzHashFunctionSupported
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("ToeplitzHashFunctionSupported", out result);
                return result;
            }
        }

        public System.Boolean? UdpIPv4HashEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("UdpIPv4HashEnabled", out result);
                return result;
            }
        }

        public System.Boolean? UdpIPv4HashSupported
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("UdpIPv4HashSupported", out result);
                return result;
            }
        }

        public System.Boolean? UdpIPv6ExtensionHashEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("UdpIPv6ExtensionHashEnabled", out result);
                return result;
            }
        }

        public System.Boolean? UdpIPv6ExtensionHashSupported
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("UdpIPv6ExtensionHashSupported", out result);
                return result;
            }
        }

        public System.Boolean? UdpIPv6HashEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("UdpIPv6HashEnabled", out result);
                return result;
            }
        }

        public System.Boolean? UdpIPv6HashSupported
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("UdpIPv6HashSupported", out result);
                return result;
            }
        }

        public (System.UInt32 retval, MSFTNetAdapterRssSettingData outcmdletOutput) Enable()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Enable", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (MSFTNetAdapterRssSettingData)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["cmdletOutput"].Value));
        }

        public (System.UInt32 retval, MSFTNetAdapterRssSettingData outcmdletOutput) Disable()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Disable", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (MSFTNetAdapterRssSettingData)InfrastuctureObjectScope.Mapper.Create(InfrastuctureObjectScope, (CimInstance)result.OutParameters["cmdletOutput"].Value));
        }
    }
}
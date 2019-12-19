using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class MSFTNetAdapterUdpSegmentationOffloadCapabilities : GenericInfrastructureObject
    {
        public MSFTNetAdapterUdpSegmentationOffloadCapabilities()
        {
        }

        public MSFTNetAdapterUdpSegmentationOffloadCapabilities(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public MSFTNetAdapterUsoEncapsulationTypes IPv4Encapsulation
        {
            get
            {
                MSFTNetAdapterUsoEncapsulationTypes result;
                this.GetInfrastructureObjectProperty("IPv4Encapsulation", out result);
                return result;
            }
        }

        public System.UInt32? IPv4MaxOffloadSizeSupported
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("IPv4MaxOffloadSizeSupported", out result);
                return result;
            }
        }

        public System.UInt32? IPv4MinSegmentCountSupported
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("IPv4MinSegmentCountSupported", out result);
                return result;
            }
        }

        public MSFTNetAdapterUsoEncapsulationTypes IPv6Encapsulation
        {
            get
            {
                MSFTNetAdapterUsoEncapsulationTypes result;
                this.GetInfrastructureObjectProperty("IPv6Encapsulation", out result);
                return result;
            }
        }

        public System.Boolean? IPv6IpExtensionHeadersSupported
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("IPv6IpExtensionHeadersSupported", out result);
                return result;
            }
        }

        public System.UInt32? IPv6MaxOffLoadSizeSupported
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("IPv6MaxOffLoadSizeSupported", out result);
                return result;
            }
        }

        public System.UInt32? IPv6MinSegmentCountSupported
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("IPv6MinSegmentCountSupported", out result);
                return result;
            }
        }
    }
}
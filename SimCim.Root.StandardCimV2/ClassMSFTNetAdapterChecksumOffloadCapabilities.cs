using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class MSFTNetAdapterChecksumOffloadCapabilities : GenericInfrastructureObject
    {
        public MSFTNetAdapterChecksumOffloadCapabilities()
        {
        }

        public MSFTNetAdapterChecksumOffloadCapabilities(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public MSFTNetAdapterChecksumOffloadEncapsulationTypes IPv4ReceiveEncapsulation
        {
            get
            {
                MSFTNetAdapterChecksumOffloadEncapsulationTypes result;
                this.GetInfrastructureObjectProperty("IPv4ReceiveEncapsulation", out result);
                return result;
            }
        }

        public System.Boolean? IPv4ReceiveIpChecksumSupported
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("IPv4ReceiveIpChecksumSupported", out result);
                return result;
            }
        }

        public System.Boolean? IPv4ReceiveIpOptionsSupported
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("IPv4ReceiveIpOptionsSupported", out result);
                return result;
            }
        }

        public System.Boolean? IPv4ReceiveTcpChecksumSupported
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("IPv4ReceiveTcpChecksumSupported", out result);
                return result;
            }
        }

        public System.Boolean? IPv4ReceiveTcpOptionsSupported
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("IPv4ReceiveTcpOptionsSupported", out result);
                return result;
            }
        }

        public System.Boolean? IPv4ReceiveUdpChecksumSupported
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("IPv4ReceiveUdpChecksumSupported", out result);
                return result;
            }
        }

        public MSFTNetAdapterChecksumOffloadEncapsulationTypes IPv4TransmitEncapsulation
        {
            get
            {
                MSFTNetAdapterChecksumOffloadEncapsulationTypes result;
                this.GetInfrastructureObjectProperty("IPv4TransmitEncapsulation", out result);
                return result;
            }
        }

        public System.Boolean? IPv4TransmitIpChecksumSupported
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("IPv4TransmitIpChecksumSupported", out result);
                return result;
            }
        }

        public System.Boolean? IPv4TransmitIpOptionsSupported
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("IPv4TransmitIpOptionsSupported", out result);
                return result;
            }
        }

        public System.Boolean? IPv4TransmitTcpChecksumSupported
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("IPv4TransmitTcpChecksumSupported", out result);
                return result;
            }
        }

        public System.Boolean? IPv4TransmitTcpOptionsSupported
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("IPv4TransmitTcpOptionsSupported", out result);
                return result;
            }
        }

        public System.Boolean? IPv4TransmitUdpChecksumSupported
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("IPv4TransmitUdpChecksumSupported", out result);
                return result;
            }
        }

        public MSFTNetAdapterChecksumOffloadEncapsulationTypes IPv6ReceiveEncapsulation
        {
            get
            {
                MSFTNetAdapterChecksumOffloadEncapsulationTypes result;
                this.GetInfrastructureObjectProperty("IPv6ReceiveEncapsulation", out result);
                return result;
            }
        }

        public System.Boolean? IPv6ReceiveIpExtensionHeadersSupported
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("IPv6ReceiveIpExtensionHeadersSupported", out result);
                return result;
            }
        }

        public System.Boolean? IPv6ReceiveTcpChecksumSupported
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("IPv6ReceiveTcpChecksumSupported", out result);
                return result;
            }
        }

        public System.Boolean? IPv6ReceiveTcpOptionsSupported
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("IPv6ReceiveTcpOptionsSupported", out result);
                return result;
            }
        }

        public System.Boolean? IPv6ReceiveUdpChecksumSupported
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("IPv6ReceiveUdpChecksumSupported", out result);
                return result;
            }
        }

        public MSFTNetAdapterChecksumOffloadEncapsulationTypes IPv6TransmitEncapsulation
        {
            get
            {
                MSFTNetAdapterChecksumOffloadEncapsulationTypes result;
                this.GetInfrastructureObjectProperty("IPv6TransmitEncapsulation", out result);
                return result;
            }
        }

        public System.Boolean? IPv6TransmitIpExtensionHeadersSupported
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("IPv6TransmitIpExtensionHeadersSupported", out result);
                return result;
            }
        }

        public System.Boolean? IPv6TransmitTcpChecksumSupported
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("IPv6TransmitTcpChecksumSupported", out result);
                return result;
            }
        }

        public System.Boolean? IPv6TransmitTcpOptionsSupported
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("IPv6TransmitTcpOptionsSupported", out result);
                return result;
            }
        }

        public System.Boolean? IPv6TransmitUdpChecksumSupported
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("IPv6TransmitUdpChecksumSupported", out result);
                return result;
            }
        }
    }
}
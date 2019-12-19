using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class MSFTNetEventVFPProvider : MSFTNetEventProviderBase
    {
        public MSFTNetEventVFPProvider()
        {
        }

        public MSFTNetEventVFPProvider(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String[] DestinationIPAddresses
        {
            get
            {
                System.String[] result;
                this.GetProperty("DestinationIPAddresses", out result);
                return result;
            }

            set
            {
                this.SetProperty("DestinationIPAddresses", value);
            }
        }

        public System.String[] DestinationMACAddresses
        {
            get
            {
                System.String[] result;
                this.GetProperty("DestinationMACAddresses", out result);
                return result;
            }

            set
            {
                this.SetProperty("DestinationMACAddresses", value);
            }
        }

        public System.UInt32[] GREKeys
        {
            get
            {
                System.UInt32[] result;
                this.GetProperty("GREKeys", out result);
                return result;
            }

            set
            {
                this.SetProperty("GREKeys", value);
            }
        }

        public System.Byte[] IPProtocols
        {
            get
            {
                System.Byte[] result;
                this.GetProperty("IPProtocols", out result);
                return result;
            }

            set
            {
                this.SetProperty("IPProtocols", value);
            }
        }

        public System.UInt32[] PortIds
        {
            get
            {
                System.UInt32[] result;
                this.GetProperty("PortIds", out result);
                return result;
            }

            set
            {
                this.SetProperty("PortIds", value);
            }
        }

        public System.String[] SourceIPAddresses
        {
            get
            {
                System.String[] result;
                this.GetProperty("SourceIPAddresses", out result);
                return result;
            }

            set
            {
                this.SetProperty("SourceIPAddresses", value);
            }
        }

        public System.String[] SourceMACAddresses
        {
            get
            {
                System.String[] result;
                this.GetProperty("SourceMACAddresses", out result);
                return result;
            }

            set
            {
                this.SetProperty("SourceMACAddresses", value);
            }
        }

        public System.String SwitchName
        {
            get
            {
                System.String result;
                this.GetProperty("SwitchName", out result);
                return result;
            }

            set
            {
                this.SetProperty("SwitchName", value);
            }
        }

        public System.UInt16[] TCPPorts
        {
            get
            {
                System.UInt16[] result;
                this.GetProperty("TCPPorts", out result);
                return result;
            }

            set
            {
                this.SetProperty("TCPPorts", value);
            }
        }

        public System.UInt32[] TenantIds
        {
            get
            {
                System.UInt32[] result;
                this.GetProperty("TenantIds", out result);
                return result;
            }

            set
            {
                this.SetProperty("TenantIds", value);
            }
        }

        public System.UInt16[] UDPPorts
        {
            get
            {
                System.UInt16[] result;
                this.GetProperty("UDPPorts", out result);
                return result;
            }

            set
            {
                this.SetProperty("UDPPorts", value);
            }
        }

        public System.UInt32? VFPFlowDirection
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("VFPFlowDirection", out result);
                return result;
            }

            set
            {
                this.SetProperty("VFPFlowDirection", value);
            }
        }

        public System.UInt16[] VLANIds
        {
            get
            {
                System.UInt16[] result;
                this.GetProperty("VLANIds", out result);
                return result;
            }

            set
            {
                this.SetProperty("VLANIds", value);
            }
        }
    }
}
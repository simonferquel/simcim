using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class MSFTNetEventPacketCaptureProvider : MSFTNetEventProviderBase
    {
        public MSFTNetEventPacketCaptureProvider()
        {
        }

        public MSFTNetEventPacketCaptureProvider(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Byte? CaptureType
        {
            get
            {
                System.Byte? result;
                this.GetProperty("CaptureType", out result);
                return result;
            }

            set
            {
                this.SetProperty("CaptureType", value);
            }
        }

        public System.UInt16[] EtherType
        {
            get
            {
                System.UInt16[] result;
                this.GetProperty("EtherType", out result);
                return result;
            }

            set
            {
                this.SetProperty("EtherType", value);
            }
        }

        public System.String[] IPAddresses
        {
            get
            {
                System.String[] result;
                this.GetProperty("IPAddresses", out result);
                return result;
            }

            set
            {
                this.SetProperty("IPAddresses", value);
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

        public System.String[] LinkLayerAddress
        {
            get
            {
                System.String[] result;
                this.GetProperty("LinkLayerAddress", out result);
                return result;
            }

            set
            {
                this.SetProperty("LinkLayerAddress", value);
            }
        }

        public System.Boolean? MultiLayer
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("MultiLayer", out result);
                return result;
            }

            set
            {
                this.SetProperty("MultiLayer", value);
            }
        }

        public System.UInt16? TruncationLength
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("TruncationLength", out result);
                return result;
            }

            set
            {
                this.SetProperty("TruncationLength", value);
            }
        }

        public System.Byte? VmCaptureDirection
        {
            get
            {
                System.Byte? result;
                this.GetProperty("VmCaptureDirection", out result);
                return result;
            }

            set
            {
                this.SetProperty("VmCaptureDirection", value);
            }
        }
    }
}
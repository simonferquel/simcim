using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTNetEventWFPCaptureProvider : MSFTNetEventProviderBase
    {
        public MSFTNetEventWFPCaptureProvider()
        {
        }

        public MSFTNetEventWFPCaptureProvider(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? CaptureLayerSet
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("CaptureLayerSet", out result);
                return result;
            }

            set
            {
                this.SetProperty("CaptureLayerSet", value);
            }
        }

        public System.Boolean? DiscardedEvents
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("DiscardedEvents", out result);
                return result;
            }

            set
            {
                this.SetProperty("DiscardedEvents", value);
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
    }
}
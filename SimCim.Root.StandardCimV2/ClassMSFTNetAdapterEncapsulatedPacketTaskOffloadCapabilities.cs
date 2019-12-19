using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class MSFTNetAdapterEncapsulatedPacketTaskOffloadCapabilities : GenericInfrastructureObject
    {
        public MSFTNetAdapterEncapsulatedPacketTaskOffloadCapabilities()
        {
        }

        public MSFTNetAdapterEncapsulatedPacketTaskOffloadCapabilities(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? LsoV2Supported
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("LsoV2Supported", out result);
                return result;
            }
        }

        public System.UInt32? ReceiveChecksumOffloadSupported
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ReceiveChecksumOffloadSupported", out result);
                return result;
            }
        }

        public System.UInt32? RssSupported
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("RssSupported", out result);
                return result;
            }
        }

        public System.UInt32? TransmitChecksumOffloadSupported
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TransmitChecksumOffloadSupported", out result);
                return result;
            }
        }

        public System.UInt32? VmqSupported
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("VmqSupported", out result);
                return result;
            }
        }
    }
}
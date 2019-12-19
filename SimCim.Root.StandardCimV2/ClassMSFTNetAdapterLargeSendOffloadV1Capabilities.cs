using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class MSFTNetAdapterLargeSendOffloadV1Capabilities : GenericInfrastructureObject
    {
        public MSFTNetAdapterLargeSendOffloadV1Capabilities()
        {
        }

        public MSFTNetAdapterLargeSendOffloadV1Capabilities(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public MSFTNetAdapterLsoEncapsulationTypes IPv4Encapsulation
        {
            get
            {
                MSFTNetAdapterLsoEncapsulationTypes result;
                this.GetInfrastructureObjectProperty("IPv4Encapsulation", out result);
                return result;
            }
        }

        public System.Boolean? IPv4IpOptionsSupported
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("IPv4IpOptionsSupported", out result);
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

        public System.Boolean? IPv4TcpOptionsSupported
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("IPv4TcpOptionsSupported", out result);
                return result;
            }
        }
    }
}
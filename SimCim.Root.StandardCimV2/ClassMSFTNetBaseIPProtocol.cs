using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTNetBaseIPProtocol : CIMProtocolEndpoint
    {
        public MSFTNetBaseIPProtocol()
        {
        }

        public MSFTNetBaseIPProtocol(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Byte? AddressMaskReply
        {
            get
            {
                System.Byte? result;
                this.GetProperty("AddressMaskReply", out result);
                return result;
            }

            set
            {
                this.SetProperty("AddressMaskReply", value);
            }
        }

        public System.Byte? DeadGatewayDetection
        {
            get
            {
                System.Byte? result;
                this.GetProperty("DeadGatewayDetection", out result);
                return result;
            }

            set
            {
                this.SetProperty("DeadGatewayDetection", value);
            }
        }

        public System.UInt32? DefaultHopLimit
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DefaultHopLimit", out result);
                return result;
            }

            set
            {
                this.SetProperty("DefaultHopLimit", value);
            }
        }

        public System.Byte? DhcpMediaSense
        {
            get
            {
                System.Byte? result;
                this.GetProperty("DhcpMediaSense", out result);
                return result;
            }

            set
            {
                this.SetProperty("DhcpMediaSense", value);
            }
        }

        public System.Byte? GroupForwardedFragments
        {
            get
            {
                System.Byte? result;
                this.GetProperty("GroupForwardedFragments", out result);
                return result;
            }

            set
            {
                this.SetProperty("GroupForwardedFragments", value);
            }
        }

        public System.Byte? IcmpRedirects
        {
            get
            {
                System.Byte? result;
                this.GetProperty("IcmpRedirects", out result);
                return result;
            }

            set
            {
                this.SetProperty("IcmpRedirects", value);
            }
        }

        public System.Byte? MediaSenseEventLog
        {
            get
            {
                System.Byte? result;
                this.GetProperty("MediaSenseEventLog", out result);
                return result;
            }

            set
            {
                this.SetProperty("MediaSenseEventLog", value);
            }
        }

        public System.UInt32? MldLevel
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MldLevel", out result);
                return result;
            }

            set
            {
                this.SetProperty("MldLevel", value);
            }
        }

        public System.UInt32? MldVersion
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MldVersion", out result);
                return result;
            }

            set
            {
                this.SetProperty("MldVersion", value);
            }
        }

        public System.Byte? MulticastForwarding
        {
            get
            {
                System.Byte? result;
                this.GetProperty("MulticastForwarding", out result);
                return result;
            }

            set
            {
                this.SetProperty("MulticastForwarding", value);
            }
        }

        public System.UInt32? NeighborCacheLimit
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NeighborCacheLimit", out result);
                return result;
            }

            set
            {
                this.SetProperty("NeighborCacheLimit", value);
            }
        }

        public System.Byte? RandomizeIdentifiers
        {
            get
            {
                System.Byte? result;
                this.GetProperty("RandomizeIdentifiers", out result);
                return result;
            }

            set
            {
                this.SetProperty("RandomizeIdentifiers", value);
            }
        }

        public System.UInt32? ReassemblyLimit
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ReassemblyLimit", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReassemblyLimit", value);
            }
        }

        public System.UInt32? RouteCacheLimit
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("RouteCacheLimit", out result);
                return result;
            }

            set
            {
                this.SetProperty("RouteCacheLimit", value);
            }
        }

        public System.UInt32? SourceRoutingBehavior
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SourceRoutingBehavior", out result);
                return result;
            }

            set
            {
                this.SetProperty("SourceRoutingBehavior", value);
            }
        }
    }
}
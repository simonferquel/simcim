using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfFormattedDataCountersWFPv4 : Win32PerfFormattedData
    {
        public Win32PerfFormattedDataCountersWFPv4()
        {
        }

        public Win32PerfFormattedDataCountersWFPv4(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? ActiveInboundConnections
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ActiveInboundConnections", out result);
                return result;
            }

            set
            {
                this.SetProperty("ActiveInboundConnections", value);
            }
        }

        public System.UInt32? ActiveOutboundConnections
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ActiveOutboundConnections", out result);
                return result;
            }

            set
            {
                this.SetProperty("ActiveOutboundConnections", value);
            }
        }

        public System.UInt32? AllowedClassifiesPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("AllowedClassifiesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("AllowedClassifiesPersec", value);
            }
        }

        public System.UInt32? BlockedBinds
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("BlockedBinds", out result);
                return result;
            }

            set
            {
                this.SetProperty("BlockedBinds", value);
            }
        }

        public System.UInt32? InboundConnections
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("InboundConnections", out result);
                return result;
            }

            set
            {
                this.SetProperty("InboundConnections", value);
            }
        }

        public System.UInt32? InboundConnectionsAllowedPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("InboundConnectionsAllowedPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("InboundConnectionsAllowedPersec", value);
            }
        }

        public System.UInt32? InboundConnectionsBlockedPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("InboundConnectionsBlockedPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("InboundConnectionsBlockedPersec", value);
            }
        }

        public System.UInt32? InboundPacketsDiscardedPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("InboundPacketsDiscardedPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("InboundPacketsDiscardedPersec", value);
            }
        }

        public System.UInt32? OutboundConnections
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("OutboundConnections", out result);
                return result;
            }

            set
            {
                this.SetProperty("OutboundConnections", value);
            }
        }

        public System.UInt32? OutboundConnectionsAllowedPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("OutboundConnectionsAllowedPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("OutboundConnectionsAllowedPersec", value);
            }
        }

        public System.UInt32? OutboundConnectionsBlockedPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("OutboundConnectionsBlockedPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("OutboundConnectionsBlockedPersec", value);
            }
        }

        public System.UInt32? OutboundPacketsDiscardedPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("OutboundPacketsDiscardedPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("OutboundPacketsDiscardedPersec", value);
            }
        }

        public System.UInt32? PacketsDiscardedPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PacketsDiscardedPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("PacketsDiscardedPersec", value);
            }
        }
    }
}
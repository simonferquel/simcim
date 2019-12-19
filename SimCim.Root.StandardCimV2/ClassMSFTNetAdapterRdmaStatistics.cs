using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class MSFTNetAdapterRdmaStatistics : GenericInfrastructureObject
    {
        public MSFTNetAdapterRdmaStatistics()
        {
        }

        public MSFTNetAdapterRdmaStatistics(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? AcceptedConnections
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AcceptedConnections", out result);
                return result;
            }
        }

        public System.UInt64? ActiveConnections
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ActiveConnections", out result);
                return result;
            }
        }

        public System.UInt64? CompletionQueueErrors
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("CompletionQueueErrors", out result);
                return result;
            }
        }

        public System.UInt64? ConnectionErrors
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ConnectionErrors", out result);
                return result;
            }
        }

        public System.UInt64? FailedConnectionAttempts
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FailedConnectionAttempts", out result);
                return result;
            }
        }

        public System.UInt64? InboundBytes
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("InboundBytes", out result);
                return result;
            }
        }

        public System.UInt64? InboundFrames
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("InboundFrames", out result);
                return result;
            }
        }

        public System.UInt64? InitiatedConnections
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("InitiatedConnections", out result);
                return result;
            }
        }

        public System.UInt64? OutboundBytes
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("OutboundBytes", out result);
                return result;
            }
        }

        public System.UInt64? OutboundFrames
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("OutboundFrames", out result);
                return result;
            }
        }
    }
}
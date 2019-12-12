using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfFormattedDataCountersRDMAActivity : Win32PerfFormattedData
    {
        public Win32PerfFormattedDataCountersRDMAActivity()
        {
        }

        public Win32PerfFormattedDataCountersRDMAActivity(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? RDMAAcceptedConnections
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("RDMAAcceptedConnections", out result);
                return result;
            }

            set
            {
                this.SetProperty("RDMAAcceptedConnections", value);
            }
        }

        public System.UInt32? RDMAActiveConnections
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("RDMAActiveConnections", out result);
                return result;
            }

            set
            {
                this.SetProperty("RDMAActiveConnections", value);
            }
        }

        public System.UInt32? RDMACompletionQueueErrors
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("RDMACompletionQueueErrors", out result);
                return result;
            }

            set
            {
                this.SetProperty("RDMACompletionQueueErrors", value);
            }
        }

        public System.UInt32? RDMAConnectionErrors
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("RDMAConnectionErrors", out result);
                return result;
            }

            set
            {
                this.SetProperty("RDMAConnectionErrors", value);
            }
        }

        public System.UInt32? RDMAFailedConnectionAttempts
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("RDMAFailedConnectionAttempts", out result);
                return result;
            }

            set
            {
                this.SetProperty("RDMAFailedConnectionAttempts", value);
            }
        }

        public System.UInt64? RDMAInboundBytesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("RDMAInboundBytesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("RDMAInboundBytesPersec", value);
            }
        }

        public System.UInt64? RDMAInboundFramesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("RDMAInboundFramesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("RDMAInboundFramesPersec", value);
            }
        }

        public System.UInt32? RDMAInitiatedConnections
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("RDMAInitiatedConnections", out result);
                return result;
            }

            set
            {
                this.SetProperty("RDMAInitiatedConnections", value);
            }
        }

        public System.UInt64? RDMAOutboundBytesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("RDMAOutboundBytesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("RDMAOutboundBytesPersec", value);
            }
        }

        public System.UInt64? RDMAOutboundFramesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("RDMAOutboundFramesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("RDMAOutboundFramesPersec", value);
            }
        }
    }
}
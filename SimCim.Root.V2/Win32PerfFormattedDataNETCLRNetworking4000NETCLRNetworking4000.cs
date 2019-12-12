using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfFormattedDataNETCLRNetworking4000NETCLRNetworking4000 : Win32PerfFormattedData
    {
        public Win32PerfFormattedDataNETCLRNetworking4000NETCLRNetworking4000()
        {
        }

        public Win32PerfFormattedDataNETCLRNetworking4000NETCLRNetworking4000(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? BytesReceived
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("BytesReceived", out result);
                return result;
            }

            set
            {
                this.SetProperty("BytesReceived", value);
            }
        }

        public System.UInt64? BytesSent
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("BytesSent", out result);
                return result;
            }

            set
            {
                this.SetProperty("BytesSent", value);
            }
        }

        public System.UInt32? ConnectionsEstablished
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ConnectionsEstablished", out result);
                return result;
            }

            set
            {
                this.SetProperty("ConnectionsEstablished", value);
            }
        }

        public System.UInt32? DatagramsReceived
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DatagramsReceived", out result);
                return result;
            }

            set
            {
                this.SetProperty("DatagramsReceived", value);
            }
        }

        public System.UInt32? DatagramsSent
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DatagramsSent", out result);
                return result;
            }

            set
            {
                this.SetProperty("DatagramsSent", value);
            }
        }

        public System.UInt32? HttpWebRequestsAbortedPerSec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("HttpWebRequestsAbortedPerSec", out result);
                return result;
            }

            set
            {
                this.SetProperty("HttpWebRequestsAbortedPerSec", value);
            }
        }

        public System.UInt64? HttpWebRequestsAverageLifetime
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("HttpWebRequestsAverageLifetime", out result);
                return result;
            }

            set
            {
                this.SetProperty("HttpWebRequestsAverageLifetime", value);
            }
        }

        public System.UInt64? HttpWebRequestsAverageQueueTime
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("HttpWebRequestsAverageQueueTime", out result);
                return result;
            }

            set
            {
                this.SetProperty("HttpWebRequestsAverageQueueTime", value);
            }
        }

        public System.UInt32? HttpWebRequestsCreatedPerSec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("HttpWebRequestsCreatedPerSec", out result);
                return result;
            }

            set
            {
                this.SetProperty("HttpWebRequestsCreatedPerSec", value);
            }
        }

        public System.UInt32? HttpWebRequestsFailedPerSec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("HttpWebRequestsFailedPerSec", out result);
                return result;
            }

            set
            {
                this.SetProperty("HttpWebRequestsFailedPerSec", value);
            }
        }

        public System.UInt32? HttpWebRequestsQueuedPerSec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("HttpWebRequestsQueuedPerSec", out result);
                return result;
            }

            set
            {
                this.SetProperty("HttpWebRequestsQueuedPerSec", value);
            }
        }
    }
}
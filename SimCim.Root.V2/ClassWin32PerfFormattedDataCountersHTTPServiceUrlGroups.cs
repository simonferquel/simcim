using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfFormattedDataCountersHTTPServiceUrlGroups : Win32PerfFormattedData
    {
        public Win32PerfFormattedDataCountersHTTPServiceUrlGroups()
        {
        }

        public Win32PerfFormattedDataCountersHTTPServiceUrlGroups(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? AllRequests
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("AllRequests", out result);
                return result;
            }

            set
            {
                this.SetProperty("AllRequests", value);
            }
        }

        public System.UInt64? BytesReceivedRate
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("BytesReceivedRate", out result);
                return result;
            }

            set
            {
                this.SetProperty("BytesReceivedRate", value);
            }
        }

        public System.UInt64? BytesSentRate
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("BytesSentRate", out result);
                return result;
            }

            set
            {
                this.SetProperty("BytesSentRate", value);
            }
        }

        public System.UInt64? BytesTransferredRate
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("BytesTransferredRate", out result);
                return result;
            }

            set
            {
                this.SetProperty("BytesTransferredRate", value);
            }
        }

        public System.UInt32? ConnectionAttempts
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ConnectionAttempts", out result);
                return result;
            }

            set
            {
                this.SetProperty("ConnectionAttempts", value);
            }
        }

        public System.UInt32? CurrentConnections
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CurrentConnections", out result);
                return result;
            }

            set
            {
                this.SetProperty("CurrentConnections", value);
            }
        }

        public System.UInt32? GetRequests
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("GetRequests", out result);
                return result;
            }

            set
            {
                this.SetProperty("GetRequests", value);
            }
        }

        public System.UInt32? HeadRequests
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("HeadRequests", out result);
                return result;
            }

            set
            {
                this.SetProperty("HeadRequests", value);
            }
        }

        public System.UInt32? MaxConnections
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaxConnections", out result);
                return result;
            }

            set
            {
                this.SetProperty("MaxConnections", value);
            }
        }
    }
}
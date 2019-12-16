using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataNETCLRNetworkingNETCLRNetworking : Win32PerfRawData
    {
        public Win32PerfRawDataNETCLRNetworkingNETCLRNetworking()
        {
        }

        public Win32PerfRawDataNETCLRNetworkingNETCLRNetworking(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
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
    }
}
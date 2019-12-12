using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataCountersPacketDirectReceiveCounters : Win32PerfRawData
    {
        public Win32PerfRawDataCountersPacketDirectReceiveCounters()
        {
        }

        public Win32PerfRawDataCountersPacketDirectReceiveCounters(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
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

        public System.UInt64? BytesReceivedPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("BytesReceivedPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("BytesReceivedPersec", value);
            }
        }

        public System.UInt64? PacketsDropped
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PacketsDropped", out result);
                return result;
            }

            set
            {
                this.SetProperty("PacketsDropped", value);
            }
        }

        public System.UInt64? PacketsDroppedPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PacketsDroppedPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("PacketsDroppedPersec", value);
            }
        }

        public System.UInt64? PacketsReceived
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PacketsReceived", out result);
                return result;
            }

            set
            {
                this.SetProperty("PacketsReceived", value);
            }
        }

        public System.UInt64? PacketsReceivedPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PacketsReceivedPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("PacketsReceivedPersec", value);
            }
        }
    }
}
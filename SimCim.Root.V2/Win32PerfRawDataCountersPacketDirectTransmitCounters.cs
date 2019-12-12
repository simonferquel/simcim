using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataCountersPacketDirectTransmitCounters : Win32PerfRawData
    {
        public Win32PerfRawDataCountersPacketDirectTransmitCounters()
        {
        }

        public Win32PerfRawDataCountersPacketDirectTransmitCounters(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? BytesTransmitted
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("BytesTransmitted", out result);
                return result;
            }

            set
            {
                this.SetProperty("BytesTransmitted", value);
            }
        }

        public System.UInt64? BytesTransmittedPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("BytesTransmittedPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("BytesTransmittedPersec", value);
            }
        }

        public System.UInt64? PacketsTransmitted
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PacketsTransmitted", out result);
                return result;
            }

            set
            {
                this.SetProperty("PacketsTransmitted", value);
            }
        }

        public System.UInt64? PacketsTransmittedPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PacketsTransmittedPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("PacketsTransmittedPersec", value);
            }
        }
    }
}
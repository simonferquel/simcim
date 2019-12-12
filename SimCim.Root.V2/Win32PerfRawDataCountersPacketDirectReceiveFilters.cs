using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataCountersPacketDirectReceiveFilters : Win32PerfRawData
    {
        public Win32PerfRawDataCountersPacketDirectReceiveFilters()
        {
        }

        public Win32PerfRawDataCountersPacketDirectReceiveFilters(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? BytesMatched
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("BytesMatched", out result);
                return result;
            }

            set
            {
                this.SetProperty("BytesMatched", value);
            }
        }

        public System.UInt64? BytesMatchedPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("BytesMatchedPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("BytesMatchedPersec", value);
            }
        }

        public System.UInt64? PacketsMatched
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PacketsMatched", out result);
                return result;
            }

            set
            {
                this.SetProperty("PacketsMatched", value);
            }
        }

        public System.UInt64? PacketsMatchedPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PacketsMatchedPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("PacketsMatchedPersec", value);
            }
        }
    }
}
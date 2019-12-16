using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfFormattedDataMicrosoftWindowsW32TimePerfWindowsTimeService : Win32PerfFormattedData
    {
        public Win32PerfFormattedDataMicrosoftWindowsW32TimePerfWindowsTimeService()
        {
        }

        public Win32PerfFormattedDataMicrosoftWindowsW32TimePerfWindowsTimeService(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? ClockFrequencyAdjustment
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ClockFrequencyAdjustment", out result);
                return result;
            }

            set
            {
                this.SetProperty("ClockFrequencyAdjustment", value);
            }
        }

        public System.UInt32? ClockFrequencyAdjustmentPPB
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ClockFrequencyAdjustmentPPB", out result);
                return result;
            }

            set
            {
                this.SetProperty("ClockFrequencyAdjustmentPPB", value);
            }
        }

        public System.UInt64? ComputedTimeOffset
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ComputedTimeOffset", out result);
                return result;
            }

            set
            {
                this.SetProperty("ComputedTimeOffset", value);
            }
        }

        public System.UInt32? NTPClientTimeSourceCount
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NTPClientTimeSourceCount", out result);
                return result;
            }

            set
            {
                this.SetProperty("NTPClientTimeSourceCount", value);
            }
        }

        public System.UInt32? NTPRoundtripDelay
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NTPRoundtripDelay", out result);
                return result;
            }

            set
            {
                this.SetProperty("NTPRoundtripDelay", value);
            }
        }

        public System.UInt64? NTPServerIncomingRequests
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("NTPServerIncomingRequests", out result);
                return result;
            }

            set
            {
                this.SetProperty("NTPServerIncomingRequests", value);
            }
        }

        public System.UInt64? NTPServerOutgoingResponses
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("NTPServerOutgoingResponses", out result);
                return result;
            }

            set
            {
                this.SetProperty("NTPServerOutgoingResponses", value);
            }
        }
    }
}
using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class Win32Perf : CIMStatisticalInformation
    {
        protected Win32Perf()
        {
        }

        protected Win32Perf(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? FrequencyObject
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("Frequency_Object", out result);
                return result;
            }

            set
            {
                this.SetProperty("Frequency_Object", value);
            }
        }

        public System.UInt64? FrequencyPerfTime
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("Frequency_PerfTime", out result);
                return result;
            }

            set
            {
                this.SetProperty("Frequency_PerfTime", value);
            }
        }

        public System.UInt64? FrequencySys100NS
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("Frequency_Sys100NS", out result);
                return result;
            }

            set
            {
                this.SetProperty("Frequency_Sys100NS", value);
            }
        }

        public System.UInt64? TimestampObject
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("Timestamp_Object", out result);
                return result;
            }

            set
            {
                this.SetProperty("Timestamp_Object", value);
            }
        }

        public System.UInt64? TimestampPerfTime
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("Timestamp_PerfTime", out result);
                return result;
            }

            set
            {
                this.SetProperty("Timestamp_PerfTime", value);
            }
        }

        public System.UInt64? TimestampSys100NS
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("Timestamp_Sys100NS", out result);
                return result;
            }

            set
            {
                this.SetProperty("Timestamp_Sys100NS", value);
            }
        }
    }
}
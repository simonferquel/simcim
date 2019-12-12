using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataPerfOSPagingFile : Win32PerfRawData
    {
        public Win32PerfRawDataPerfOSPagingFile()
        {
        }

        public Win32PerfRawDataPerfOSPagingFile(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? PercentUsage
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PercentUsage", out result);
                return result;
            }

            set
            {
                this.SetProperty("PercentUsage", value);
            }
        }

        public System.UInt32? PercentUsageBase
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PercentUsage_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("PercentUsage_Base", value);
            }
        }

        public System.UInt32? PercentUsagePeak
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PercentUsagePeak", out result);
                return result;
            }

            set
            {
                this.SetProperty("PercentUsagePeak", value);
            }
        }

        public System.UInt32? PercentUsagePeakBase
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PercentUsagePeak_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("PercentUsagePeak_Base", value);
            }
        }
    }
}
using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataPerfProcJobObject : Win32PerfRawData
    {
        public Win32PerfRawDataPerfProcJobObject()
        {
        }

        public Win32PerfRawDataPerfProcJobObject(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? CurrentPercentKernelModeTime
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("CurrentPercentKernelModeTime", out result);
                return result;
            }

            set
            {
                this.SetProperty("CurrentPercentKernelModeTime", value);
            }
        }

        public System.UInt64? CurrentPercentProcessorTime
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("CurrentPercentProcessorTime", out result);
                return result;
            }

            set
            {
                this.SetProperty("CurrentPercentProcessorTime", value);
            }
        }

        public System.UInt64? CurrentPercentUserModeTime
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("CurrentPercentUserModeTime", out result);
                return result;
            }

            set
            {
                this.SetProperty("CurrentPercentUserModeTime", value);
            }
        }

        public System.UInt32? PagesPerSec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PagesPerSec", out result);
                return result;
            }

            set
            {
                this.SetProperty("PagesPerSec", value);
            }
        }

        public System.UInt32? ProcessCountActive
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ProcessCountActive", out result);
                return result;
            }

            set
            {
                this.SetProperty("ProcessCountActive", value);
            }
        }

        public System.UInt32? ProcessCountTerminated
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ProcessCountTerminated", out result);
                return result;
            }

            set
            {
                this.SetProperty("ProcessCountTerminated", value);
            }
        }

        public System.UInt32? ProcessCountTotal
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ProcessCountTotal", out result);
                return result;
            }

            set
            {
                this.SetProperty("ProcessCountTotal", value);
            }
        }

        public System.UInt64? ThisPeriodmSecKernelMode
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ThisPeriodmSecKernelMode", out result);
                return result;
            }

            set
            {
                this.SetProperty("ThisPeriodmSecKernelMode", value);
            }
        }

        public System.UInt64? ThisPeriodmSecProcessor
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ThisPeriodmSecProcessor", out result);
                return result;
            }

            set
            {
                this.SetProperty("ThisPeriodmSecProcessor", value);
            }
        }

        public System.UInt64? ThisPeriodmSecUserMode
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ThisPeriodmSecUserMode", out result);
                return result;
            }

            set
            {
                this.SetProperty("ThisPeriodmSecUserMode", value);
            }
        }

        public System.UInt64? TotalmSecKernelMode
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalmSecKernelMode", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalmSecKernelMode", value);
            }
        }

        public System.UInt64? TotalmSecProcessor
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalmSecProcessor", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalmSecProcessor", value);
            }
        }

        public System.UInt64? TotalmSecUserMode
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalmSecUserMode", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalmSecUserMode", value);
            }
        }
    }
}
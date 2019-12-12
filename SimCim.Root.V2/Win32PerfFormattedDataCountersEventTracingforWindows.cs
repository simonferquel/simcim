using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfFormattedDataCountersEventTracingforWindows : Win32PerfFormattedData
    {
        public Win32PerfFormattedDataCountersEventTracingforWindows()
        {
        }

        public Win32PerfFormattedDataCountersEventTracingforWindows(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? TotalMemoryUsageNonPagedPool
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TotalMemoryUsageNonPagedPool", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalMemoryUsageNonPagedPool", value);
            }
        }

        public System.UInt32? TotalMemoryUsagePagedPool
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TotalMemoryUsagePagedPool", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalMemoryUsagePagedPool", value);
            }
        }

        public System.UInt32? TotalNumberofActiveSessions
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TotalNumberofActiveSessions", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalNumberofActiveSessions", value);
            }
        }

        public System.UInt32? TotalNumberofDistinctDisabledProviders
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TotalNumberofDistinctDisabledProviders", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalNumberofDistinctDisabledProviders", value);
            }
        }

        public System.UInt32? TotalNumberofDistinctEnabledProviders
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TotalNumberofDistinctEnabledProviders", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalNumberofDistinctEnabledProviders", value);
            }
        }

        public System.UInt32? TotalNumberofDistinctPreEnabledProviders
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TotalNumberofDistinctPreEnabledProviders", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalNumberofDistinctPreEnabledProviders", value);
            }
        }
    }
}
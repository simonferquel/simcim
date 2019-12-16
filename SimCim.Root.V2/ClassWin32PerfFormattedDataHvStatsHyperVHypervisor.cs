using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfFormattedDataHvStatsHyperVHypervisor : Win32PerfFormattedData
    {
        public Win32PerfFormattedDataHvStatsHyperVHypervisor()
        {
        }

        public Win32PerfFormattedDataHvStatsHyperVHypervisor(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? HypervisorStartupCost
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("HypervisorStartupCost", out result);
                return result;
            }

            set
            {
                this.SetProperty("HypervisorStartupCost", value);
            }
        }

        public System.UInt64? LogicalProcessors
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("LogicalProcessors", out result);
                return result;
            }

            set
            {
                this.SetProperty("LogicalProcessors", value);
            }
        }

        public System.UInt64? ModernStandbyEntries
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ModernStandbyEntries", out result);
                return result;
            }

            set
            {
                this.SetProperty("ModernStandbyEntries", value);
            }
        }

        public System.UInt64? MonitoredNotifications
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("MonitoredNotifications", out result);
                return result;
            }

            set
            {
                this.SetProperty("MonitoredNotifications", value);
            }
        }

        public System.UInt64? Partitions
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("Partitions", out result);
                return result;
            }

            set
            {
                this.SetProperty("Partitions", value);
            }
        }

        public System.UInt64? PlatformIdleTransitions
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PlatformIdleTransitions", out result);
                return result;
            }

            set
            {
                this.SetProperty("PlatformIdleTransitions", value);
            }
        }

        public System.UInt64? TotalPages
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalPages", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalPages", value);
            }
        }

        public System.UInt64? VirtualProcessors
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("VirtualProcessors", out result);
                return result;
            }

            set
            {
                this.SetProperty("VirtualProcessors", value);
            }
        }
    }
}
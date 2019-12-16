using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataCountersStorageQoSFilterVolume : Win32PerfRawData
    {
        public Win32PerfRawDataCountersStorageQoSFilterVolume()
        {
        }

        public Win32PerfRawDataCountersStorageQoSFilterVolume(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? AllocationQuantum
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AllocationQuantum", out result);
                return result;
            }

            set
            {
                this.SetProperty("AllocationQuantum", value);
            }
        }

        public System.UInt64? AvgBandwidth
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AvgBandwidth", out result);
                return result;
            }

            set
            {
                this.SetProperty("AvgBandwidth", value);
            }
        }

        public System.UInt64? AvgDeviceLatency
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AvgDeviceLatency", out result);
                return result;
            }

            set
            {
                this.SetProperty("AvgDeviceLatency", value);
            }
        }

        public System.UInt64? AvgDeviceQueueLength
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AvgDeviceQueueLength", out result);
                return result;
            }

            set
            {
                this.SetProperty("AvgDeviceQueueLength", value);
            }
        }

        public System.UInt64? AvgIOCost
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AvgIOCost", out result);
                return result;
            }

            set
            {
                this.SetProperty("AvgIOCost", value);
            }
        }

        public System.UInt64? AvgNormalizedIOCost
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AvgNormalizedIOCost", out result);
                return result;
            }

            set
            {
                this.SetProperty("AvgNormalizedIOCost", value);
            }
        }

        public System.UInt64? AvgSchedulerQueueLength
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AvgSchedulerQueueLength", out result);
                return result;
            }

            set
            {
                this.SetProperty("AvgSchedulerQueueLength", value);
            }
        }

        public System.UInt64? CongestionThreshold
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("CongestionThreshold", out result);
                return result;
            }

            set
            {
                this.SetProperty("CongestionThreshold", value);
            }
        }

        public System.UInt64? DelayedCost
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("DelayedCost", out result);
                return result;
            }

            set
            {
                this.SetProperty("DelayedCost", value);
            }
        }

        public System.UInt64? EstimatedCapacity
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("EstimatedCapacity", out result);
                return result;
            }

            set
            {
                this.SetProperty("EstimatedCapacity", value);
            }
        }

        public System.UInt64? FlowSwitchCost
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FlowSwitchCost", out result);
                return result;
            }

            set
            {
                this.SetProperty("FlowSwitchCost", value);
            }
        }

        public System.UInt64? IssuedCost
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("IssuedCost", out result);
                return result;
            }

            set
            {
                this.SetProperty("IssuedCost", value);
            }
        }

        public System.UInt64? LatencyTarget
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("LatencyTarget", out result);
                return result;
            }

            set
            {
                this.SetProperty("LatencyTarget", value);
            }
        }

        public System.UInt64? LowerThreshold
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("LowerThreshold", out result);
                return result;
            }

            set
            {
                this.SetProperty("LowerThreshold", value);
            }
        }

        public System.UInt64? NormalizedThroughput
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("NormalizedThroughput", out result);
                return result;
            }

            set
            {
                this.SetProperty("NormalizedThroughput", value);
            }
        }

        public System.UInt64? OverheadCost
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("OverheadCost", out result);
                return result;
            }

            set
            {
                this.SetProperty("OverheadCost", value);
            }
        }

        public System.UInt64? SectorCost
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("SectorCost", out result);
                return result;
            }

            set
            {
                this.SetProperty("SectorCost", value);
            }
        }

        public System.UInt64? SeekCost
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("SeekCost", out result);
                return result;
            }

            set
            {
                this.SetProperty("SeekCost", value);
            }
        }
    }
}
using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataCountersStorageQoSFilterFlow : Win32PerfRawData
    {
        public Win32PerfRawDataCountersStorageQoSFilterFlow()
        {
        }

        public Win32PerfRawDataCountersStorageQoSFilterFlow(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
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

        public System.UInt64? AvgIOQuotaReplenishmentOperationsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AvgIOQuotaReplenishmentOperationsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("AvgIOQuotaReplenishmentOperationsPersec", value);
            }
        }

        public System.UInt64? AvgNormalizedIOPS
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AvgNormalizedIOPS", out result);
                return result;
            }

            set
            {
                this.SetProperty("AvgNormalizedIOPS", value);
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

        public System.UInt64? MaximumBandwidth
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("MaximumBandwidth", out result);
                return result;
            }

            set
            {
                this.SetProperty("MaximumBandwidth", value);
            }
        }

        public System.UInt64? NormalizedMaximumIORate
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("NormalizedMaximumIORate", out result);
                return result;
            }

            set
            {
                this.SetProperty("NormalizedMaximumIORate", value);
            }
        }

        public System.UInt64? NormalizedMinimumIORate
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("NormalizedMinimumIORate", out result);
                return result;
            }

            set
            {
                this.SetProperty("NormalizedMinimumIORate", value);
            }
        }

        public System.UInt64? TotalBandwidthquotaIncrementPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalBandwidthquotaIncrementPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalBandwidthquotaIncrementPersec", value);
            }
        }

        public System.UInt64? TotalNormalizedIOQuotaIncrement
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalNormalizedIOQuotaIncrement", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalNormalizedIOQuotaIncrement", value);
            }
        }
    }
}
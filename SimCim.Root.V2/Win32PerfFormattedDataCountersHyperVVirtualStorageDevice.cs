using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfFormattedDataCountersHyperVVirtualStorageDevice : Win32PerfFormattedData
    {
        public Win32PerfFormattedDataCountersHyperVVirtualStorageDevice()
        {
        }

        public Win32PerfFormattedDataCountersHyperVVirtualStorageDevice(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? AdapterOpenChannelCount
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("AdapterOpenChannelCount", out result);
                return result;
            }

            set
            {
                this.SetProperty("AdapterOpenChannelCount", value);
            }
        }

        public System.UInt64? ByteQuotaReplenishmentRate
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ByteQuotaReplenishmentRate", out result);
                return result;
            }

            set
            {
                this.SetProperty("ByteQuotaReplenishmentRate", value);
            }
        }

        public System.UInt32? ErrorCount
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ErrorCount", out result);
                return result;
            }

            set
            {
                this.SetProperty("ErrorCount", value);
            }
        }

        public System.UInt32? FlushCount
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("FlushCount", out result);
                return result;
            }

            set
            {
                this.SetProperty("FlushCount", value);
            }
        }

        public System.UInt64? IoQuotaReplenishmentRate
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("IoQuotaReplenishmentRate", out result);
                return result;
            }

            set
            {
                this.SetProperty("IoQuotaReplenishmentRate", value);
            }
        }

        public System.UInt32? Latency
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Latency", out result);
                return result;
            }

            set
            {
                this.SetProperty("Latency", value);
            }
        }

        public System.UInt32? LowerLatency
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("LowerLatency", out result);
                return result;
            }

            set
            {
                this.SetProperty("LowerLatency", value);
            }
        }

        public System.UInt64? LowerQueueLength
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("LowerQueueLength", out result);
                return result;
            }

            set
            {
                this.SetProperty("LowerQueueLength", value);
            }
        }

        public System.UInt32? MaximumAdapterWorkerCount
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaximumAdapterWorkerCount", out result);
                return result;
            }

            set
            {
                this.SetProperty("MaximumAdapterWorkerCount", value);
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

        public System.UInt64? MaximumIORate
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("MaximumIORate", out result);
                return result;
            }

            set
            {
                this.SetProperty("MaximumIORate", value);
            }
        }

        public System.UInt64? MinimumIORate
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("MinimumIORate", out result);
                return result;
            }

            set
            {
                this.SetProperty("MinimumIORate", value);
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

        public System.UInt64? QueueLength
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("QueueLength", out result);
                return result;
            }

            set
            {
                this.SetProperty("QueueLength", value);
            }
        }

        public System.UInt64? ReadBytesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ReadBytesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReadBytesPersec", value);
            }
        }

        public System.UInt32? ReadCount
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ReadCount", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReadCount", value);
            }
        }

        public System.UInt32? ReadOperationsPerSec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ReadOperationsPerSec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReadOperationsPerSec", value);
            }
        }

        public System.UInt32? Throughput
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Throughput", out result);
                return result;
            }

            set
            {
                this.SetProperty("Throughput", value);
            }
        }

        public System.UInt64? WriteBytesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("WriteBytesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("WriteBytesPersec", value);
            }
        }

        public System.UInt32? WriteCount
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("WriteCount", out result);
                return result;
            }

            set
            {
                this.SetProperty("WriteCount", value);
            }
        }

        public System.UInt32? WriteOperationsPerSec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("WriteOperationsPerSec", out result);
                return result;
            }

            set
            {
                this.SetProperty("WriteOperationsPerSec", value);
            }
        }
    }
}
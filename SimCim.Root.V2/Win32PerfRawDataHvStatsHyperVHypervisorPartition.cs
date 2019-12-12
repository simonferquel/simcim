using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataHvStatsHyperVHypervisorPartition : Win32PerfRawData
    {
        public Win32PerfRawDataHvStatsHyperVHypervisorPartition()
        {
        }

        public Win32PerfRawDataHvStatsHyperVHypervisorPartition(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? AddressSpaces
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AddressSpaces", out result);
                return result;
            }

            set
            {
                this.SetProperty("AddressSpaces", value);
            }
        }

        public System.UInt64? AttachedDevices
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AttachedDevices", out result);
                return result;
            }

            set
            {
                this.SetProperty("AttachedDevices", value);
            }
        }

        public System.UInt64? DepositedPages
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("DepositedPages", out result);
                return result;
            }

            set
            {
                this.SetProperty("DepositedPages", value);
            }
        }

        public System.UInt64? DeviceDMAErrors
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("DeviceDMAErrors", out result);
                return result;
            }

            set
            {
                this.SetProperty("DeviceDMAErrors", value);
            }
        }

        public System.UInt64? DeviceInterruptErrors
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("DeviceInterruptErrors", out result);
                return result;
            }

            set
            {
                this.SetProperty("DeviceInterruptErrors", value);
            }
        }

        public System.UInt64? DeviceInterruptMappings
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("DeviceInterruptMappings", out result);
                return result;
            }

            set
            {
                this.SetProperty("DeviceInterruptMappings", value);
            }
        }

        public System.UInt64? DeviceInterruptThrottleEvents
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("DeviceInterruptThrottleEvents", out result);
                return result;
            }

            set
            {
                this.SetProperty("DeviceInterruptThrottleEvents", value);
            }
        }

        public System.UInt64? GPAPages
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("GPAPages", out result);
                return result;
            }

            set
            {
                this.SetProperty("GPAPages", value);
            }
        }

        public System.UInt64? GPASpaceModificationsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("GPASpaceModificationsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("GPASpaceModificationsPersec", value);
            }
        }

        public System.UInt64? IOTLBFlushCost
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("IOTLBFlushCost", out result);
                return result;
            }

            set
            {
                this.SetProperty("IOTLBFlushCost", value);
            }
        }

        public System.UInt64? IOTLBFlushCostBase
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("IOTLBFlushCost_Base", out result);
                return result;
            }

            set
            {
                this.SetProperty("IOTLBFlushCost_Base", value);
            }
        }

        public System.UInt64? IOTLBFlushesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("IOTLBFlushesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("IOTLBFlushesPersec", value);
            }
        }

        public System.UInt64? NestedTLBFreeListSize
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("NestedTLBFreeListSize", out result);
                return result;
            }

            set
            {
                this.SetProperty("NestedTLBFreeListSize", value);
            }
        }

        public System.UInt64? NestedTLBSize
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("NestedTLBSize", out result);
                return result;
            }

            set
            {
                this.SetProperty("NestedTLBSize", value);
            }
        }

        public System.UInt64? NestedTLBTrimmedPagesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("NestedTLBTrimmedPagesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("NestedTLBTrimmedPagesPersec", value);
            }
        }

        public System.UInt64? PagesRecombinedPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PagesRecombinedPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("PagesRecombinedPersec", value);
            }
        }

        public System.UInt64? PagesShatteredPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PagesShatteredPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("PagesShatteredPersec", value);
            }
        }

        public System.UInt64? RecommendedNestedTLBSize
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("RecommendedNestedTLBSize", out result);
                return result;
            }

            set
            {
                this.SetProperty("RecommendedNestedTLBSize", value);
            }
        }

        public System.UInt64? RecommendedVirtualTLBSize
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("RecommendedVirtualTLBSize", out result);
                return result;
            }

            set
            {
                this.SetProperty("RecommendedVirtualTLBSize", value);
            }
        }

        public System.UInt64? SkippedTimerTicks
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("SkippedTimerTicks", out result);
                return result;
            }

            set
            {
                this.SetProperty("SkippedTimerTicks", value);
            }
        }

        public System.UInt64? Value1Gdevicepages
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("Value1Gdevicepages", out result);
                return result;
            }

            set
            {
                this.SetProperty("Value1Gdevicepages", value);
            }
        }

        public System.UInt64? Value1GGPApages
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("Value1GGPApages", out result);
                return result;
            }

            set
            {
                this.SetProperty("Value1GGPApages", value);
            }
        }

        public System.UInt64? Value2Mdevicepages
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("Value2Mdevicepages", out result);
                return result;
            }

            set
            {
                this.SetProperty("Value2Mdevicepages", value);
            }
        }

        public System.UInt64? Value2MGPApages
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("Value2MGPApages", out result);
                return result;
            }

            set
            {
                this.SetProperty("Value2MGPApages", value);
            }
        }

        public System.UInt64? Value4Kdevicepages
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("Value4Kdevicepages", out result);
                return result;
            }

            set
            {
                this.SetProperty("Value4Kdevicepages", value);
            }
        }

        public System.UInt64? Value4KGPApages
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("Value4KGPApages", out result);
                return result;
            }

            set
            {
                this.SetProperty("Value4KGPApages", value);
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

        public System.UInt64? VirtualTLBFlushEntiresPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("VirtualTLBFlushEntiresPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("VirtualTLBFlushEntiresPersec", value);
            }
        }

        public System.UInt64? VirtualTLBPages
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("VirtualTLBPages", out result);
                return result;
            }

            set
            {
                this.SetProperty("VirtualTLBPages", value);
            }
        }
    }
}
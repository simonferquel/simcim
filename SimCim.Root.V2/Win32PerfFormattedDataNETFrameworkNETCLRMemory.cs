using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfFormattedDataNETFrameworkNETCLRMemory : Win32PerfFormattedData
    {
        public Win32PerfFormattedDataNETFrameworkNETCLRMemory()
        {
        }

        public Win32PerfFormattedDataNETFrameworkNETCLRMemory(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? AllocatedBytesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AllocatedBytesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("AllocatedBytesPersec", value);
            }
        }

        public System.UInt64? FinalizationSurvivors
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FinalizationSurvivors", out result);
                return result;
            }

            set
            {
                this.SetProperty("FinalizationSurvivors", value);
            }
        }

        public System.UInt64? Gen0heapsize
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("Gen0heapsize", out result);
                return result;
            }

            set
            {
                this.SetProperty("Gen0heapsize", value);
            }
        }

        public System.UInt64? Gen0PromotedBytesPerSec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("Gen0PromotedBytesPerSec", out result);
                return result;
            }

            set
            {
                this.SetProperty("Gen0PromotedBytesPerSec", value);
            }
        }

        public System.UInt64? Gen1heapsize
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("Gen1heapsize", out result);
                return result;
            }

            set
            {
                this.SetProperty("Gen1heapsize", value);
            }
        }

        public System.UInt64? Gen1PromotedBytesPerSec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("Gen1PromotedBytesPerSec", out result);
                return result;
            }

            set
            {
                this.SetProperty("Gen1PromotedBytesPerSec", value);
            }
        }

        public System.UInt64? Gen2heapsize
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("Gen2heapsize", out result);
                return result;
            }

            set
            {
                this.SetProperty("Gen2heapsize", value);
            }
        }

        public System.UInt64? LargeObjectHeapsize
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("LargeObjectHeapsize", out result);
                return result;
            }

            set
            {
                this.SetProperty("LargeObjectHeapsize", value);
            }
        }

        public System.UInt64? NumberBytesinallHeaps
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("NumberBytesinallHeaps", out result);
                return result;
            }

            set
            {
                this.SetProperty("NumberBytesinallHeaps", value);
            }
        }

        public System.UInt64? NumberGCHandles
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("NumberGCHandles", out result);
                return result;
            }

            set
            {
                this.SetProperty("NumberGCHandles", value);
            }
        }

        public System.UInt64? NumberGen0Collections
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("NumberGen0Collections", out result);
                return result;
            }

            set
            {
                this.SetProperty("NumberGen0Collections", value);
            }
        }

        public System.UInt64? NumberGen1Collections
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("NumberGen1Collections", out result);
                return result;
            }

            set
            {
                this.SetProperty("NumberGen1Collections", value);
            }
        }

        public System.UInt64? NumberGen2Collections
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("NumberGen2Collections", out result);
                return result;
            }

            set
            {
                this.SetProperty("NumberGen2Collections", value);
            }
        }

        public System.UInt64? NumberInducedGC
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("NumberInducedGC", out result);
                return result;
            }

            set
            {
                this.SetProperty("NumberInducedGC", value);
            }
        }

        public System.UInt64? NumberofPinnedObjects
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("NumberofPinnedObjects", out result);
                return result;
            }

            set
            {
                this.SetProperty("NumberofPinnedObjects", value);
            }
        }

        public System.UInt64? NumberofSinkBlocksinuse
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("NumberofSinkBlocksinuse", out result);
                return result;
            }

            set
            {
                this.SetProperty("NumberofSinkBlocksinuse", value);
            }
        }

        public System.UInt64? NumberTotalcommittedBytes
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("NumberTotalcommittedBytes", out result);
                return result;
            }

            set
            {
                this.SetProperty("NumberTotalcommittedBytes", value);
            }
        }

        public System.UInt64? NumberTotalreservedBytes
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("NumberTotalreservedBytes", out result);
                return result;
            }

            set
            {
                this.SetProperty("NumberTotalreservedBytes", value);
            }
        }

        public System.UInt32? PercentTimeinGC
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PercentTimeinGC", out result);
                return result;
            }

            set
            {
                this.SetProperty("PercentTimeinGC", value);
            }
        }

        public System.UInt64? ProcessID
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ProcessID", out result);
                return result;
            }

            set
            {
                this.SetProperty("ProcessID", value);
            }
        }

        public System.UInt64? PromotedFinalizationMemoryfromGen0
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PromotedFinalizationMemoryfromGen0", out result);
                return result;
            }

            set
            {
                this.SetProperty("PromotedFinalizationMemoryfromGen0", value);
            }
        }

        public System.UInt64? PromotedMemoryfromGen0
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PromotedMemoryfromGen0", out result);
                return result;
            }

            set
            {
                this.SetProperty("PromotedMemoryfromGen0", value);
            }
        }

        public System.UInt64? PromotedMemoryfromGen1
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PromotedMemoryfromGen1", out result);
                return result;
            }

            set
            {
                this.SetProperty("PromotedMemoryfromGen1", value);
            }
        }
    }
}
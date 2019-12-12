using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataBalancerStatsHyperVDynamicMemoryVM : Win32PerfRawData
    {
        public Win32PerfRawDataBalancerStatsHyperVDynamicMemoryVM()
        {
        }

        public Win32PerfRawDataBalancerStatsHyperVDynamicMemoryVM(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? AddedMemory
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AddedMemory", out result);
                return result;
            }

            set
            {
                this.SetProperty("AddedMemory", value);
            }
        }

        public System.UInt32? AveragePressure
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("AveragePressure", out result);
                return result;
            }

            set
            {
                this.SetProperty("AveragePressure", value);
            }
        }

        public System.UInt32? CurrentPressure
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CurrentPressure", out result);
                return result;
            }

            set
            {
                this.SetProperty("CurrentPressure", value);
            }
        }

        public System.UInt32? GuestAvailableMemory
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("GuestAvailableMemory", out result);
                return result;
            }

            set
            {
                this.SetProperty("GuestAvailableMemory", value);
            }
        }

        public System.UInt32? GuestVisiblePhysicalMemory
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("GuestVisiblePhysicalMemory", out result);
                return result;
            }

            set
            {
                this.SetProperty("GuestVisiblePhysicalMemory", value);
            }
        }

        public System.UInt32? MaximumPressure
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaximumPressure", out result);
                return result;
            }

            set
            {
                this.SetProperty("MaximumPressure", value);
            }
        }

        public System.UInt64? MemoryAddOperations
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("MemoryAddOperations", out result);
                return result;
            }

            set
            {
                this.SetProperty("MemoryAddOperations", value);
            }
        }

        public System.UInt64? MemoryRemoveOperations
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("MemoryRemoveOperations", out result);
                return result;
            }

            set
            {
                this.SetProperty("MemoryRemoveOperations", value);
            }
        }

        public System.UInt32? MinimumPressure
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MinimumPressure", out result);
                return result;
            }

            set
            {
                this.SetProperty("MinimumPressure", value);
            }
        }

        public System.UInt32? PhysicalMemory
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PhysicalMemory", out result);
                return result;
            }

            set
            {
                this.SetProperty("PhysicalMemory", value);
            }
        }

        public System.UInt64? RemovedMemory
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("RemovedMemory", out result);
                return result;
            }

            set
            {
                this.SetProperty("RemovedMemory", value);
            }
        }

        public System.UInt32? SmartPagingWorkingSetSize
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SmartPagingWorkingSetSize", out result);
                return result;
            }

            set
            {
                this.SetProperty("SmartPagingWorkingSetSize", value);
            }
        }
    }
}
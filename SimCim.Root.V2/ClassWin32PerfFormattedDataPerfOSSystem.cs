using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfFormattedDataPerfOSSystem : Win32PerfFormattedData
    {
        public Win32PerfFormattedDataPerfOSSystem()
        {
        }

        public Win32PerfFormattedDataPerfOSSystem(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? AlignmentFixupsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("AlignmentFixupsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("AlignmentFixupsPersec", value);
            }
        }

        public System.UInt32? ContextSwitchesPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ContextSwitchesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ContextSwitchesPersec", value);
            }
        }

        public System.UInt32? ExceptionDispatchesPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ExceptionDispatchesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ExceptionDispatchesPersec", value);
            }
        }

        public System.UInt64? FileControlBytesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FileControlBytesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("FileControlBytesPersec", value);
            }
        }

        public System.UInt32? FileControlOperationsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("FileControlOperationsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("FileControlOperationsPersec", value);
            }
        }

        public System.UInt32? FileDataOperationsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("FileDataOperationsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("FileDataOperationsPersec", value);
            }
        }

        public System.UInt64? FileReadBytesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FileReadBytesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("FileReadBytesPersec", value);
            }
        }

        public System.UInt32? FileReadOperationsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("FileReadOperationsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("FileReadOperationsPersec", value);
            }
        }

        public System.UInt64? FileWriteBytesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FileWriteBytesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("FileWriteBytesPersec", value);
            }
        }

        public System.UInt32? FileWriteOperationsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("FileWriteOperationsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("FileWriteOperationsPersec", value);
            }
        }

        public System.UInt32? FloatingEmulationsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("FloatingEmulationsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("FloatingEmulationsPersec", value);
            }
        }

        public System.UInt32? PercentRegistryQuotaInUse
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PercentRegistryQuotaInUse", out result);
                return result;
            }

            set
            {
                this.SetProperty("PercentRegistryQuotaInUse", value);
            }
        }

        public System.UInt32? Processes
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Processes", out result);
                return result;
            }

            set
            {
                this.SetProperty("Processes", value);
            }
        }

        public System.UInt32? ProcessorQueueLength
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ProcessorQueueLength", out result);
                return result;
            }

            set
            {
                this.SetProperty("ProcessorQueueLength", value);
            }
        }

        public System.UInt32? SystemCallsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SystemCallsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("SystemCallsPersec", value);
            }
        }

        public System.UInt64? SystemUpTime
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("SystemUpTime", out result);
                return result;
            }

            set
            {
                this.SetProperty("SystemUpTime", value);
            }
        }

        public System.UInt32? Threads
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Threads", out result);
                return result;
            }

            set
            {
                this.SetProperty("Threads", value);
            }
        }
    }
}
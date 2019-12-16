using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataPerfProcJobObjectDetails : Win32PerfRawData
    {
        public Win32PerfRawDataPerfProcJobObjectDetails()
        {
        }

        public Win32PerfRawDataPerfProcJobObjectDetails(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? CreatingProcessID
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("CreatingProcessID", out result);
                return result;
            }

            set
            {
                this.SetProperty("CreatingProcessID", value);
            }
        }

        public System.UInt64? ElapsedTime
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ElapsedTime", out result);
                return result;
            }

            set
            {
                this.SetProperty("ElapsedTime", value);
            }
        }

        public System.UInt32? HandleCount
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("HandleCount", out result);
                return result;
            }

            set
            {
                this.SetProperty("HandleCount", value);
            }
        }

        public System.UInt64? IDProcess
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("IDProcess", out result);
                return result;
            }

            set
            {
                this.SetProperty("IDProcess", value);
            }
        }

        public System.UInt64? IODataBytesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("IODataBytesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("IODataBytesPersec", value);
            }
        }

        public System.UInt64? IODataOperationsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("IODataOperationsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("IODataOperationsPersec", value);
            }
        }

        public System.UInt64? IOOtherBytesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("IOOtherBytesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("IOOtherBytesPersec", value);
            }
        }

        public System.UInt64? IOOtherOperationsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("IOOtherOperationsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("IOOtherOperationsPersec", value);
            }
        }

        public System.UInt64? IOReadBytesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("IOReadBytesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("IOReadBytesPersec", value);
            }
        }

        public System.UInt64? IOReadOperationsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("IOReadOperationsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("IOReadOperationsPersec", value);
            }
        }

        public System.UInt64? IOWriteBytesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("IOWriteBytesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("IOWriteBytesPersec", value);
            }
        }

        public System.UInt64? IOWriteOperationsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("IOWriteOperationsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("IOWriteOperationsPersec", value);
            }
        }

        public System.UInt32? PageFaultsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PageFaultsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("PageFaultsPersec", value);
            }
        }

        public System.UInt64? PageFileBytes
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PageFileBytes", out result);
                return result;
            }

            set
            {
                this.SetProperty("PageFileBytes", value);
            }
        }

        public System.UInt64? PageFileBytesPeak
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PageFileBytesPeak", out result);
                return result;
            }

            set
            {
                this.SetProperty("PageFileBytesPeak", value);
            }
        }

        public System.UInt64? PercentPrivilegedTime
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PercentPrivilegedTime", out result);
                return result;
            }

            set
            {
                this.SetProperty("PercentPrivilegedTime", value);
            }
        }

        public System.UInt64? PercentProcessorTime
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PercentProcessorTime", out result);
                return result;
            }

            set
            {
                this.SetProperty("PercentProcessorTime", value);
            }
        }

        public System.UInt64? PercentUserTime
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PercentUserTime", out result);
                return result;
            }

            set
            {
                this.SetProperty("PercentUserTime", value);
            }
        }

        public System.UInt32? PoolNonpagedBytes
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PoolNonpagedBytes", out result);
                return result;
            }

            set
            {
                this.SetProperty("PoolNonpagedBytes", value);
            }
        }

        public System.UInt32? PoolPagedBytes
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PoolPagedBytes", out result);
                return result;
            }

            set
            {
                this.SetProperty("PoolPagedBytes", value);
            }
        }

        public System.UInt32? PriorityBase
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PriorityBase", out result);
                return result;
            }

            set
            {
                this.SetProperty("PriorityBase", value);
            }
        }

        public System.UInt64? PrivateBytes
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PrivateBytes", out result);
                return result;
            }

            set
            {
                this.SetProperty("PrivateBytes", value);
            }
        }

        public System.UInt32? ThreadCount
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ThreadCount", out result);
                return result;
            }

            set
            {
                this.SetProperty("ThreadCount", value);
            }
        }

        public System.UInt64? VirtualBytes
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("VirtualBytes", out result);
                return result;
            }

            set
            {
                this.SetProperty("VirtualBytes", value);
            }
        }

        public System.UInt64? VirtualBytesPeak
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("VirtualBytesPeak", out result);
                return result;
            }

            set
            {
                this.SetProperty("VirtualBytesPeak", value);
            }
        }

        public System.UInt64? WorkingSet
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("WorkingSet", out result);
                return result;
            }

            set
            {
                this.SetProperty("WorkingSet", value);
            }
        }

        public System.UInt64? WorkingSetPeak
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("WorkingSetPeak", out result);
                return result;
            }

            set
            {
                this.SetProperty("WorkingSetPeak", value);
            }
        }
    }
}
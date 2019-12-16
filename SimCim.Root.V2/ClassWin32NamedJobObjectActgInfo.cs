using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32NamedJobObjectActgInfo : CIMStatisticalInformation
    {
        public Win32NamedJobObjectActgInfo()
        {
        }

        public Win32NamedJobObjectActgInfo(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? ActiveProcesses
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ActiveProcesses", out result);
                return result;
            }
        }

        public System.UInt64? OtherOperationCount
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("OtherOperationCount", out result);
                return result;
            }
        }

        public System.UInt64? OtherTransferCount
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("OtherTransferCount", out result);
                return result;
            }
        }

        public System.UInt32? PeakJobMemoryUsed
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PeakJobMemoryUsed", out result);
                return result;
            }
        }

        public System.UInt32? PeakProcessMemoryUsed
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PeakProcessMemoryUsed", out result);
                return result;
            }
        }

        public System.UInt64? ReadOperationCount
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ReadOperationCount", out result);
                return result;
            }
        }

        public System.UInt64? ReadTransferCount
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ReadTransferCount", out result);
                return result;
            }
        }

        public System.UInt64? ThisPeriodTotalKernelTime
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ThisPeriodTotalKernelTime", out result);
                return result;
            }
        }

        public System.UInt64? ThisPeriodTotalUserTime
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ThisPeriodTotalUserTime", out result);
                return result;
            }
        }

        public System.UInt64? TotalKernelTime
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalKernelTime", out result);
                return result;
            }
        }

        public System.UInt32? TotalPageFaultCount
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TotalPageFaultCount", out result);
                return result;
            }
        }

        public System.UInt32? TotalProcesses
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TotalProcesses", out result);
                return result;
            }
        }

        public System.UInt32? TotalTerminatedProcesses
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TotalTerminatedProcesses", out result);
                return result;
            }
        }

        public System.UInt64? TotalUserTime
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("TotalUserTime", out result);
                return result;
            }
        }

        public System.UInt64? WriteOperationCount
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("WriteOperationCount", out result);
                return result;
            }
        }

        public System.UInt64? WriteTransferCount
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("WriteTransferCount", out result);
                return result;
            }
        }
    }
}
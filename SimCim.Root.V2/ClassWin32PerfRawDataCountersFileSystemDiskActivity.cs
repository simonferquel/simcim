using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataCountersFileSystemDiskActivity : Win32PerfRawData
    {
        public Win32PerfRawDataCountersFileSystemDiskActivity()
        {
        }

        public Win32PerfRawDataCountersFileSystemDiskActivity(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? FileSystemBytesRead
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FileSystemBytesRead", out result);
                return result;
            }

            set
            {
                this.SetProperty("FileSystemBytesRead", value);
            }
        }

        public System.UInt64? FileSystemBytesWritten
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FileSystemBytesWritten", out result);
                return result;
            }

            set
            {
                this.SetProperty("FileSystemBytesWritten", value);
            }
        }
    }
}
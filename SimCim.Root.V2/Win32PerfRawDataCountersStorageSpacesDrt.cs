using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataCountersStorageSpacesDrt : Win32PerfRawData
    {
        public Win32PerfRawDataCountersStorageSpacesDrt()
        {
        }

        public Win32PerfRawDataCountersStorageSpacesDrt(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? CleanBytes
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("CleanBytes", out result);
                return result;
            }

            set
            {
                this.SetProperty("CleanBytes", value);
            }
        }

        public System.UInt64? CleanCount
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("CleanCount", out result);
                return result;
            }

            set
            {
                this.SetProperty("CleanCount", value);
            }
        }

        public System.UInt64? DirtyBytes
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("DirtyBytes", out result);
                return result;
            }

            set
            {
                this.SetProperty("DirtyBytes", value);
            }
        }

        public System.UInt64? DirtyCount
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("DirtyCount", out result);
                return result;
            }

            set
            {
                this.SetProperty("DirtyCount", value);
            }
        }

        public System.UInt64? FlushedBytes
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FlushedBytes", out result);
                return result;
            }

            set
            {
                this.SetProperty("FlushedBytes", value);
            }
        }

        public System.UInt64? FlushedCount
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FlushedCount", out result);
                return result;
            }

            set
            {
                this.SetProperty("FlushedCount", value);
            }
        }

        public System.UInt64? FlushingBytes
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FlushingBytes", out result);
                return result;
            }

            set
            {
                this.SetProperty("FlushingBytes", value);
            }
        }

        public System.UInt64? FlushingCount
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("FlushingCount", out result);
                return result;
            }

            set
            {
                this.SetProperty("FlushingCount", value);
            }
        }

        public System.UInt32? Limit
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Limit", out result);
                return result;
            }

            set
            {
                this.SetProperty("Limit", value);
            }
        }

        public System.UInt64? SynchronizingBytes
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("SynchronizingBytes", out result);
                return result;
            }

            set
            {
                this.SetProperty("SynchronizingBytes", value);
            }
        }

        public System.UInt64? SynchronizingCount
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("SynchronizingCount", out result);
                return result;
            }

            set
            {
                this.SetProperty("SynchronizingCount", value);
            }
        }
    }
}
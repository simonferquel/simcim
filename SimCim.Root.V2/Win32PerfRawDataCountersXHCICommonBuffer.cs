using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataCountersXHCICommonBuffer : Win32PerfRawData
    {
        public Win32PerfRawDataCountersXHCICommonBuffer()
        {
        }

        public Win32PerfRawDataCountersXHCICommonBuffer(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? AllocationCount
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("AllocationCount", out result);
                return result;
            }

            set
            {
                this.SetProperty("AllocationCount", value);
            }
        }

        public System.UInt32? FreeCount
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("FreeCount", out result);
                return result;
            }

            set
            {
                this.SetProperty("FreeCount", value);
            }
        }

        public System.UInt32? PagesInUse
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PagesInUse", out result);
                return result;
            }

            set
            {
                this.SetProperty("PagesInUse", value);
            }
        }

        public System.UInt32? PagesTotal
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PagesTotal", out result);
                return result;
            }

            set
            {
                this.SetProperty("PagesTotal", value);
            }
        }
    }
}
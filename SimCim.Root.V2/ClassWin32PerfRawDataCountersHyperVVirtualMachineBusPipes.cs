using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataCountersHyperVVirtualMachineBusPipes : Win32PerfRawData
    {
        public Win32PerfRawDataCountersHyperVVirtualMachineBusPipes()
        {
        }

        public Win32PerfRawDataCountersHyperVVirtualMachineBusPipes(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? BytesReadPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("BytesReadPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("BytesReadPersec", value);
            }
        }

        public System.UInt64? BytesWrittenPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("BytesWrittenPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("BytesWrittenPersec", value);
            }
        }

        public System.UInt64? ReadsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ReadsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReadsPersec", value);
            }
        }

        public System.UInt64? WritesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("WritesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("WritesPersec", value);
            }
        }
    }
}
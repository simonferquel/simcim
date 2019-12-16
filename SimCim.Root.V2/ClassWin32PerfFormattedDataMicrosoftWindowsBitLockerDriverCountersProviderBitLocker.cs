using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfFormattedDataMicrosoftWindowsBitLockerDriverCountersProviderBitLocker : Win32PerfFormattedData
    {
        public Win32PerfFormattedDataMicrosoftWindowsBitLockerDriverCountersProviderBitLocker()
        {
        }

        public Win32PerfFormattedDataMicrosoftWindowsBitLockerDriverCountersProviderBitLocker(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? MaxReadSplitSize
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaxReadSplitSize", out result);
                return result;
            }

            set
            {
                this.SetProperty("MaxReadSplitSize", value);
            }
        }

        public System.UInt32? MaxWriteSplitSize
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaxWriteSplitSize", out result);
                return result;
            }

            set
            {
                this.SetProperty("MaxWriteSplitSize", value);
            }
        }

        public System.UInt32? MinReadSplitSize
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MinReadSplitSize", out result);
                return result;
            }

            set
            {
                this.SetProperty("MinReadSplitSize", value);
            }
        }

        public System.UInt32? MinWriteSplitSize
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MinWriteSplitSize", out result);
                return result;
            }

            set
            {
                this.SetProperty("MinWriteSplitSize", value);
            }
        }

        public System.UInt64? ReadRequestsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ReadRequestsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReadRequestsPersec", value);
            }
        }

        public System.UInt64? ReadSubrequestsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ReadSubrequestsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReadSubrequestsPersec", value);
            }
        }

        public System.UInt64? WriteRequestsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("WriteRequestsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("WriteRequestsPersec", value);
            }
        }

        public System.UInt64? WriteSubrequestsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("WriteSubrequestsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("WriteSubrequestsPersec", value);
            }
        }
    }
}
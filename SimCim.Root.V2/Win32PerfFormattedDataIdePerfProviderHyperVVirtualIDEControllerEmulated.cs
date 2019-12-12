using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfFormattedDataIdePerfProviderHyperVVirtualIDEControllerEmulated : Win32PerfFormattedData
    {
        public Win32PerfFormattedDataIdePerfProviderHyperVVirtualIDEControllerEmulated()
        {
        }

        public Win32PerfFormattedDataIdePerfProviderHyperVVirtualIDEControllerEmulated(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? ReadBytesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ReadBytesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReadBytesPersec", value);
            }
        }

        public System.UInt64? ReadSectorsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ReadSectorsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReadSectorsPersec", value);
            }
        }

        public System.UInt64? WriteBytesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("WriteBytesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("WriteBytesPersec", value);
            }
        }

        public System.UInt64? WrittenSectorsPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("WrittenSectorsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("WrittenSectorsPersec", value);
            }
        }
    }
}
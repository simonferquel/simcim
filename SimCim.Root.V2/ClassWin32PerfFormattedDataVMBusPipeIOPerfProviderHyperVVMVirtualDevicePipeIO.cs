using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfFormattedDataVMBusPipeIOPerfProviderHyperVVMVirtualDevicePipeIO : Win32PerfFormattedData
    {
        public Win32PerfFormattedDataVMBusPipeIOPerfProviderHyperVVMVirtualDevicePipeIO()
        {
        }

        public Win32PerfFormattedDataVMBusPipeIOPerfProviderHyperVVMVirtualDevicePipeIO(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? ReceiveMessageQuotaExceeded
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ReceiveMessageQuotaExceeded", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReceiveMessageQuotaExceeded", value);
            }
        }

        public System.UInt64? ReceiveQoSConformantMessagesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ReceiveQoSConformantMessagesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReceiveQoSConformantMessagesPersec", value);
            }
        }

        public System.UInt64? ReceiveQoSExemptMessagesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ReceiveQoSExemptMessagesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReceiveQoSExemptMessagesPersec", value);
            }
        }

        public System.UInt64? ReceiveQoSNonConformantMessagesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ReceiveQoSNonConformantMessagesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReceiveQoSNonConformantMessagesPersec", value);
            }
        }

        public System.UInt64? ReceiveQoSTotalMessageDelayTime100ns
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ReceiveQoSTotalMessageDelayTime100ns", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReceiveQoSTotalMessageDelayTime100ns", value);
            }
        }
    }
}
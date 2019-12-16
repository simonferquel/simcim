using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfRawDataCountersXHCITransferRing : Win32PerfRawData
    {
        public Win32PerfRawDataCountersXHCITransferRing()
        {
        }

        public Win32PerfRawDataCountersXHCITransferRing(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? BytesPerSec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("BytesPerSec", out result);
                return result;
            }

            set
            {
                this.SetProperty("BytesPerSec", value);
            }
        }

        public System.UInt32? FailedTransferCount
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("FailedTransferCount", out result);
                return result;
            }

            set
            {
                this.SetProperty("FailedTransferCount", value);
            }
        }

        public System.UInt32? IsochTDFailuresPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("IsochTDFailuresPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("IsochTDFailuresPersec", value);
            }
        }

        public System.UInt32? IsochTDPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("IsochTDPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("IsochTDPersec", value);
            }
        }

        public System.UInt32? MissedServiceErrorCount
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MissedServiceErrorCount", out result);
                return result;
            }

            set
            {
                this.SetProperty("MissedServiceErrorCount", value);
            }
        }

        public System.UInt32? TransfersPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TransfersPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("TransfersPersec", value);
            }
        }

        public System.UInt32? UnderrunOverruncount
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("UnderrunOverruncount", out result);
                return result;
            }

            set
            {
                this.SetProperty("UnderrunOverruncount", value);
            }
        }
    }
}
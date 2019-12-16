using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfFormattedDataVSmbPerfProviderHyperVVirtualSMB : Win32PerfFormattedData
    {
        public Win32PerfFormattedDataVSmbPerfProviderHyperVVirtualSMB()
        {
        }

        public Win32PerfFormattedDataVSmbPerfProviderHyperVVirtualSMB(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? AvgsecPerRequest
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("AvgsecPerRequest", out result);
                return result;
            }

            set
            {
                this.SetProperty("AvgsecPerRequest", value);
            }
        }

        public System.UInt32? CurrentOpenFileCount
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CurrentOpenFileCount", out result);
                return result;
            }

            set
            {
                this.SetProperty("CurrentOpenFileCount", value);
            }
        }

        public System.UInt32? CurrentPendingRequests
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CurrentPendingRequests", out result);
                return result;
            }

            set
            {
                this.SetProperty("CurrentPendingRequests", value);
            }
        }

        public System.UInt64? DirectMappedPages
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("DirectMappedPages", out result);
                return result;
            }

            set
            {
                this.SetProperty("DirectMappedPages", value);
            }
        }

        public System.UInt32? DirectMappedSections
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("DirectMappedSections", out result);
                return result;
            }

            set
            {
                this.SetProperty("DirectMappedSections", value);
            }
        }

        public System.UInt32? FlushRequestsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("FlushRequestsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("FlushRequestsPersec", value);
            }
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

        public System.UInt64? ReadBytesPersecRDMA
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ReadBytesPersecRDMA", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReadBytesPersecRDMA", value);
            }
        }

        public System.UInt32? ReadRequestsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ReadRequestsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReadRequestsPersec", value);
            }
        }

        public System.UInt32? ReadRequestsPersecRDMA
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ReadRequestsPersecRDMA", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReadRequestsPersecRDMA", value);
            }
        }

        public System.UInt64? ReceivedBytesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ReceivedBytesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReceivedBytesPersec", value);
            }
        }

        public System.UInt32? RequestsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("RequestsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("RequestsPersec", value);
            }
        }

        public System.UInt64? SentBytesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("SentBytesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("SentBytesPersec", value);
            }
        }

        public System.UInt32? TreeConnectCount
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TreeConnectCount", out result);
                return result;
            }

            set
            {
                this.SetProperty("TreeConnectCount", value);
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

        public System.UInt64? WriteBytesPersecRDMA
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("WriteBytesPersecRDMA", out result);
                return result;
            }

            set
            {
                this.SetProperty("WriteBytesPersecRDMA", value);
            }
        }

        public System.UInt32? WriteRequestsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("WriteRequestsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("WriteRequestsPersec", value);
            }
        }

        public System.UInt32? WriteRequestsPersecRDMA
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("WriteRequestsPersecRDMA", out result);
                return result;
            }

            set
            {
                this.SetProperty("WriteRequestsPersecRDMA", value);
            }
        }
    }
}
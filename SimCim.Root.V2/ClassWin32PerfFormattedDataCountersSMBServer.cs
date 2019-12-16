using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfFormattedDataCountersSMBServer : Win32PerfFormattedData
    {
        public Win32PerfFormattedDataCountersSMBServer()
        {
        }

        public Win32PerfFormattedDataCountersSMBServer(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
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

        public System.UInt64? ReceiveBytesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ReceiveBytesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReceiveBytesPersec", value);
            }
        }

        public System.UInt64? SendBytesPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("SendBytesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("SendBytesPersec", value);
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
    }
}
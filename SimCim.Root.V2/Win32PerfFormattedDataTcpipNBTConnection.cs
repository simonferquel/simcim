using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfFormattedDataTcpipNBTConnection : Win32PerfFormattedData
    {
        public Win32PerfFormattedDataTcpipNBTConnection()
        {
        }

        public Win32PerfFormattedDataTcpipNBTConnection(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? BytesReceivedPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("BytesReceivedPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("BytesReceivedPersec", value);
            }
        }

        public System.UInt64? BytesSentPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("BytesSentPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("BytesSentPersec", value);
            }
        }

        public System.UInt64? BytesTotalPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("BytesTotalPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("BytesTotalPersec", value);
            }
        }
    }
}
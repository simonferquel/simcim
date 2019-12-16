using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfFormattedDataDdmCounterProviderRAS : Win32PerfFormattedData
    {
        public Win32PerfFormattedDataDdmCounterProviderRAS()
        {
        }

        public Win32PerfFormattedDataDdmCounterProviderRAS(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? BytesReceivedByDisconnectedClients
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("BytesReceivedByDisconnectedClients", out result);
                return result;
            }

            set
            {
                this.SetProperty("BytesReceivedByDisconnectedClients", value);
            }
        }

        public System.UInt64? BytesTransmittedByDisconnectedClients
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("BytesTransmittedByDisconnectedClients", out result);
                return result;
            }

            set
            {
                this.SetProperty("BytesTransmittedByDisconnectedClients", value);
            }
        }

        public System.UInt32? FailedAuthentications
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("FailedAuthentications", out result);
                return result;
            }

            set
            {
                this.SetProperty("FailedAuthentications", value);
            }
        }

        public System.UInt32? MaxClients
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaxClients", out result);
                return result;
            }

            set
            {
                this.SetProperty("MaxClients", value);
            }
        }

        public System.UInt32? TotalClients
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("TotalClients", out result);
                return result;
            }

            set
            {
                this.SetProperty("TotalClients", value);
            }
        }
    }
}
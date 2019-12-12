using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfFormattedDataCountersSMBDirectConnection : Win32PerfFormattedData
    {
        public Win32PerfFormattedDataCountersSMBDirectConnection()
        {
        }

        public Win32PerfFormattedDataCountersSMBDirectConnection(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? BytesRDMAReadPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("BytesRDMAReadPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("BytesRDMAReadPersec", value);
            }
        }

        public System.UInt64? BytesRDMAWrittenPersec
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("BytesRDMAWrittenPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("BytesRDMAWrittenPersec", value);
            }
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

        public System.UInt32? MemoryRegions
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MemoryRegions", out result);
                return result;
            }

            set
            {
                this.SetProperty("MemoryRegions", value);
            }
        }

        public System.UInt32? RCQNotificationEventsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("RCQNotificationEventsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("RCQNotificationEventsPersec", value);
            }
        }

        public System.UInt32? RDMARegistrationsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("RDMARegistrationsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("RDMARegistrationsPersec", value);
            }
        }

        public System.UInt32? ReceivesPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ReceivesPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReceivesPersec", value);
            }
        }

        public System.UInt32? RemoteInvalidationsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("RemoteInvalidationsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("RemoteInvalidationsPersec", value);
            }
        }

        public System.UInt32? SCQNotificationEventsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SCQNotificationEventsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("SCQNotificationEventsPersec", value);
            }
        }

        public System.UInt32? SendsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SendsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("SendsPersec", value);
            }
        }

        public System.UInt64? SpuriousRCQNotificationEvents
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("SpuriousRCQNotificationEvents", out result);
                return result;
            }

            set
            {
                this.SetProperty("SpuriousRCQNotificationEvents", value);
            }
        }

        public System.UInt64? SpuriousSCQNotificationEvents
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("SpuriousSCQNotificationEvents", out result);
                return result;
            }

            set
            {
                this.SetProperty("SpuriousSCQNotificationEvents", value);
            }
        }

        public System.UInt32? StallsRDMAReadPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("StallsRDMAReadPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("StallsRDMAReadPersec", value);
            }
        }

        public System.UInt32? StallsRDMARegistrationsPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("StallsRDMARegistrationsPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("StallsRDMARegistrationsPersec", value);
            }
        }

        public System.UInt32? StallsSendCreditPersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("StallsSendCreditPersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("StallsSendCreditPersec", value);
            }
        }

        public System.UInt32? StallsSendQueuePersec
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("StallsSendQueuePersec", out result);
                return result;
            }

            set
            {
                this.SetProperty("StallsSendQueuePersec", value);
            }
        }
    }
}
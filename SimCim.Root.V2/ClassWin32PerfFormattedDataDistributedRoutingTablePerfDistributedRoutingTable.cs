using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PerfFormattedDataDistributedRoutingTablePerfDistributedRoutingTable : Win32PerfFormattedData
    {
        public Win32PerfFormattedDataDistributedRoutingTablePerfDistributedRoutingTable()
        {
        }

        public Win32PerfFormattedDataDistributedRoutingTablePerfDistributedRoutingTable(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? AckMessagesReceivedPersecond
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("AckMessagesReceivedPersecond", out result);
                return result;
            }

            set
            {
                this.SetProperty("AckMessagesReceivedPersecond", value);
            }
        }

        public System.UInt32? AckMessagesSentPersecond
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("AckMessagesSentPersecond", out result);
                return result;
            }

            set
            {
                this.SetProperty("AckMessagesSentPersecond", value);
            }
        }

        public System.UInt32? AdvertiseMessagesReceivedPersecond
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("AdvertiseMessagesReceivedPersecond", out result);
                return result;
            }

            set
            {
                this.SetProperty("AdvertiseMessagesReceivedPersecond", value);
            }
        }

        public System.UInt32? AdvertiseMessagesSentPersecond
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("AdvertiseMessagesSentPersecond", out result);
                return result;
            }

            set
            {
                this.SetProperty("AdvertiseMessagesSentPersecond", value);
            }
        }

        public System.UInt32? AuthorityMessagesReceivedPersecond
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("AuthorityMessagesReceivedPersecond", out result);
                return result;
            }

            set
            {
                this.SetProperty("AuthorityMessagesReceivedPersecond", value);
            }
        }

        public System.UInt32? AuthoritySentPersecond
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("AuthoritySentPersecond", out result);
                return result;
            }

            set
            {
                this.SetProperty("AuthoritySentPersecond", value);
            }
        }

        public System.UInt32? AverageBytesPersecondReceived
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("AverageBytesPersecondReceived", out result);
                return result;
            }

            set
            {
                this.SetProperty("AverageBytesPersecondReceived", value);
            }
        }

        public System.UInt32? AverageBytesPersecondSent
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("AverageBytesPersecondSent", out result);
                return result;
            }

            set
            {
                this.SetProperty("AverageBytesPersecondSent", value);
            }
        }

        public System.UInt32? CacheEntries
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("CacheEntries", out result);
                return result;
            }

            set
            {
                this.SetProperty("CacheEntries", value);
            }
        }

        public System.UInt32? Estimatedcloudsize
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Estimatedcloudsize", out result);
                return result;
            }

            set
            {
                this.SetProperty("Estimatedcloudsize", value);
            }
        }

        public System.UInt32? FloodMessagesReceivedPersecond
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("FloodMessagesReceivedPersecond", out result);
                return result;
            }

            set
            {
                this.SetProperty("FloodMessagesReceivedPersecond", value);
            }
        }

        public System.UInt32? FloodMessagesSentPersecond
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("FloodMessagesSentPersecond", out result);
                return result;
            }

            set
            {
                this.SetProperty("FloodMessagesSentPersecond", value);
            }
        }

        public System.UInt32? InquireMessagesReceivedPersecond
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("InquireMessagesReceivedPersecond", out result);
                return result;
            }

            set
            {
                this.SetProperty("InquireMessagesReceivedPersecond", value);
            }
        }

        public System.UInt32? InquireMessagesSentPersecond
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("InquireMessagesSentPersecond", out result);
                return result;
            }

            set
            {
                this.SetProperty("InquireMessagesSentPersecond", value);
            }
        }

        public System.UInt32? LookupMessagesReceivedPersecond
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("LookupMessagesReceivedPersecond", out result);
                return result;
            }

            set
            {
                this.SetProperty("LookupMessagesReceivedPersecond", value);
            }
        }

        public System.UInt32? LookupMessagesSentPersecond
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("LookupMessagesSentPersecond", out result);
                return result;
            }

            set
            {
                this.SetProperty("LookupMessagesSentPersecond", value);
            }
        }

        public System.UInt32? ReceiveFailures
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ReceiveFailures", out result);
                return result;
            }

            set
            {
                this.SetProperty("ReceiveFailures", value);
            }
        }

        public System.UInt32? Registrations
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Registrations", out result);
                return result;
            }

            set
            {
                this.SetProperty("Registrations", value);
            }
        }

        public System.UInt32? RequestMessagesReceivedPersecond
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("RequestMessagesReceivedPersecond", out result);
                return result;
            }

            set
            {
                this.SetProperty("RequestMessagesReceivedPersecond", value);
            }
        }

        public System.UInt32? RequestMessagesSentPersecond
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("RequestMessagesSentPersecond", out result);
                return result;
            }

            set
            {
                this.SetProperty("RequestMessagesSentPersecond", value);
            }
        }

        public System.UInt32? Searches
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Searches", out result);
                return result;
            }

            set
            {
                this.SetProperty("Searches", value);
            }
        }

        public System.UInt32? SendFailures
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SendFailures", out result);
                return result;
            }

            set
            {
                this.SetProperty("SendFailures", value);
            }
        }

        public System.UInt32? SolicitMessagesReceivedPersecond
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SolicitMessagesReceivedPersecond", out result);
                return result;
            }

            set
            {
                this.SetProperty("SolicitMessagesReceivedPersecond", value);
            }
        }

        public System.UInt32? SolicitMessagesSentPersecond
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SolicitMessagesSentPersecond", out result);
                return result;
            }

            set
            {
                this.SetProperty("SolicitMessagesSentPersecond", value);
            }
        }

        public System.UInt32? StaleCacheEntries
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("StaleCacheEntries", out result);
                return result;
            }

            set
            {
                this.SetProperty("StaleCacheEntries", value);
            }
        }

        public System.UInt32? UnrecognizedMessagesReceived
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("UnrecognizedMessagesReceived", out result);
                return result;
            }

            set
            {
                this.SetProperty("UnrecognizedMessagesReceived", value);
            }
        }
    }
}
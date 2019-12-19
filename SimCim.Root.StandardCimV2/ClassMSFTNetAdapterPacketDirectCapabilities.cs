using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTNetAdapterPacketDirectCapabilities : GenericInfrastructureObject
    {
        public MSFTNetAdapterPacketDirectCapabilities()
        {
        }

        public MSFTNetAdapterPacketDirectCapabilities(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Boolean? DrainNotificationSupported
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("DrainNotificationSupported", out result);
                return result;
            }
        }

        public System.UInt32? MaximumModerationInterval
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaximumModerationInterval", out result);
                return result;
            }
        }

        public System.UInt32? MaximumNumberOfRxQueues
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaximumNumberOfRxQueues", out result);
                return result;
            }
        }

        public System.UInt32? MaximumNumberOfRxQueuesForDefaultVPort
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaximumNumberOfRxQueuesForDefaultVPort", out result);
                return result;
            }
        }

        public System.UInt32? MaximumNumberOfRxQueuesPerNonDefaultVPort
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaximumNumberOfRxQueuesPerNonDefaultVPort", out result);
                return result;
            }
        }

        public System.UInt32? MaximumNumberOfTxQueues
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaximumNumberOfTxQueues", out result);
                return result;
            }
        }

        public System.UInt32? MaximumNumberOfTxQueuesForDefaultVPort
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaximumNumberOfTxQueuesForDefaultVPort", out result);
                return result;
            }
        }

        public System.UInt32? MaximumNumberOfTxQueuesPerNonDefaultVPort
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaximumNumberOfTxQueuesPerNonDefaultVPort", out result);
                return result;
            }
        }

        public System.UInt32? MaximumRxPartialBufferCount
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaximumRxPartialBufferCount", out result);
                return result;
            }
        }

        public System.UInt32? MaximumRxQueueSize
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaximumRxQueueSize", out result);
                return result;
            }
        }

        public System.UInt32? MaximumTxPartialBufferCount
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaximumTxPartialBufferCount", out result);
                return result;
            }
        }

        public System.UInt32? MaximumTxQueueSize
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MaximumTxQueueSize", out result);
                return result;
            }
        }

        public System.UInt32? MinimumModerationInterval
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MinimumModerationInterval", out result);
                return result;
            }
        }

        public System.Boolean? ModerationByCountSupported
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("ModerationByCountSupported", out result);
                return result;
            }
        }

        public System.Boolean? ModerationByIntervalSupported
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("ModerationByIntervalSupported", out result);
                return result;
            }
        }

        public System.UInt32? ModerationIntervalGranularity
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ModerationIntervalGranularity", out result);
                return result;
            }
        }
    }
}
using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTNetAdapterVmqQueueSettingData : MSFTNetAdapterSettingData
    {
        public MSFTNetAdapterVmqQueueSettingData()
        {
        }

        public MSFTNetAdapterVmqQueueSettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public IEnumerable<MSFTNetAdapterVmqFilter> FilterList
        {
            get
            {
                IEnumerable<MSFTNetAdapterVmqFilter> result;
                this.GetInfrastructureObjectProperty("FilterList", out result);
                return result;
            }
        }

        public System.UInt32? NumFilters
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NumFilters", out result);
                return result;
            }
        }

        public System.UInt64? ProcessorAffinityMask
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ProcessorAffinityMask", out result);
                return result;
            }
        }

        public System.UInt16? ProcessorGroup
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("ProcessorGroup", out result);
                return result;
            }
        }

        public System.UInt32? QueueID
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("QueueID", out result);
                return result;
            }
        }

        public System.String QueueName
        {
            get
            {
                System.String result;
                this.GetProperty("QueueName", out result);
                return result;
            }
        }

        public System.UInt32? State
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("State", out result);
                return result;
            }
        }

        public System.String VmFriendlyName
        {
            get
            {
                System.String result;
                this.GetProperty("VmFriendlyName", out result);
                return result;
            }
        }

        public System.String VmID
        {
            get
            {
                System.String result;
                this.GetProperty("VmID", out result);
                return result;
            }
        }
    }
}
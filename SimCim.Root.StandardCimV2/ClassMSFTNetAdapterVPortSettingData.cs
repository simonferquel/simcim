using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTNetAdapterVPortSettingData : MSFTNetAdapterSettingData
    {
        public MSFTNetAdapterVPortSettingData()
        {
        }

        public MSFTNetAdapterVPortSettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
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

        public System.UInt16? FunctionID
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("FunctionID", out result);
                return result;
            }
        }

        public System.UInt32? InterruptModeration
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("InterruptModeration", out result);
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

        public System.UInt32? NumQueuePairs
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("NumQueuePairs", out result);
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

        public System.UInt32? SwitchID
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("SwitchID", out result);
                return result;
            }
        }

        public System.UInt32? VPortID
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("VPortID", out result);
                return result;
            }
        }

        public System.String VPortName
        {
            get
            {
                System.String result;
                this.GetProperty("VPortName", out result);
                return result;
            }
        }

        public System.UInt32? VPortState
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("VPortState", out result);
                return result;
            }
        }
    }
}
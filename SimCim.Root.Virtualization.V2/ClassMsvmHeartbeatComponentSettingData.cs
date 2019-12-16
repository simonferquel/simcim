using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmHeartbeatComponentSettingData : CIMResourceAllocationSettingData
    {
        public MsvmHeartbeatComponentSettingData()
        {
        }

        public MsvmHeartbeatComponentSettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16? EnabledState
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("EnabledState", out result);
                return result;
            }
        }

        public System.UInt32? ErrorThreshold
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("ErrorThreshold", out result);
                return result;
            }
        }

        public System.UInt32? Interval
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Interval", out result);
                return result;
            }
        }

        public System.UInt32? Latency
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Latency", out result);
                return result;
            }
        }
    }
}
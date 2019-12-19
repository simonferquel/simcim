using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTNetAdapterRscStatistics : GenericInfrastructureObject
    {
        public MSFTNetAdapterRscStatistics()
        {
        }

        public MSFTNetAdapterRscStatistics(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? CoalescedBytes
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("CoalescedBytes", out result);
                return result;
            }
        }

        public System.UInt64? CoalescedPackets
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("CoalescedPackets", out result);
                return result;
            }
        }

        public System.UInt64? CoalescingEvents
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("CoalescingEvents", out result);
                return result;
            }
        }

        public System.UInt64? CoalescingExceptions
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("CoalescingExceptions", out result);
                return result;
            }
        }
    }
}
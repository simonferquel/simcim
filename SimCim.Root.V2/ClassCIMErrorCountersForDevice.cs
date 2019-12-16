using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMErrorCountersForDevice : CIMStatistics
    {
        protected CIMErrorCountersForDevice()
        {
        }

        protected CIMErrorCountersForDevice(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMLogicalDevice Element
        {
            get
            {
                CIMLogicalDevice result;
                this.GetInfrastructureObjectProperty("Element", out result);
                return result;
            }
        }

        public new CIMDeviceErrorCounts Stats
        {
            get
            {
                CIMDeviceErrorCounts result;
                this.GetInfrastructureObjectProperty("Stats", out result);
                return result;
            }
        }
    }
}
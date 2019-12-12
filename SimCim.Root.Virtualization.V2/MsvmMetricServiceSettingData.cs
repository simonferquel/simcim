using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmMetricServiceSettingData : CIMSettingData
    {
        public MsvmMetricServiceSettingData()
        {
        }

        public MsvmMetricServiceSettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.DateTime? MetricsFlushInterval
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("MetricsFlushInterval", out result);
                return result;
            }
        }
    }
}
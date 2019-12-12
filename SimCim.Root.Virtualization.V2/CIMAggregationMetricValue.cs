using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMAggregationMetricValue : CIMBaseMetricValue
    {
        protected CIMAggregationMetricValue()
        {
        }

        protected CIMAggregationMetricValue(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.DateTime? AggregationDuration
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("AggregationDuration", out result);
                return result;
            }

            set
            {
                this.SetProperty("AggregationDuration", value);
            }
        }

        public System.DateTime? AggregationTimeStamp
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("AggregationTimeStamp", out result);
                return result;
            }

            set
            {
                this.SetProperty("AggregationTimeStamp", value);
            }
        }
    }
}
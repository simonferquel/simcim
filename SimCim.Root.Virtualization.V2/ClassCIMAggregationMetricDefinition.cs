using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMAggregationMetricDefinition : CIMBaseMetricDefinition
    {
        protected CIMAggregationMetricDefinition()
        {
        }

        protected CIMAggregationMetricDefinition(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16? SimpleFunction
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("SimpleFunction", out result);
                return result;
            }

            set
            {
                this.SetProperty("SimpleFunction", value);
            }
        }
    }
}
using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMMetricDefForME : CIMDependency
    {
        protected CIMMetricDefForME()
        {
        }

        protected CIMMetricDefForME(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMBaseMetricDefinition Dependent
        {
            get
            {
                CIMBaseMetricDefinition result;
                this.GetInfrastructureObjectProperty("Dependent", out result);
                return result;
            }

            set
            {
                this.SetProperty("Dependent", value);
            }
        }

        public System.UInt16? MetricCollectionEnabled
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("MetricCollectionEnabled", out result);
                return result;
            }

            set
            {
                this.SetProperty("MetricCollectionEnabled", value);
            }
        }
    }
}
using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMMetricInstance : CIMDependency
    {
        protected CIMMetricInstance()
        {
        }

        protected CIMMetricInstance(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMBaseMetricDefinition Antecedent
        {
            get
            {
                CIMBaseMetricDefinition result;
                this.GetInfrastructureObjectProperty("Antecedent", out result);
                return result;
            }

            set
            {
                this.SetProperty("Antecedent", value);
            }
        }

        public new CIMBaseMetricValue Dependent
        {
            get
            {
                CIMBaseMetricValue result;
                this.GetInfrastructureObjectProperty("Dependent", out result);
                return result;
            }

            set
            {
                this.SetProperty("Dependent", value);
            }
        }
    }
}
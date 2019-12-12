using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMHostedJobDestination : CIMDependency
    {
        protected CIMHostedJobDestination()
        {
        }

        protected CIMHostedJobDestination(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMSystem Antecedent
        {
            get
            {
                CIMSystem result;
                this.GetInfrastructureObjectProperty("Antecedent", out result);
                return result;
            }
        }

        public new CIMJobDestination Dependent
        {
            get
            {
                CIMJobDestination result;
                this.GetInfrastructureObjectProperty("Dependent", out result);
                return result;
            }
        }
    }
}
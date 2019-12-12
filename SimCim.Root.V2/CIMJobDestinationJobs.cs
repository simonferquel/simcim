using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMJobDestinationJobs : CIMDependency
    {
        protected CIMJobDestinationJobs()
        {
        }

        protected CIMJobDestinationJobs(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMJobDestination Antecedent
        {
            get
            {
                CIMJobDestination result;
                this.GetInfrastructureObjectProperty("Antecedent", out result);
                return result;
            }
        }

        public new CIMJob Dependent
        {
            get
            {
                CIMJob result;
                this.GetInfrastructureObjectProperty("Dependent", out result);
                return result;
            }
        }
    }
}
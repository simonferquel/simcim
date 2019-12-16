using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMRealizesAggregatePExtent : CIMRealizes
    {
        protected CIMRealizesAggregatePExtent()
        {
        }

        protected CIMRealizesAggregatePExtent(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMPhysicalMedia Antecedent
        {
            get
            {
                CIMPhysicalMedia result;
                this.GetInfrastructureObjectProperty("Antecedent", out result);
                return result;
            }
        }

        public new CIMAggregatePExtent Dependent
        {
            get
            {
                CIMAggregatePExtent result;
                this.GetInfrastructureObjectProperty("Dependent", out result);
                return result;
            }
        }
    }
}
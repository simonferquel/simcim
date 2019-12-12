using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmServiceOfVssComponent : CIMDependency
    {
        public MsvmServiceOfVssComponent()
        {
        }

        public MsvmServiceOfVssComponent(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new MsvmVssComponent Antecedent
        {
            get
            {
                MsvmVssComponent result;
                this.GetInfrastructureObjectProperty("Antecedent", out result);
                return result;
            }
        }

        public new MsvmVssService Dependent
        {
            get
            {
                MsvmVssService result;
                this.GetInfrastructureObjectProperty("Dependent", out result);
                return result;
            }
        }
    }
}
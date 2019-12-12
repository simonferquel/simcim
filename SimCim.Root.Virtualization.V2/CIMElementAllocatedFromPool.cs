using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMElementAllocatedFromPool : CIMDependency
    {
        protected CIMElementAllocatedFromPool()
        {
        }

        protected CIMElementAllocatedFromPool(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMResourcePool Antecedent
        {
            get
            {
                CIMResourcePool result;
                this.GetInfrastructureObjectProperty("Antecedent", out result);
                return result;
            }

            set
            {
                this.SetProperty("Antecedent", value);
            }
        }

        public new CIMLogicalElement Dependent
        {
            get
            {
                CIMLogicalElement result;
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
using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMAssociatedMemory : CIMDependency
    {
        protected CIMAssociatedMemory()
        {
        }

        protected CIMAssociatedMemory(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMMemory Antecedent
        {
            get
            {
                CIMMemory result;
                this.GetInfrastructureObjectProperty("Antecedent", out result);
                return result;
            }
        }

        public new CIMLogicalDevice Dependent
        {
            get
            {
                CIMLogicalDevice result;
                this.GetInfrastructureObjectProperty("Dependent", out result);
                return result;
            }
        }
    }
}
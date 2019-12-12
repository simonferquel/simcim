using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmElementAllocatedFromNumaNode : CIMDependency
    {
        public MsvmElementAllocatedFromNumaNode()
        {
        }

        public MsvmElementAllocatedFromNumaNode(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new MsvmNumaNode Antecedent
        {
            get
            {
                MsvmNumaNode result;
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
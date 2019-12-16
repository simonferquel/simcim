using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmReferencePointOfVirtualSystem : CIMDependency
    {
        public MsvmReferencePointOfVirtualSystem()
        {
        }

        public MsvmReferencePointOfVirtualSystem(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new MsvmComputerSystem Antecedent
        {
            get
            {
                MsvmComputerSystem result;
                this.GetInfrastructureObjectProperty("Antecedent", out result);
                return result;
            }

            set
            {
                this.SetProperty("Antecedent", value);
            }
        }

        public new MsvmVirtualSystemReferencePoint Dependent
        {
            get
            {
                MsvmVirtualSystemReferencePoint result;
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
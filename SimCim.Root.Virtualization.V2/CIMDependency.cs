using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMDependency : GenericInfrastructureObject
    {
        protected CIMDependency()
        {
        }

        protected CIMDependency(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public CIMManagedElement Antecedent
        {
            get
            {
                CIMManagedElement result;
                this.GetInfrastructureObjectProperty("Antecedent", out result);
                return result;
            }

            set
            {
                this.SetProperty("Antecedent", value);
            }
        }

        public CIMManagedElement Dependent
        {
            get
            {
                CIMManagedElement result;
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
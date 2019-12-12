using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMDependency : GenericInfrastructureObject
    {
        protected CIMDependency()
        {
        }

        protected CIMDependency(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public CIMManagedSystemElement Antecedent
        {
            get
            {
                CIMManagedSystemElement result;
                this.GetInfrastructureObjectProperty("Antecedent", out result);
                return result;
            }
        }

        public CIMManagedSystemElement Dependent
        {
            get
            {
                CIMManagedSystemElement result;
                this.GetInfrastructureObjectProperty("Dependent", out result);
                return result;
            }
        }
    }
}
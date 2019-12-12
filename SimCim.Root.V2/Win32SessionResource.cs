using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class Win32SessionResource : CIMDependency
    {
        protected Win32SessionResource()
        {
        }

        protected Win32SessionResource(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CimInstance Antecedent
        {
            get
            {
                CimInstance result;
                this.GetProperty("Antecedent", out result);
                return result;
            }
        }

        public new Win32Session Dependent
        {
            get
            {
                Win32Session result;
                this.GetInfrastructureObjectProperty("Dependent", out result);
                return result;
            }
        }
    }
}
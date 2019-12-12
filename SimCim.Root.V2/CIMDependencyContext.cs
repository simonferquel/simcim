using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMDependencyContext : GenericInfrastructureObject
    {
        protected CIMDependencyContext()
        {
        }

        protected CIMDependencyContext(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public CIMConfiguration Context
        {
            get
            {
                CIMConfiguration result;
                this.GetInfrastructureObjectProperty("Context", out result);
                return result;
            }
        }

        public CIMDependency Dependency
        {
            get
            {
                CIMDependency result;
                this.GetInfrastructureObjectProperty("Dependency", out result);
                return result;
            }
        }
    }
}
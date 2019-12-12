using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMProductProductDependency : GenericInfrastructureObject
    {
        protected CIMProductProductDependency()
        {
        }

        protected CIMProductProductDependency(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public CIMProduct DependentProduct
        {
            get
            {
                CIMProduct result;
                this.GetInfrastructureObjectProperty("DependentProduct", out result);
                return result;
            }
        }

        public CIMProduct RequiredProduct
        {
            get
            {
                CIMProduct result;
                this.GetInfrastructureObjectProperty("RequiredProduct", out result);
                return result;
            }
        }

        public System.UInt16? TypeOfDependency
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("TypeOfDependency", out result);
                return result;
            }
        }
    }
}
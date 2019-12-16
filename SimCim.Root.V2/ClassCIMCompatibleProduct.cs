using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMCompatibleProduct : GenericInfrastructureObject
    {
        protected CIMCompatibleProduct()
        {
        }

        protected CIMCompatibleProduct(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String CompatibilityDescription
        {
            get
            {
                System.String result;
                this.GetProperty("CompatibilityDescription", out result);
                return result;
            }
        }

        public CIMProduct CompatibleProduct
        {
            get
            {
                CIMProduct result;
                this.GetInfrastructureObjectProperty("CompatibleProduct", out result);
                return result;
            }
        }

        public CIMProduct Product
        {
            get
            {
                CIMProduct result;
                this.GetInfrastructureObjectProperty("Product", out result);
                return result;
            }
        }
    }
}
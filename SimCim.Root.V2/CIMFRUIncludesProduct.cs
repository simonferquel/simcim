using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMFRUIncludesProduct : GenericInfrastructureObject
    {
        protected CIMFRUIncludesProduct()
        {
        }

        protected CIMFRUIncludesProduct(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public CIMProduct Component
        {
            get
            {
                CIMProduct result;
                this.GetInfrastructureObjectProperty("Component", out result);
                return result;
            }
        }

        public CIMFRU FRU
        {
            get
            {
                CIMFRU result;
                this.GetInfrastructureObjectProperty("FRU", out result);
                return result;
            }
        }
    }
}
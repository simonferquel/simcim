using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMProductFRU : GenericInfrastructureObject
    {
        protected CIMProductFRU()
        {
        }

        protected CIMProductFRU(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
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
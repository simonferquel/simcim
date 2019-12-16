using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMProductSupport : GenericInfrastructureObject
    {
        protected CIMProductSupport()
        {
        }

        protected CIMProductSupport(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
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

        public CIMSupportAccess Support
        {
            get
            {
                CIMSupportAccess result;
                this.GetInfrastructureObjectProperty("Support", out result);
                return result;
            }
        }
    }
}
using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMCardInSlot : CIMPackageInSlot
    {
        protected CIMCardInSlot()
        {
        }

        protected CIMCardInSlot(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMCard Dependent
        {
            get
            {
                CIMCard result;
                this.GetInfrastructureObjectProperty("Dependent", out result);
                return result;
            }
        }
    }
}
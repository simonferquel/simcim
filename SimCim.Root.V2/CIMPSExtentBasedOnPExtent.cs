using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMPSExtentBasedOnPExtent : CIMBasedOn
    {
        protected CIMPSExtentBasedOnPExtent()
        {
        }

        protected CIMPSExtentBasedOnPExtent(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMPhysicalExtent Antecedent
        {
            get
            {
                CIMPhysicalExtent result;
                this.GetInfrastructureObjectProperty("Antecedent", out result);
                return result;
            }
        }

        public new CIMProtectedSpaceExtent Dependent
        {
            get
            {
                CIMProtectedSpaceExtent result;
                this.GetInfrastructureObjectProperty("Dependent", out result);
                return result;
            }
        }
    }
}
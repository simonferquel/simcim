using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMElementsLinked : CIMDependency
    {
        protected CIMElementsLinked()
        {
        }

        protected CIMElementsLinked(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMPhysicalLink Antecedent
        {
            get
            {
                CIMPhysicalLink result;
                this.GetInfrastructureObjectProperty("Antecedent", out result);
                return result;
            }
        }

        public new CIMPhysicalElement Dependent
        {
            get
            {
                CIMPhysicalElement result;
                this.GetInfrastructureObjectProperty("Dependent", out result);
                return result;
            }
        }
    }
}
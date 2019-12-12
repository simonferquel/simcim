using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMServiceAccessBySAP : CIMDependency
    {
        protected CIMServiceAccessBySAP()
        {
        }

        protected CIMServiceAccessBySAP(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMService Antecedent
        {
            get
            {
                CIMService result;
                this.GetInfrastructureObjectProperty("Antecedent", out result);
                return result;
            }
        }

        public new CIMServiceAccessPoint Dependent
        {
            get
            {
                CIMServiceAccessPoint result;
                this.GetInfrastructureObjectProperty("Dependent", out result);
                return result;
            }
        }
    }
}
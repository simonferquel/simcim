using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMBootServiceAccessBySAP : CIMServiceAccessBySAP
    {
        protected CIMBootServiceAccessBySAP()
        {
        }

        protected CIMBootServiceAccessBySAP(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMBootService Antecedent
        {
            get
            {
                CIMBootService result;
                this.GetInfrastructureObjectProperty("Antecedent", out result);
                return result;
            }
        }

        public new CIMBootSAP Dependent
        {
            get
            {
                CIMBootSAP result;
                this.GetInfrastructureObjectProperty("Dependent", out result);
                return result;
            }
        }
    }
}
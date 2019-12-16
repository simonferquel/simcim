using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMClusterServiceAccessBySAP : CIMServiceAccessBySAP
    {
        protected CIMClusterServiceAccessBySAP()
        {
        }

        protected CIMClusterServiceAccessBySAP(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMClusteringService Antecedent
        {
            get
            {
                CIMClusteringService result;
                this.GetInfrastructureObjectProperty("Antecedent", out result);
                return result;
            }
        }

        public new CIMClusteringSAP Dependent
        {
            get
            {
                CIMClusteringSAP result;
                this.GetInfrastructureObjectProperty("Dependent", out result);
                return result;
            }
        }
    }
}
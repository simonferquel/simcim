using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMSAPSAPDependency : CIMDependency
    {
        protected CIMSAPSAPDependency()
        {
        }

        protected CIMSAPSAPDependency(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMServiceAccessPoint Antecedent
        {
            get
            {
                CIMServiceAccessPoint result;
                this.GetInfrastructureObjectProperty("Antecedent", out result);
                return result;
            }

            set
            {
                this.SetProperty("Antecedent", value);
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

            set
            {
                this.SetProperty("Dependent", value);
            }
        }
    }
}
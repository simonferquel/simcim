using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMHostedBootSAP : CIMHostedAccessPoint
    {
        protected CIMHostedBootSAP()
        {
        }

        protected CIMHostedBootSAP(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMUnitaryComputerSystem Antecedent
        {
            get
            {
                CIMUnitaryComputerSystem result;
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
using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class CIMPhase1SAUsedForPhase2 : CIMDependency
    {
        public CIMPhase1SAUsedForPhase2()
        {
        }

        public CIMPhase1SAUsedForPhase2(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMSecurityAssociationEndpoint Antecedent
        {
            get
            {
                CIMSecurityAssociationEndpoint result;
                this.GetInfrastructureObjectProperty("Antecedent", out result);
                return result;
            }

            set
            {
                this.SetProperty("Antecedent", value);
            }
        }

        public new CIMIPsecSAEndpoint Dependent
        {
            get
            {
                CIMIPsecSAEndpoint result;
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
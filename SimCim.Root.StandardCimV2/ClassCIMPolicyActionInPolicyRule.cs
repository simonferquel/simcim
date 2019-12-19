using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class CIMPolicyActionInPolicyRule : CIMPolicyActionStructure
    {
        public CIMPolicyActionInPolicyRule()
        {
        }

        public CIMPolicyActionInPolicyRule(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMPolicyRule GroupComponent
        {
            get
            {
                CIMPolicyRule result;
                this.GetInfrastructureObjectProperty("GroupComponent", out result);
                return result;
            }

            set
            {
                this.SetProperty("GroupComponent", value);
            }
        }
    }
}
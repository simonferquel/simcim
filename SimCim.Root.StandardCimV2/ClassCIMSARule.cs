using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class CIMSARule : CIMPolicyRule
    {
        public CIMSARule()
        {
        }

        public CIMSARule(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16? LimitNegotiation
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("LimitNegotiation", out result);
                return result;
            }

            set
            {
                this.SetProperty("LimitNegotiation", value);
            }
        }
    }
}
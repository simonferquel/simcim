using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public abstract class CIMPolicySet : CIMPolicy
    {
        protected CIMPolicySet()
        {
        }

        protected CIMPolicySet(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16? Enabled
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("Enabled", out result);
                return result;
            }

            set
            {
                this.SetProperty("Enabled", value);
            }
        }

        public System.UInt16? PolicyDecisionStrategy
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("PolicyDecisionStrategy", out result);
                return result;
            }

            set
            {
                this.SetProperty("PolicyDecisionStrategy", value);
            }
        }

        public System.String[] PolicyRoles
        {
            get
            {
                System.String[] result;
                this.GetProperty("PolicyRoles", out result);
                return result;
            }

            set
            {
                this.SetProperty("PolicyRoles", value);
            }
        }
    }
}
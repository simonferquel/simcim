using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTNetFirewallRuleFilters : MSFTNetPolicyRuleFilters
    {
        public MSFTNetFirewallRuleFilters()
        {
        }

        public MSFTNetFirewallRuleFilters(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new MSFTNetFirewallRule GroupComponent
        {
            get
            {
                MSFTNetFirewallRule result;
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
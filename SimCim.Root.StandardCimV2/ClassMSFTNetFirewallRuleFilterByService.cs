using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class MSFTNetFirewallRuleFilterByService : MSFTNetFirewallRuleFilters
    {
        public MSFTNetFirewallRuleFilterByService()
        {
        }

        public MSFTNetFirewallRuleFilterByService(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new MSFTNetServiceFilter PartComponent
        {
            get
            {
                MSFTNetServiceFilter result;
                this.GetInfrastructureObjectProperty("PartComponent", out result);
                return result;
            }

            set
            {
                this.SetProperty("PartComponent", value);
            }
        }
    }
}
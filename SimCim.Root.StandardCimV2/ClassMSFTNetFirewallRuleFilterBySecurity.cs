using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class MSFTNetFirewallRuleFilterBySecurity : MSFTNetFirewallRuleFilters
    {
        public MSFTNetFirewallRuleFilterBySecurity()
        {
        }

        public MSFTNetFirewallRuleFilterBySecurity(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new MSFTNetNetworkLayerSecurityFilter PartComponent
        {
            get
            {
                MSFTNetNetworkLayerSecurityFilter result;
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
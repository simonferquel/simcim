using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class MSFTNetFirewallRuleFilterByInterfaceType : MSFTNetFirewallRuleFilters
    {
        public MSFTNetFirewallRuleFilterByInterfaceType()
        {
        }

        public MSFTNetFirewallRuleFilterByInterfaceType(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new MSFTNetInterfaceTypeFilter PartComponent
        {
            get
            {
                MSFTNetInterfaceTypeFilter result;
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
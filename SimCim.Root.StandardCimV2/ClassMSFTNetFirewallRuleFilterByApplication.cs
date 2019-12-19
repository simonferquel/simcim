using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTNetFirewallRuleFilterByApplication : MSFTNetFirewallRuleFilters
    {
        public MSFTNetFirewallRuleFilterByApplication()
        {
        }

        public MSFTNetFirewallRuleFilterByApplication(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new MSFTNetApplicationFilter PartComponent
        {
            get
            {
                MSFTNetApplicationFilter result;
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
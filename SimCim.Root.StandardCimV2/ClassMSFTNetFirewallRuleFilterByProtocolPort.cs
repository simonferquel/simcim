using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTNetFirewallRuleFilterByProtocolPort : MSFTNetFirewallRuleFilters
    {
        public MSFTNetFirewallRuleFilterByProtocolPort()
        {
        }

        public MSFTNetFirewallRuleFilterByProtocolPort(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new MSFTNetProtocolPortFilter PartComponent
        {
            get
            {
                MSFTNetProtocolPortFilter result;
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
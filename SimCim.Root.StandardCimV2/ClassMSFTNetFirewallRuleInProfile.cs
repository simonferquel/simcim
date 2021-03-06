﻿using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class MSFTNetFirewallRuleInProfile : MSFTNetRuleInProfile
    {
        public MSFTNetFirewallRuleInProfile()
        {
        }

        public MSFTNetFirewallRuleInProfile(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new MSFTNetFirewallRule PartComponent
        {
            get
            {
                MSFTNetFirewallRule result;
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
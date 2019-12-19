﻿using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTNetFirewallRuleFilterByInterface : MSFTNetFirewallRuleFilters
    {
        public MSFTNetFirewallRuleFilterByInterface()
        {
        }

        public MSFTNetFirewallRuleFilterByInterface(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new MSFTNetInterfaceFilter PartComponent
        {
            get
            {
                MSFTNetInterfaceFilter result;
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
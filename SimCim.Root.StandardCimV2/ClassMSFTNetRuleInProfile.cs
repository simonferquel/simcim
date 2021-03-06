﻿using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class MSFTNetRuleInProfile : CIMPolicySetComponent
    {
        public MSFTNetRuleInProfile()
        {
        }

        public MSFTNetRuleInProfile(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new MSFTNetFirewallProfile GroupComponent
        {
            get
            {
                MSFTNetFirewallProfile result;
                this.GetInfrastructureObjectProperty("GroupComponent", out result);
                return result;
            }

            set
            {
                this.SetProperty("GroupComponent", value);
            }
        }

        public new CIMPolicyRule PartComponent
        {
            get
            {
                CIMPolicyRule result;
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
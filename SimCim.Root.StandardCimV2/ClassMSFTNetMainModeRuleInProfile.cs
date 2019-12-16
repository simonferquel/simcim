using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class MSFTNetMainModeRuleInProfile : MSFTNetRuleInProfile
    {
        public MSFTNetMainModeRuleInProfile()
        {
        }

        public MSFTNetMainModeRuleInProfile(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new MSFTNetMainModeRule PartComponent
        {
            get
            {
                MSFTNetMainModeRule result;
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
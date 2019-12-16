using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class MSFTNetConSecRuleInProfile : MSFTNetRuleInProfile
    {
        public MSFTNetConSecRuleInProfile()
        {
        }

        public MSFTNetConSecRuleInProfile(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new MSFTNetConSecRule PartComponent
        {
            get
            {
                MSFTNetConSecRule result;
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
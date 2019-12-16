using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class MSFTNetConSecRuleMMAuthSet : MSFTNetSARuleMMAuth
    {
        public MSFTNetConSecRuleMMAuthSet()
        {
        }

        public MSFTNetConSecRuleMMAuthSet(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new MSFTNetConSecRule GroupComponent
        {
            get
            {
                MSFTNetConSecRule result;
                this.GetInfrastructureObjectProperty("GroupComponent", out result);
                return result;
            }

            set
            {
                this.SetProperty("GroupComponent", value);
            }
        }
    }
}
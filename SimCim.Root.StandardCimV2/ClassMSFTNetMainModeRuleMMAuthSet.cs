using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTNetMainModeRuleMMAuthSet : MSFTNetSARuleMMAuth
    {
        public MSFTNetMainModeRuleMMAuthSet()
        {
        }

        public MSFTNetMainModeRuleMMAuthSet(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new MSFTNetMainModeRule GroupComponent
        {
            get
            {
                MSFTNetMainModeRule result;
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
using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTNetConSecRuleEMAuthSet : MSFTNetSARuleEMAuth
    {
        public MSFTNetConSecRuleEMAuthSet()
        {
        }

        public MSFTNetConSecRuleEMAuthSet(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
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
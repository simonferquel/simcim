using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class MSFTNetConSecRuleFilterByAddress : MSFTNetConSecRuleFilters
    {
        public MSFTNetConSecRuleFilterByAddress()
        {
        }

        public MSFTNetConSecRuleFilterByAddress(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new MSFTNetAddressFilter PartComponent
        {
            get
            {
                MSFTNetAddressFilter result;
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
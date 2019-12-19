using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTNetConSecRuleQMCryptoSet : MSFTNetSARuleQMCrypto
    {
        public MSFTNetConSecRuleQMCryptoSet()
        {
        }

        public MSFTNetConSecRuleQMCryptoSet(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
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
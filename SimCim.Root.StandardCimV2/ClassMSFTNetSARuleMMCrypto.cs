using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class MSFTNetSARuleMMCrypto : MSFTNetSAActionInSARule
    {
        public MSFTNetSARuleMMCrypto()
        {
        }

        public MSFTNetSARuleMMCrypto(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new MSFTNetIKEMMCryptoSet PartComponent
        {
            get
            {
                MSFTNetIKEMMCryptoSet result;
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
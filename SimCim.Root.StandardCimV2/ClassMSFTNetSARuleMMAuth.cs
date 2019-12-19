using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class MSFTNetSARuleMMAuth : MSFTNetSAActionInSARule
    {
        public MSFTNetSARuleMMAuth()
        {
        }

        public MSFTNetSARuleMMAuth(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new MSFTNetIKEP1AuthSet PartComponent
        {
            get
            {
                MSFTNetIKEP1AuthSet result;
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
using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class MSFTNetSARuleEMAuth : MSFTNetSAActionInSARule
    {
        public MSFTNetSARuleEMAuth()
        {
        }

        public MSFTNetSARuleEMAuth(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new MSFTNetIKEP2AuthSet PartComponent
        {
            get
            {
                MSFTNetIKEP2AuthSet result;
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
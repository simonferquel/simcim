using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTNetIKEPSKAuthProposal : MSFTNetIKEAuthProposal
    {
        public MSFTNetIKEPSKAuthProposal()
        {
        }

        public MSFTNetIKEPSKAuthProposal(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String PreSharedKey
        {
            get
            {
                System.String result;
                this.GetProperty("PreSharedKey", out result);
                return result;
            }

            set
            {
                this.SetProperty("PreSharedKey", value);
            }
        }
    }
}
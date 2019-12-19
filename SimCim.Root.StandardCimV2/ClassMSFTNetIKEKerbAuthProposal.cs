using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class MSFTNetIKEKerbAuthProposal : MSFTNetIKEAuthProposal
    {
        public MSFTNetIKEKerbAuthProposal()
        {
        }

        public MSFTNetIKEKerbAuthProposal(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String KerbProxy
        {
            get
            {
                System.String result;
                this.GetProperty("KerbProxy", out result);
                return result;
            }

            set
            {
                this.SetProperty("KerbProxy", value);
            }
        }
    }
}
using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public abstract class CIMSAProposal : CIMScopedSettingData
    {
        protected CIMSAProposal()
        {
        }

        protected CIMSAProposal(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }
    }
}
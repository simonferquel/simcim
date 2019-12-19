﻿using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTNetIKECryptoProposal : CIMIKEProposal
    {
        public MSFTNetIKECryptoProposal()
        {
        }

        public MSFTNetIKECryptoProposal(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }
    }
}
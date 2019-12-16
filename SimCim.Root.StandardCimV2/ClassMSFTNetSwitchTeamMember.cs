﻿using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class MSFTNetSwitchTeamMember : MSFTNetImPlatAdapter
    {
        public MSFTNetSwitchTeamMember()
        {
        }

        public MSFTNetSwitchTeamMember(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }
    }
}
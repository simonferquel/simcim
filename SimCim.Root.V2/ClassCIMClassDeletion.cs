﻿using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class CIMClassDeletion : CIMClassIndication
    {
        public CIMClassDeletion()
        {
        }

        public CIMClassDeletion(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }
    }
}
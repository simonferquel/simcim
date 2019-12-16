using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class CIMInstDeletion : CIMInstIndication
    {
        public CIMInstDeletion()
        {
        }

        public CIMInstDeletion(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }
    }
}
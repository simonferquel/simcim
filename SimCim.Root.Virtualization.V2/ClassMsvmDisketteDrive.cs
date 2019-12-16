using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmDisketteDrive : CIMDisketteDrive
    {
        public MsvmDisketteDrive()
        {
        }

        public MsvmDisketteDrive(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }
    }
}
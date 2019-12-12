using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMDisketteDrive : CIMMediaAccessDevice
    {
        protected CIMDisketteDrive()
        {
        }

        protected CIMDisketteDrive(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }
    }
}
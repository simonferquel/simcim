using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMDiskDrive : CIMMediaAccessDevice
    {
        protected CIMDiskDrive()
        {
        }

        protected CIMDiskDrive(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }
    }
}
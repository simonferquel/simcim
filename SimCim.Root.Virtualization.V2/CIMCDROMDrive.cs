using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMCDROMDrive : CIMMediaAccessDevice
    {
        protected CIMCDROMDrive()
        {
        }

        protected CIMCDROMDrive(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }
    }
}
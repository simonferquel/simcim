using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PNPAllocatedResource : CIMAllocatedResource
    {
        public Win32PNPAllocatedResource()
        {
        }

        public Win32PNPAllocatedResource(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CimInstance Dependent
        {
            get
            {
                CimInstance result;
                this.GetProperty("Dependent", out result);
                return result;
            }
        }
    }
}
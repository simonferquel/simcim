using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PortResource : Win32SystemMemoryResource
    {
        public Win32PortResource()
        {
        }

        public Win32PortResource(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Boolean? Alias
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("Alias", out result);
                return result;
            }
        }
    }
}
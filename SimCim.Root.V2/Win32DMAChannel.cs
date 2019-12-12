using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32DMAChannel : CIMDMA
    {
        public Win32DMAChannel()
        {
        }

        public Win32DMAChannel(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? Port
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Port", out result);
                return result;
            }
        }
    }
}
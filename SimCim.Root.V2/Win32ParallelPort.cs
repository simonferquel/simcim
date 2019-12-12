using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32ParallelPort : CIMParallelController
    {
        public Win32ParallelPort()
        {
        }

        public Win32ParallelPort(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Boolean? OSAutoDiscovered
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("OSAutoDiscovered", out result);
                return result;
            }
        }
    }
}
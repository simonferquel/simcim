using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32IRQResource : CIMIRQ
    {
        public Win32IRQResource()
        {
        }

        public Win32IRQResource(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Boolean? Hardware
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("Hardware", out result);
                return result;
            }
        }

        public System.UInt32? Vector
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Vector", out result);
                return result;
            }
        }
    }
}
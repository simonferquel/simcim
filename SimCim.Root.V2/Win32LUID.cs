using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class Win32LUID : GenericInfrastructureObject
    {
        protected Win32LUID()
        {
        }

        protected Win32LUID(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? HighPart
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("HighPart", out result);
                return result;
            }
        }

        public System.UInt32? LowPart
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("LowPart", out result);
                return result;
            }
        }
    }
}
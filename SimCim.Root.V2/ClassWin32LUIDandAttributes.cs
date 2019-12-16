using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class Win32LUIDandAttributes : GenericInfrastructureObject
    {
        protected Win32LUIDandAttributes()
        {
        }

        protected Win32LUIDandAttributes(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? Attributes
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("Attributes", out result);
                return result;
            }
        }

        public Win32LUID LUID
        {
            get
            {
                Win32LUID result;
                this.GetInfrastructureObjectProperty("LUID", out result);
                return result;
            }
        }
    }
}
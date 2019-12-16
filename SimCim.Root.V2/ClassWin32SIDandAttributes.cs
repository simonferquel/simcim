using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class Win32SIDandAttributes : GenericInfrastructureObject
    {
        protected Win32SIDandAttributes()
        {
        }

        protected Win32SIDandAttributes(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
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

        public Win32SID SID
        {
            get
            {
                Win32SID result;
                this.GetInfrastructureObjectProperty("SID", out result);
                return result;
            }
        }
    }
}
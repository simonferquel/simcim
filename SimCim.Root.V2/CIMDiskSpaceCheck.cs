using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMDiskSpaceCheck : CIMCheck
    {
        protected CIMDiskSpaceCheck()
        {
        }

        protected CIMDiskSpaceCheck(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? AvailableDiskSpace
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("AvailableDiskSpace", out result);
                return result;
            }
        }
    }
}
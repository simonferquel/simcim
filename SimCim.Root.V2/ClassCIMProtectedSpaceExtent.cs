using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMProtectedSpaceExtent : CIMStorageExtent
    {
        protected CIMProtectedSpaceExtent()
        {
        }

        protected CIMProtectedSpaceExtent(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? UserDataStripeDepth
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("UserDataStripeDepth", out result);
                return result;
            }
        }
    }
}
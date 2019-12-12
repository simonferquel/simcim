using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMSwapSpaceCheck : CIMCheck
    {
        protected CIMSwapSpaceCheck()
        {
        }

        protected CIMSwapSpaceCheck(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? SwapSpaceSize
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("SwapSpaceSize", out result);
                return result;
            }
        }
    }
}
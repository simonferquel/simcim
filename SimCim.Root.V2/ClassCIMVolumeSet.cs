using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMVolumeSet : CIMStorageExtent
    {
        protected CIMVolumeSet()
        {
        }

        protected CIMVolumeSet(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? PSExtentInterleaveDepth
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PSExtentInterleaveDepth", out result);
                return result;
            }
        }

        public System.UInt64? PSExtentStripeLength
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("PSExtentStripeLength", out result);
                return result;
            }
        }
    }
}
using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMExtraCapacityGroup : CIMRedundancyGroup
    {
        protected CIMExtraCapacityGroup()
        {
        }

        protected CIMExtraCapacityGroup(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? MinNumberNeeded
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("MinNumberNeeded", out result);
                return result;
            }
        }
    }
}
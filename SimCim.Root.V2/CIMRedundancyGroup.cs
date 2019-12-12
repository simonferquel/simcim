using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMRedundancyGroup : CIMLogicalElement
    {
        protected CIMRedundancyGroup()
        {
        }

        protected CIMRedundancyGroup(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String CreationClassName
        {
            get
            {
                System.String result;
                this.GetProperty("CreationClassName", out result);
                return result;
            }
        }

        public System.UInt16? RedundancyStatus
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("RedundancyStatus", out result);
                return result;
            }
        }
    }
}
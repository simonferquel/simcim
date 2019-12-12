using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMChassisInRack : CIMContainer
    {
        protected CIMChassisInRack()
        {
        }

        protected CIMChassisInRack(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMRack GroupComponent
        {
            get
            {
                CIMRack result;
                this.GetInfrastructureObjectProperty("GroupComponent", out result);
                return result;
            }
        }

        public new CIMChassis PartComponent
        {
            get
            {
                CIMChassis result;
                this.GetInfrastructureObjectProperty("PartComponent", out result);
                return result;
            }
        }

        public System.UInt16? BottomU
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("BottomU", out result);
                return result;
            }
        }
    }
}
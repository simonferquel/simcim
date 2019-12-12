using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMAdjacentSlots : GenericInfrastructureObject
    {
        protected CIMAdjacentSlots()
        {
        }

        protected CIMAdjacentSlots(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Single? DistanceBetweenSlots
        {
            get
            {
                System.Single? result;
                this.GetProperty("DistanceBetweenSlots", out result);
                return result;
            }
        }

        public System.Boolean? SharedSlots
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("SharedSlots", out result);
                return result;
            }
        }

        public CIMSlot SlotA
        {
            get
            {
                CIMSlot result;
                this.GetInfrastructureObjectProperty("SlotA", out result);
                return result;
            }
        }

        public CIMSlot SlotB
        {
            get
            {
                CIMSlot result;
                this.GetInfrastructureObjectProperty("SlotB", out result);
                return result;
            }
        }
    }
}
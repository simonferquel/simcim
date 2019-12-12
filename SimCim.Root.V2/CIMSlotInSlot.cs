using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMSlotInSlot : CIMConnectedTo
    {
        protected CIMSlotInSlot()
        {
        }

        protected CIMSlotInSlot(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMSlot Antecedent
        {
            get
            {
                CIMSlot result;
                this.GetInfrastructureObjectProperty("Antecedent", out result);
                return result;
            }
        }

        public new CIMSlot Dependent
        {
            get
            {
                CIMSlot result;
                this.GetInfrastructureObjectProperty("Dependent", out result);
                return result;
            }
        }
    }
}
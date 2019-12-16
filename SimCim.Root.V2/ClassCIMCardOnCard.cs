using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMCardOnCard : CIMContainer
    {
        protected CIMCardOnCard()
        {
        }

        protected CIMCardOnCard(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMCard GroupComponent
        {
            get
            {
                CIMCard result;
                this.GetInfrastructureObjectProperty("GroupComponent", out result);
                return result;
            }
        }

        public new CIMCard PartComponent
        {
            get
            {
                CIMCard result;
                this.GetInfrastructureObjectProperty("PartComponent", out result);
                return result;
            }
        }

        public System.String MountOrSlotDescription
        {
            get
            {
                System.String result;
                this.GetProperty("MountOrSlotDescription", out result);
                return result;
            }
        }
    }
}
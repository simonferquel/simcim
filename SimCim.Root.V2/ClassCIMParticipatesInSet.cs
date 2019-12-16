using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMParticipatesInSet : GenericInfrastructureObject
    {
        protected CIMParticipatesInSet()
        {
        }

        protected CIMParticipatesInSet(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public CIMPhysicalElement Element
        {
            get
            {
                CIMPhysicalElement result;
                this.GetInfrastructureObjectProperty("Element", out result);
                return result;
            }
        }

        public CIMReplacementSet Set
        {
            get
            {
                CIMReplacementSet result;
                this.GetInfrastructureObjectProperty("Set", out result);
                return result;
            }
        }
    }
}
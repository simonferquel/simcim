using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMMemoryOnCard : CIMPackagedComponent
    {
        protected CIMMemoryOnCard()
        {
        }

        protected CIMMemoryOnCard(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
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

        public new CIMPhysicalMemory PartComponent
        {
            get
            {
                CIMPhysicalMemory result;
                this.GetInfrastructureObjectProperty("PartComponent", out result);
                return result;
            }
        }
    }
}
using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMMemoryWithMedia : CIMDependency
    {
        protected CIMMemoryWithMedia()
        {
        }

        protected CIMMemoryWithMedia(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMPhysicalMemory Antecedent
        {
            get
            {
                CIMPhysicalMemory result;
                this.GetInfrastructureObjectProperty("Antecedent", out result);
                return result;
            }
        }

        public new CIMPhysicalMedia Dependent
        {
            get
            {
                CIMPhysicalMedia result;
                this.GetInfrastructureObjectProperty("Dependent", out result);
                return result;
            }
        }
    }
}
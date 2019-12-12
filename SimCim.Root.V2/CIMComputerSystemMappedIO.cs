using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMComputerSystemMappedIO : CIMComputerSystemResource
    {
        protected CIMComputerSystemMappedIO()
        {
        }

        protected CIMComputerSystemMappedIO(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMMemoryMappedIO PartComponent
        {
            get
            {
                CIMMemoryMappedIO result;
                this.GetInfrastructureObjectProperty("PartComponent", out result);
                return result;
            }
        }
    }
}
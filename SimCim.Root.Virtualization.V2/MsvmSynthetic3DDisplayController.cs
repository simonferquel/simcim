using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmSynthetic3DDisplayController : CIMDisplayController
    {
        public MsvmSynthetic3DDisplayController()
        {
        }

        public MsvmSynthetic3DDisplayController(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String AllocatedGPU
        {
            get
            {
                System.String result;
                this.GetProperty("AllocatedGPU", out result);
                return result;
            }
        }
    }
}
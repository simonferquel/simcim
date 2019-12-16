using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmVideoHeadOnController : CIMVideoHeadOnController
    {
        public MsvmVideoHeadOnController()
        {
        }

        public MsvmVideoHeadOnController(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new MsvmVideoHead Dependent
        {
            get
            {
                MsvmVideoHead result;
                this.GetInfrastructureObjectProperty("Dependent", out result);
                return result;
            }
        }
    }
}
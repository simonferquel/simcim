using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMOSProcess : CIMComponent
    {
        protected CIMOSProcess()
        {
        }

        protected CIMOSProcess(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMOperatingSystem GroupComponent
        {
            get
            {
                CIMOperatingSystem result;
                this.GetInfrastructureObjectProperty("GroupComponent", out result);
                return result;
            }
        }

        public new CIMProcess PartComponent
        {
            get
            {
                CIMProcess result;
                this.GetInfrastructureObjectProperty("PartComponent", out result);
                return result;
            }
        }
    }
}
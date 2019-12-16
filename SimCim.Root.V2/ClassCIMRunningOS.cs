using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMRunningOS : CIMDependency
    {
        protected CIMRunningOS()
        {
        }

        protected CIMRunningOS(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMOperatingSystem Antecedent
        {
            get
            {
                CIMOperatingSystem result;
                this.GetInfrastructureObjectProperty("Antecedent", out result);
                return result;
            }
        }

        public new CIMComputerSystem Dependent
        {
            get
            {
                CIMComputerSystem result;
                this.GetInfrastructureObjectProperty("Dependent", out result);
                return result;
            }
        }
    }
}
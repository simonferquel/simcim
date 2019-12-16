using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMComputerSystemPackage : CIMDependency
    {
        protected CIMComputerSystemPackage()
        {
        }

        protected CIMComputerSystemPackage(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMPhysicalPackage Antecedent
        {
            get
            {
                CIMPhysicalPackage result;
                this.GetInfrastructureObjectProperty("Antecedent", out result);
                return result;
            }
        }

        public new CIMUnitaryComputerSystem Dependent
        {
            get
            {
                CIMUnitaryComputerSystem result;
                this.GetInfrastructureObjectProperty("Dependent", out result);
                return result;
            }
        }
    }
}
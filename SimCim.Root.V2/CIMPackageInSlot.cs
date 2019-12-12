using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMPackageInSlot : CIMDependency
    {
        protected CIMPackageInSlot()
        {
        }

        protected CIMPackageInSlot(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMSlot Antecedent
        {
            get
            {
                CIMSlot result;
                this.GetInfrastructureObjectProperty("Antecedent", out result);
                return result;
            }
        }

        public new CIMPhysicalPackage Dependent
        {
            get
            {
                CIMPhysicalPackage result;
                this.GetInfrastructureObjectProperty("Dependent", out result);
                return result;
            }
        }
    }
}
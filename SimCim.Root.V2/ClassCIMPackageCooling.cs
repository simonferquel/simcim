using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMPackageCooling : CIMDependency
    {
        protected CIMPackageCooling()
        {
        }

        protected CIMPackageCooling(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMCoolingDevice Antecedent
        {
            get
            {
                CIMCoolingDevice result;
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
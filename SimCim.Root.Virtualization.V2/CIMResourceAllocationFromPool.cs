using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMResourceAllocationFromPool : CIMDependency
    {
        protected CIMResourceAllocationFromPool()
        {
        }

        protected CIMResourceAllocationFromPool(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMResourcePool Antecedent
        {
            get
            {
                CIMResourcePool result;
                this.GetInfrastructureObjectProperty("Antecedent", out result);
                return result;
            }

            set
            {
                this.SetProperty("Antecedent", value);
            }
        }

        public new CIMResourceAllocationSettingData Dependent
        {
            get
            {
                CIMResourceAllocationSettingData result;
                this.GetInfrastructureObjectProperty("Dependent", out result);
                return result;
            }

            set
            {
                this.SetProperty("Dependent", value);
            }
        }
    }
}
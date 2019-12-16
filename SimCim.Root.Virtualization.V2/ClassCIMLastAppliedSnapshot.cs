using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMLastAppliedSnapshot : CIMDependency
    {
        protected CIMLastAppliedSnapshot()
        {
        }

        protected CIMLastAppliedSnapshot(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMVirtualSystemSettingData Antecedent
        {
            get
            {
                CIMVirtualSystemSettingData result;
                this.GetInfrastructureObjectProperty("Antecedent", out result);
                return result;
            }

            set
            {
                this.SetProperty("Antecedent", value);
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

            set
            {
                this.SetProperty("Dependent", value);
            }
        }
    }
}
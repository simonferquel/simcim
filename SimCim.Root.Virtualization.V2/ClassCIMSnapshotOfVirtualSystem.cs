using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMSnapshotOfVirtualSystem : CIMDependency
    {
        protected CIMSnapshotOfVirtualSystem()
        {
        }

        protected CIMSnapshotOfVirtualSystem(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMComputerSystem Antecedent
        {
            get
            {
                CIMComputerSystem result;
                this.GetInfrastructureObjectProperty("Antecedent", out result);
                return result;
            }

            set
            {
                this.SetProperty("Antecedent", value);
            }
        }

        public new CIMVirtualSystemSettingData Dependent
        {
            get
            {
                CIMVirtualSystemSettingData result;
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
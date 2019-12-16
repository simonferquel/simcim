using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmParentChildSettingData : CIMDependency
    {
        public MsvmParentChildSettingData()
        {
        }

        public MsvmParentChildSettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new MsvmVirtualSystemSettingData Antecedent
        {
            get
            {
                MsvmVirtualSystemSettingData result;
                this.GetInfrastructureObjectProperty("Antecedent", out result);
                return result;
            }
        }

        public new MsvmVirtualSystemSettingData Dependent
        {
            get
            {
                MsvmVirtualSystemSettingData result;
                this.GetInfrastructureObjectProperty("Dependent", out result);
                return result;
            }
        }
    }
}
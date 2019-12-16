using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmSynthetic3DServiceSettingData : CIMSettingData
    {
        public MsvmSynthetic3DServiceSettingData()
        {
        }

        public MsvmSynthetic3DServiceSettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Boolean? GPUOvercommitEnabled
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("GPUOvercommitEnabled", out result);
                return result;
            }
        }
    }
}
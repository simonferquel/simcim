using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmDiskMergeSettingData : CIMSettingData
    {
        public MsvmDiskMergeSettingData()
        {
        }

        public MsvmDiskMergeSettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? EnabledState
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("EnabledState", out result);
                return result;
            }
        }
    }
}
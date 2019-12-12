using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmStorageSettingData : MsvmSystemComponentSettingData
    {
        public MsvmStorageSettingData()
        {
        }

        public MsvmStorageSettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Boolean? DisableInterruptBatching
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("DisableInterruptBatching", out result);
                return result;
            }
        }

        public System.UInt16? ThreadCountPerChannel
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("ThreadCountPerChannel", out result);
                return result;
            }
        }

        public System.UInt16? VirtualProcessorsPerChannel
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("VirtualProcessorsPerChannel", out result);
                return result;
            }
        }
    }
}
using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTNetAdapterVmqQueueElementSetting : MSFTNetAdapterElementSettingData
    {
        public MSFTNetAdapterVmqQueueElementSetting()
        {
        }

        public MSFTNetAdapterVmqQueueElementSetting(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new MSFTNetAdapterVmqQueueSettingData SettingData
        {
            get
            {
                MSFTNetAdapterVmqQueueSettingData result;
                this.GetInfrastructureObjectProperty("SettingData", out result);
                return result;
            }

            set
            {
                this.SetProperty("SettingData", value);
            }
        }
    }
}
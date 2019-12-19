using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class MSFTNetAdapterVmqElementSetting : MSFTNetAdapterElementSettingData
    {
        public MSFTNetAdapterVmqElementSetting()
        {
        }

        public MSFTNetAdapterVmqElementSetting(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new MSFTNetAdapterVmqSettingData SettingData
        {
            get
            {
                MSFTNetAdapterVmqSettingData result;
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
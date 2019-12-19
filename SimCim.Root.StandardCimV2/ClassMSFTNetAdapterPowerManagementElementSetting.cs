using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTNetAdapterPowerManagementElementSetting : MSFTNetAdapterElementSettingData
    {
        public MSFTNetAdapterPowerManagementElementSetting()
        {
        }

        public MSFTNetAdapterPowerManagementElementSetting(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new MSFTNetAdapterPowerManagementSettingData SettingData
        {
            get
            {
                MSFTNetAdapterPowerManagementSettingData result;
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
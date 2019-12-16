using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class MSFTNetAdapterSriovVfElementSetting : MSFTNetAdapterElementSettingData
    {
        public MSFTNetAdapterSriovVfElementSetting()
        {
        }

        public MSFTNetAdapterSriovVfElementSetting(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new MSFTNetAdapterSriovVfSettingData SettingData
        {
            get
            {
                MSFTNetAdapterSriovVfSettingData result;
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
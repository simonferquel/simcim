using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTNetAdapterRssElementSetting : MSFTNetAdapterElementSettingData
    {
        public MSFTNetAdapterRssElementSetting()
        {
        }

        public MSFTNetAdapterRssElementSetting(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new MSFTNetAdapterRssSettingData SettingData
        {
            get
            {
                MSFTNetAdapterRssSettingData result;
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
using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class MSFTNetAdapterStatisticsElementSetting : MSFTNetAdapterElementSettingData
    {
        public MSFTNetAdapterStatisticsElementSetting()
        {
        }

        public MSFTNetAdapterStatisticsElementSetting(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new MSFTNetAdapterStatisticsSettingData SettingData
        {
            get
            {
                MSFTNetAdapterStatisticsSettingData result;
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
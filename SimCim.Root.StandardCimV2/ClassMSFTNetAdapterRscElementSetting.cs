using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class MSFTNetAdapterRscElementSetting : MSFTNetAdapterElementSettingData
    {
        public MSFTNetAdapterRscElementSetting()
        {
        }

        public MSFTNetAdapterRscElementSetting(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new MSFTNetAdapterRscSettingData SettingData
        {
            get
            {
                MSFTNetAdapterRscSettingData result;
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
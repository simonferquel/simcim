using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class MSFTNetAdapterRdmaElementSetting : MSFTNetAdapterElementSettingData
    {
        public MSFTNetAdapterRdmaElementSetting()
        {
        }

        public MSFTNetAdapterRdmaElementSetting(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new MSFTNetAdapterRdmaSettingData SettingData
        {
            get
            {
                MSFTNetAdapterRdmaSettingData result;
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
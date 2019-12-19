using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTNetAdapterAdvancedPropertyElementSetting : MSFTNetAdapterElementSettingData
    {
        public MSFTNetAdapterAdvancedPropertyElementSetting()
        {
        }

        public MSFTNetAdapterAdvancedPropertyElementSetting(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new MSFTNetAdapterAdvancedPropertySettingData SettingData
        {
            get
            {
                MSFTNetAdapterAdvancedPropertySettingData result;
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
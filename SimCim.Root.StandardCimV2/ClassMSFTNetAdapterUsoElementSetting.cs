using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class MSFTNetAdapterUsoElementSetting : MSFTNetAdapterElementSettingData
    {
        public MSFTNetAdapterUsoElementSetting()
        {
        }

        public MSFTNetAdapterUsoElementSetting(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new MSFTNetAdapterUsoSettingData SettingData
        {
            get
            {
                MSFTNetAdapterUsoSettingData result;
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
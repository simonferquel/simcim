using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class MSFTNetAdapterLsoElementSetting : MSFTNetAdapterElementSettingData
    {
        public MSFTNetAdapterLsoElementSetting()
        {
        }

        public MSFTNetAdapterLsoElementSetting(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new MSFTNetAdapterLsoSettingData SettingData
        {
            get
            {
                MSFTNetAdapterLsoSettingData result;
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
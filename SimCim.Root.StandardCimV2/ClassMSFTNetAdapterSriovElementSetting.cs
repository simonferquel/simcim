using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class MSFTNetAdapterSriovElementSetting : MSFTNetAdapterElementSettingData
    {
        public MSFTNetAdapterSriovElementSetting()
        {
        }

        public MSFTNetAdapterSriovElementSetting(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new MSFTNetAdapterSriovSettingData SettingData
        {
            get
            {
                MSFTNetAdapterSriovSettingData result;
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
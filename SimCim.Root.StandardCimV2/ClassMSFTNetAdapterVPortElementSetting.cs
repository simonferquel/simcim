using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTNetAdapterVPortElementSetting : MSFTNetAdapterElementSettingData
    {
        public MSFTNetAdapterVPortElementSetting()
        {
        }

        public MSFTNetAdapterVPortElementSetting(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new MSFTNetAdapterVPortSettingData SettingData
        {
            get
            {
                MSFTNetAdapterVPortSettingData result;
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
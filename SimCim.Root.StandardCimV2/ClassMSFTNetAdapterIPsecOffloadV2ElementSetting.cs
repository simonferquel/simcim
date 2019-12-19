using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTNetAdapterIPsecOffloadV2ElementSetting : MSFTNetAdapterElementSettingData
    {
        public MSFTNetAdapterIPsecOffloadV2ElementSetting()
        {
        }

        public MSFTNetAdapterIPsecOffloadV2ElementSetting(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new MSFTNetAdapterIPsecOffloadV2SettingData SettingData
        {
            get
            {
                MSFTNetAdapterIPsecOffloadV2SettingData result;
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
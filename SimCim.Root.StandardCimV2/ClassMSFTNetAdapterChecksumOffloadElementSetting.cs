using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class MSFTNetAdapterChecksumOffloadElementSetting : MSFTNetAdapterElementSettingData
    {
        public MSFTNetAdapterChecksumOffloadElementSetting()
        {
        }

        public MSFTNetAdapterChecksumOffloadElementSetting(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new MSFTNetAdapterChecksumOffloadSettingData SettingData
        {
            get
            {
                MSFTNetAdapterChecksumOffloadSettingData result;
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
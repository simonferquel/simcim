using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class MSFTNetAdapterHardwareInfoElementSetting : MSFTNetAdapterElementSettingData
    {
        public MSFTNetAdapterHardwareInfoElementSetting()
        {
        }

        public MSFTNetAdapterHardwareInfoElementSetting(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new MSFTNetAdapterHardwareInfoSettingData SettingData
        {
            get
            {
                MSFTNetAdapterHardwareInfoSettingData result;
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
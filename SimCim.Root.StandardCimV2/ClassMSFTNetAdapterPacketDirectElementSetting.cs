using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTNetAdapterPacketDirectElementSetting : MSFTNetAdapterElementSettingData
    {
        public MSFTNetAdapterPacketDirectElementSetting()
        {
        }

        public MSFTNetAdapterPacketDirectElementSetting(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new MSFTNetAdapterPacketDirectSettingData SettingData
        {
            get
            {
                MSFTNetAdapterPacketDirectSettingData result;
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
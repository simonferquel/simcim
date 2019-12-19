using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTNetAdapterEncapsulatedPacketTaskOffloadElementSetting : MSFTNetAdapterElementSettingData
    {
        public MSFTNetAdapterEncapsulatedPacketTaskOffloadElementSetting()
        {
        }

        public MSFTNetAdapterEncapsulatedPacketTaskOffloadElementSetting(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new MSFTNetAdapterEncapsulatedPacketTaskOffloadSettingData SettingData
        {
            get
            {
                MSFTNetAdapterEncapsulatedPacketTaskOffloadSettingData result;
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
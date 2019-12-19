using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTNetAdapterQosElementSetting : MSFTNetAdapterElementSettingData
    {
        public MSFTNetAdapterQosElementSetting()
        {
        }

        public MSFTNetAdapterQosElementSetting(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new MSFTNetAdapterQosSettingData SettingData
        {
            get
            {
                MSFTNetAdapterQosSettingData result;
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
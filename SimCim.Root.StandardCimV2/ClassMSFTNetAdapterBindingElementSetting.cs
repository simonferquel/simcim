using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTNetAdapterBindingElementSetting : MSFTNetAdapterElementSettingData
    {
        public MSFTNetAdapterBindingElementSetting()
        {
        }

        public MSFTNetAdapterBindingElementSetting(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new MSFTNetAdapterBindingSettingData SettingData
        {
            get
            {
                MSFTNetAdapterBindingSettingData result;
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
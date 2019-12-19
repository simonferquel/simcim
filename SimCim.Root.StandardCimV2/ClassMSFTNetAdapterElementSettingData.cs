using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTNetAdapterElementSettingData : CIMElementSettingData
    {
        public MSFTNetAdapterElementSettingData()
        {
        }

        public MSFTNetAdapterElementSettingData(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new MSFTNetAdapter ManagedElement
        {
            get
            {
                MSFTNetAdapter result;
                this.GetInfrastructureObjectProperty("ManagedElement", out result);
                return result;
            }

            set
            {
                this.SetProperty("ManagedElement", value);
            }
        }

        public new MSFTNetAdapterSettingData SettingData
        {
            get
            {
                MSFTNetAdapterSettingData result;
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
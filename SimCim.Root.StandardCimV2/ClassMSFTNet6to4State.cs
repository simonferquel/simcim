using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTNet6to4State : CIMElementSettingData
    {
        public MSFTNet6to4State()
        {
        }

        public MSFTNet6to4State(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMLANEndpoint ManagedElement
        {
            get
            {
                CIMLANEndpoint result;
                this.GetInfrastructureObjectProperty("ManagedElement", out result);
                return result;
            }

            set
            {
                this.SetProperty("ManagedElement", value);
            }
        }

        public new MSFTNet6to4Configuration SettingData
        {
            get
            {
                MSFTNet6to4Configuration result;
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
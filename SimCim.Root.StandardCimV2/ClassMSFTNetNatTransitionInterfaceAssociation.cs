using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTNetNatTransitionInterfaceAssociation : CIMElementSettingData
    {
        public MSFTNetNatTransitionInterfaceAssociation()
        {
        }

        public MSFTNetNatTransitionInterfaceAssociation(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMNetworkPort ManagedElement
        {
            get
            {
                CIMNetworkPort result;
                this.GetInfrastructureObjectProperty("ManagedElement", out result);
                return result;
            }

            set
            {
                this.SetProperty("ManagedElement", value);
            }
        }

        public new MSFTNetNatTransitionConfiguration SettingData
        {
            get
            {
                MSFTNetNatTransitionConfiguration result;
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
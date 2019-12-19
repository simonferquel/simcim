using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTNetDnsTransitionInterfaceAssociation : CIMElementSettingData
    {
        public MSFTNetDnsTransitionInterfaceAssociation()
        {
        }

        public MSFTNetDnsTransitionInterfaceAssociation(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
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

        public new MSFTNetDnsTransitionConfiguration SettingData
        {
            get
            {
                MSFTNetDnsTransitionConfiguration result;
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
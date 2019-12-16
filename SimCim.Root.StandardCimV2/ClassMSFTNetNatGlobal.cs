using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public class MSFTNetNatGlobal : MSFTNetSettingData
    {
        public MSFTNetNatGlobal()
        {
        }

        public MSFTNetNatGlobal(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? InterRoutingDomainHairpinningMode
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("InterRoutingDomainHairpinningMode", out result);
                return result;
            }

            set
            {
                this.SetProperty("InterRoutingDomainHairpinningMode", value);
            }
        }
    }
}
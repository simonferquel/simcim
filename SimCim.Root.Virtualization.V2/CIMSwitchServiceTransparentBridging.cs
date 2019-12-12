using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMSwitchServiceTransparentBridging : CIMServiceComponent
    {
        protected CIMSwitchServiceTransparentBridging()
        {
        }

        protected CIMSwitchServiceTransparentBridging(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMSwitchService GroupComponent
        {
            get
            {
                CIMSwitchService result;
                this.GetInfrastructureObjectProperty("GroupComponent", out result);
                return result;
            }

            set
            {
                this.SetProperty("GroupComponent", value);
            }
        }

        public new CIMTransparentBridgingService PartComponent
        {
            get
            {
                CIMTransparentBridgingService result;
                this.GetInfrastructureObjectProperty("PartComponent", out result);
                return result;
            }

            set
            {
                this.SetProperty("PartComponent", value);
            }
        }
    }
}
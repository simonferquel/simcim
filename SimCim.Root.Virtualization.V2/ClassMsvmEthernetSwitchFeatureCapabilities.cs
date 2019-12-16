using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmEthernetSwitchFeatureCapabilities : CIMCapabilities
    {
        public MsvmEthernetSwitchFeatureCapabilities()
        {
        }

        public MsvmEthernetSwitchFeatureCapabilities(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16? Applicability
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("Applicability", out result);
                return result;
            }
        }

        public System.String FeatureId
        {
            get
            {
                System.String result;
                this.GetProperty("FeatureId", out result);
                return result;
            }
        }

        public System.String Version
        {
            get
            {
                System.String result;
                this.GetProperty("Version", out result);
                return result;
            }
        }
    }
}
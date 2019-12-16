using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmEthernetSwitchExtensionCapabilities : CIMElementCapabilities
    {
        public MsvmEthernetSwitchExtensionCapabilities()
        {
        }

        public MsvmEthernetSwitchExtensionCapabilities(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new MsvmEthernetSwitchFeatureCapabilities Capabilities
        {
            get
            {
                MsvmEthernetSwitchFeatureCapabilities result;
                this.GetInfrastructureObjectProperty("Capabilities", out result);
                return result;
            }
        }

        public new MsvmInstalledEthernetSwitchExtension ManagedElement
        {
            get
            {
                MsvmInstalledEthernetSwitchExtension result;
                this.GetInfrastructureObjectProperty("ManagedElement", out result);
                return result;
            }
        }
    }
}
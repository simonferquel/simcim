using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTNetAdapterEncapsulatedPacketTaskOffloadCapabilitiesEx : MSFTNetAdapterEncapsulatedPacketTaskOffloadCapabilities
    {
        public MSFTNetAdapterEncapsulatedPacketTaskOffloadCapabilitiesEx()
        {
        }

        public MSFTNetAdapterEncapsulatedPacketTaskOffloadCapabilitiesEx(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Boolean? IsVxlanUDPPortConfigurable
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("IsVxlanUDPPortConfigurable", out result);
                return result;
            }
        }

        public System.UInt16? VxlanUDPPortNumber
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("VxlanUDPPortNumber", out result);
                return result;
            }
        }
    }
}
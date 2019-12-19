using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTNetAdapterRscCapabilities : GenericInfrastructureObject
    {
        public MSFTNetAdapterRscCapabilities()
        {
        }

        public MSFTNetAdapterRscCapabilities(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Boolean? IPv4Supported
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("IPv4Supported", out result);
                return result;
            }
        }

        public System.Boolean? IPv6Supported
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("IPv6Supported", out result);
                return result;
            }
        }
    }
}
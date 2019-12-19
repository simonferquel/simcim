using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class CIMDNSProtocolEndpoint : CIMProtocolEndpoint
    {
        public CIMDNSProtocolEndpoint()
        {
        }

        public CIMDNSProtocolEndpoint(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16[] DHCPOptionsToUse
        {
            get
            {
                System.UInt16[] result;
                this.GetProperty("DHCPOptionsToUse", out result);
                return result;
            }

            set
            {
                this.SetProperty("DHCPOptionsToUse", value);
            }
        }

        public System.String Hostname
        {
            get
            {
                System.String result;
                this.GetProperty("Hostname", out result);
                return result;
            }

            set
            {
                this.SetProperty("Hostname", value);
            }
        }
    }
}
using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.StandardCimV2
{
    public class MSFTNetAdapterPowerManagementWakePatternTcpSyn : MSFTNetAdapterPowerManagementWakePattern
    {
        public MSFTNetAdapterPowerManagementWakePatternTcpSyn()
        {
        }

        public MSFTNetAdapterPowerManagementWakePatternTcpSyn(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String DestinationAddress
        {
            get
            {
                System.String result;
                this.GetProperty("DestinationAddress", out result);
                return result;
            }
        }

        public System.UInt16? DestinationPort
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("DestinationPort", out result);
                return result;
            }
        }

        public System.String SourceAddress
        {
            get
            {
                System.String result;
                this.GetProperty("SourceAddress", out result);
                return result;
            }
        }

        public System.UInt16? SourcePort
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("SourcePort", out result);
                return result;
            }
        }
    }
}
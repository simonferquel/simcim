using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmFcEndpoint : CIMProtocolEndpoint
    {
        public MsvmFcEndpoint()
        {
        }

        public MsvmFcEndpoint(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Boolean? Connected
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("Connected", out result);
                return result;
            }
        }

        public System.String WWNN
        {
            get
            {
                System.String result;
                this.GetProperty("WWNN", out result);
                return result;
            }
        }

        public System.String WWPN
        {
            get
            {
                System.String result;
                this.GetProperty("WWPN", out result);
                return result;
            }
        }
    }
}
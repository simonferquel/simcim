using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmWiFiPort : CIMWiFiPort
    {
        public MsvmWiFiPort()
        {
        }

        public MsvmWiFiPort(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Boolean? IsBound
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("IsBound", out result);
                return result;
            }
        }
    }
}
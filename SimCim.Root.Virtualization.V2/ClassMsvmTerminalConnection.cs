using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmTerminalConnection : CIMEnabledLogicalElement
    {
        public MsvmTerminalConnection()
        {
        }

        public MsvmTerminalConnection(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String ConnectionID
        {
            get
            {
                System.String result;
                this.GetProperty("ConnectionID", out result);
                return result;
            }
        }
    }
}
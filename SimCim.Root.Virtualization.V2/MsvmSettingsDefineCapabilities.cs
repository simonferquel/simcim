using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmSettingsDefineCapabilities : CIMSettingsDefineCapabilities
    {
        public MsvmSettingsDefineCapabilities()
        {
        }

        public MsvmSettingsDefineCapabilities(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16? SupportStatement
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("SupportStatement", out result);
                return result;
            }
        }
    }
}
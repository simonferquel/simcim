using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmExternalEthernetPortCapabilities : CIMCapabilities
    {
        public MsvmExternalEthernetPortCapabilities()
        {
        }

        public MsvmExternalEthernetPortCapabilities(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Boolean? IOVSupport
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("IOVSupport", out result);
                return result;
            }
        }

        public System.String[] IOVSupportReasons
        {
            get
            {
                System.String[] result;
                this.GetProperty("IOVSupportReasons", out result);
                return result;
            }
        }
    }
}
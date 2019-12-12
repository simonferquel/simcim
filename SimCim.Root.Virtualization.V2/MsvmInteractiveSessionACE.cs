using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmInteractiveSessionACE : GenericInfrastructureObject
    {
        public MsvmInteractiveSessionACE()
        {
        }

        public MsvmInteractiveSessionACE(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16? AccessType
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("AccessType", out result);
                return result;
            }
        }

        public System.String Trustee
        {
            get
            {
                System.String result;
                this.GetProperty("Trustee", out result);
                return result;
            }
        }
    }
}
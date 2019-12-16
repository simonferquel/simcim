using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class ThisNAMESPACE : SystemClass
    {
        public ThisNAMESPACE()
        {
        }

        public ThisNAMESPACE(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Byte[] SECURITYDESCRIPTOR
        {
            get
            {
                System.Byte[] result;
                this.GetProperty("SECURITY_DESCRIPTOR", out result);
                return result;
            }

            set
            {
                this.SetProperty("SECURITY_DESCRIPTOR", value);
            }
        }
    }
}
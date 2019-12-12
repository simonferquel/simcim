using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class Win32ACE : ACE
    {
        protected Win32ACE()
        {
        }

        protected Win32ACE(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new Win32Trustee Trustee
        {
            get
            {
                Win32Trustee result;
                this.GetInfrastructureObjectProperty("Trustee", out result);
                return result;
            }

            set
            {
                this.SetProperty("Trustee", value);
            }
        }
    }
}
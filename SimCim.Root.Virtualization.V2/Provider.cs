using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class Provider : SystemClass
    {
        protected Provider()
        {
        }

        protected Provider(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String Name
        {
            get
            {
                System.String result;
                this.GetProperty("Name", out result);
                return result;
            }

            set
            {
                this.SetProperty("Name", value);
            }
        }
    }
}
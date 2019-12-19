using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public abstract class MSFTNetImPlatProvider : CIMManagedElement
    {
        protected MSFTNetImPlatProvider()
        {
        }

        protected MSFTNetImPlatProvider(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
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
        }
    }
}
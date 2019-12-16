using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMInstalledOS : CIMSystemComponent
    {
        protected CIMInstalledOS()
        {
        }

        protected CIMInstalledOS(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMComputerSystem GroupComponent
        {
            get
            {
                CIMComputerSystem result;
                this.GetInfrastructureObjectProperty("GroupComponent", out result);
                return result;
            }
        }

        public new CIMOperatingSystem PartComponent
        {
            get
            {
                CIMOperatingSystem result;
                this.GetInfrastructureObjectProperty("PartComponent", out result);
                return result;
            }
        }

        public System.Boolean? PrimaryOS
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("PrimaryOS", out result);
                return result;
            }
        }
    }
}
using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMUserDevice : CIMLogicalDevice
    {
        protected CIMUserDevice()
        {
        }

        protected CIMUserDevice(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Boolean? IsLocked
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("IsLocked", out result);
                return result;
            }

            set
            {
                this.SetProperty("IsLocked", value);
            }
        }
    }
}
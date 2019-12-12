using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMVersionCompatibilityCheck : CIMCheck
    {
        protected CIMVersionCompatibilityCheck()
        {
        }

        protected CIMVersionCompatibilityCheck(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Boolean? AllowDownVersion
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("AllowDownVersion", out result);
                return result;
            }
        }

        public System.Boolean? AllowMultipleVersions
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("AllowMultipleVersions", out result);
                return result;
            }
        }

        public System.Boolean? Reinstall
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("Reinstall", out result);
                return result;
            }
        }
    }
}
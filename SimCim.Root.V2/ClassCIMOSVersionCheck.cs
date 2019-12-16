using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class CIMOSVersionCheck : CIMCheck
    {
        protected CIMOSVersionCheck()
        {
        }

        protected CIMOSVersionCheck(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String MaximumVersion
        {
            get
            {
                System.String result;
                this.GetProperty("MaximumVersion", out result);
                return result;
            }
        }

        public System.String MinimumVersion
        {
            get
            {
                System.String result;
                this.GetProperty("MinimumVersion", out result);
                return result;
            }
        }
    }
}
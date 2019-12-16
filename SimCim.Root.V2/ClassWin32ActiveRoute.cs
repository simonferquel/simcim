using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32ActiveRoute : CIMLogicalIdentity
    {
        public Win32ActiveRoute()
        {
        }

        public Win32ActiveRoute(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new Win32IP4PersistedRouteTable SameElement
        {
            get
            {
                Win32IP4PersistedRouteTable result;
                this.GetInfrastructureObjectProperty("SameElement", out result);
                return result;
            }
        }

        public new Win32IP4RouteTable SystemElement
        {
            get
            {
                Win32IP4RouteTable result;
                this.GetInfrastructureObjectProperty("SystemElement", out result);
                return result;
            }
        }
    }
}
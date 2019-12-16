using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class Win32TokenGroups : GenericInfrastructureObject
    {
        protected Win32TokenGroups()
        {
        }

        protected Win32TokenGroups(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? GroupCount
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("GroupCount", out result);
                return result;
            }
        }

        public IEnumerable<Win32SIDandAttributes> Groups
        {
            get
            {
                IEnumerable<Win32SIDandAttributes> result;
                this.GetInfrastructureObjectProperty("Groups", out result);
                return result;
            }
        }
    }
}
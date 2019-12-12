using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class Win32TokenPrivileges : GenericInfrastructureObject
    {
        protected Win32TokenPrivileges()
        {
        }

        protected Win32TokenPrivileges(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt32? PrivilegeCount
        {
            get
            {
                System.UInt32? result;
                this.GetProperty("PrivilegeCount", out result);
                return result;
            }
        }

        public IEnumerable<Win32LUIDandAttributes> Privileges
        {
            get
            {
                IEnumerable<Win32LUIDandAttributes> result;
                this.GetInfrastructureObjectProperty("Privileges", out result);
                return result;
            }
        }
    }
}
using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PrivilegesStatus : ExtendedStatus
    {
        public Win32PrivilegesStatus()
        {
        }

        public Win32PrivilegesStatus(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.String[] PrivilegesNotHeld
        {
            get
            {
                System.String[] result;
                this.GetProperty("PrivilegesNotHeld", out result);
                return result;
            }
        }

        public System.String[] PrivilegesRequired
        {
            get
            {
                System.String[] result;
                this.GetProperty("PrivilegesRequired", out result);
                return result;
            }
        }
    }
}
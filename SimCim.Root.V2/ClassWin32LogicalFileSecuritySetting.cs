using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32LogicalFileSecuritySetting : Win32SecuritySetting
    {
        public Win32LogicalFileSecuritySetting()
        {
        }

        public Win32LogicalFileSecuritySetting(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.Boolean? OwnerPermissions
        {
            get
            {
                System.Boolean? result;
                this.GetProperty("OwnerPermissions", out result);
                return result;
            }
        }

        public System.String Path
        {
            get
            {
                System.String result;
                this.GetProperty("Path", out result);
                return result;
            }
        }
    }
}
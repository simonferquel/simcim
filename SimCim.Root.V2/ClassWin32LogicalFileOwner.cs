using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32LogicalFileOwner : Win32SecuritySettingOwner
    {
        public Win32LogicalFileOwner()
        {
        }

        public Win32LogicalFileOwner(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new Win32LogicalFileSecuritySetting SecuritySetting
        {
            get
            {
                Win32LogicalFileSecuritySetting result;
                this.GetInfrastructureObjectProperty("SecuritySetting", out result);
                return result;
            }
        }
    }
}
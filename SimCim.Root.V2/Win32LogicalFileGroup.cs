using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32LogicalFileGroup : Win32SecuritySettingGroup
    {
        public Win32LogicalFileGroup()
        {
        }

        public Win32LogicalFileGroup(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
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
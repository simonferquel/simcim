using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32LogicalShareAuditing : Win32SecuritySettingAuditing
    {
        public Win32LogicalShareAuditing()
        {
        }

        public Win32LogicalShareAuditing(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new Win32LogicalShareSecuritySetting SecuritySetting
        {
            get
            {
                Win32LogicalShareSecuritySetting result;
                this.GetInfrastructureObjectProperty("SecuritySetting", out result);
                return result;
            }
        }
    }
}
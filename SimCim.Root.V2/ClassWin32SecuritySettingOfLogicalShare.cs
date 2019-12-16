using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32SecuritySettingOfLogicalShare : Win32SecuritySettingOfObject
    {
        public Win32SecuritySettingOfLogicalShare()
        {
        }

        public Win32SecuritySettingOfLogicalShare(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new Win32Share Element
        {
            get
            {
                Win32Share result;
                this.GetInfrastructureObjectProperty("Element", out result);
                return result;
            }
        }

        public new Win32LogicalShareSecuritySetting Setting
        {
            get
            {
                Win32LogicalShareSecuritySetting result;
                this.GetInfrastructureObjectProperty("Setting", out result);
                return result;
            }
        }
    }
}
using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32SecuritySettingOfLogicalFile : Win32SecuritySettingOfObject
    {
        public Win32SecuritySettingOfLogicalFile()
        {
        }

        public Win32SecuritySettingOfLogicalFile(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMLogicalFile Element
        {
            get
            {
                CIMLogicalFile result;
                this.GetInfrastructureObjectProperty("Element", out result);
                return result;
            }
        }

        public new Win32LogicalFileSecuritySetting Setting
        {
            get
            {
                Win32LogicalFileSecuritySetting result;
                this.GetInfrastructureObjectProperty("Setting", out result);
                return result;
            }
        }
    }
}
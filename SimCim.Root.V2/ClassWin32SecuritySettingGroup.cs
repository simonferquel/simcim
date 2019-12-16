using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class Win32SecuritySettingGroup : GenericInfrastructureObject
    {
        protected Win32SecuritySettingGroup()
        {
        }

        protected Win32SecuritySettingGroup(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public Win32SID Group
        {
            get
            {
                Win32SID result;
                this.GetInfrastructureObjectProperty("Group", out result);
                return result;
            }
        }

        public Win32SecuritySetting SecuritySetting
        {
            get
            {
                Win32SecuritySetting result;
                this.GetInfrastructureObjectProperty("SecuritySetting", out result);
                return result;
            }
        }
    }
}
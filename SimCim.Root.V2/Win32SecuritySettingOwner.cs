using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class Win32SecuritySettingOwner : GenericInfrastructureObject
    {
        protected Win32SecuritySettingOwner()
        {
        }

        protected Win32SecuritySettingOwner(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public Win32SID Owner
        {
            get
            {
                Win32SID result;
                this.GetInfrastructureObjectProperty("Owner", out result);
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
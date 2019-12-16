using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class Win32SettingCheck : GenericInfrastructureObject
    {
        protected Win32SettingCheck()
        {
        }

        protected Win32SettingCheck(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public CIMCheck Check
        {
            get
            {
                CIMCheck result;
                this.GetInfrastructureObjectProperty("Check", out result);
                return result;
            }
        }

        public CIMSetting Setting
        {
            get
            {
                CIMSetting result;
                this.GetInfrastructureObjectProperty("Setting", out result);
                return result;
            }
        }
    }
}
using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class Win32SecuritySettingOfObject : CIMElementSetting
    {
        protected Win32SecuritySettingOfObject()
        {
        }

        protected Win32SecuritySettingOfObject(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMLogicalElement Element
        {
            get
            {
                CIMLogicalElement result;
                this.GetInfrastructureObjectProperty("Element", out result);
                return result;
            }
        }

        public new Win32SecuritySetting Setting
        {
            get
            {
                Win32SecuritySetting result;
                this.GetInfrastructureObjectProperty("Setting", out result);
                return result;
            }
        }
    }
}
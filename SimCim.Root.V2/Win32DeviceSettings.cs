using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public abstract class Win32DeviceSettings : CIMElementSetting
    {
        protected Win32DeviceSettings()
        {
        }

        protected Win32DeviceSettings(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new CIMLogicalDevice Element
        {
            get
            {
                CIMLogicalDevice result;
                this.GetInfrastructureObjectProperty("Element", out result);
                return result;
            }
        }
    }
}
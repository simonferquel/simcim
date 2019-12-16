using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32COMApplicationSettings : CIMElementSetting
    {
        public Win32COMApplicationSettings()
        {
        }

        public Win32COMApplicationSettings(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new Win32DCOMApplication Element
        {
            get
            {
                Win32DCOMApplication result;
                this.GetInfrastructureObjectProperty("Element", out result);
                return result;
            }
        }

        public new Win32DCOMApplicationSetting Setting
        {
            get
            {
                Win32DCOMApplicationSetting result;
                this.GetInfrastructureObjectProperty("Setting", out result);
                return result;
            }
        }
    }
}
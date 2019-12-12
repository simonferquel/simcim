using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class Win32PageFileElementSetting : CIMElementSetting
    {
        public Win32PageFileElementSetting()
        {
        }

        public Win32PageFileElementSetting(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public new Win32PageFileUsage Element
        {
            get
            {
                Win32PageFileUsage result;
                this.GetInfrastructureObjectProperty("Element", out result);
                return result;
            }
        }

        public new Win32PageFileSetting Setting
        {
            get
            {
                Win32PageFileSetting result;
                this.GetInfrastructureObjectProperty("Setting", out result);
                return result;
            }
        }
    }
}